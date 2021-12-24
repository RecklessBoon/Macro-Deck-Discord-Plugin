using DiscordRPC;
using DiscordRPC.IO;
using DiscordRPC.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecklessBoon.MacroDeck.Discord.RPC.Model;
using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace RecklessBoon.MacroDeck.Discord.RPC
{

    public class RPCClient : IDisposable
    {
        const int TOKEN_REFRESH_BUFFER_HOURS = 48;

        public readonly static string[] SCOPES_REQUIRED = new string[]
        {
            "identify",
            //"email",
            //"connections",
            //"guilds",
            //"guilds.join",
            //"guilds.members.read",
            //"gdm.join",
            "rpc",
            //"rpc.notifications.read",
            //"rpc.voice.read",
            //"rpc.voice.write",
            //"rpc.activities.write",
            //"webhook.incoming",
            //"activities.read",
            //"activities.write",
            //"relationshiops.read"
        };

        public event EventHandler<AuthToken> OnLoginComplete;

        public event EventHandler<Payload> OnDispatch;
        public event EventHandler<Payload> OnReady;
        public event EventHandler<Payload> OnError;
        public event EventHandler<Payload> OnGuildStatus;
        public event EventHandler<Payload> OnGuildCreate;
        public event EventHandler<Payload> OnChannelCreate;
        public event EventHandler<ChannelSelectResponse> OnVoiceChannelSelect;
        public event EventHandler<VoiceStateResponse> OnVoiceStateCreate;
        public event EventHandler<VoiceStateResponse> OnVoiceStateUpdate;
        public event EventHandler<VoiceStateResponse> OnVoiceStateDelete;
        public event EventHandler<VoiceSettingsResponse> OnVoiceSettingsUpdate;
        public event EventHandler<Payload> OnVoiceConnectionStatus;
        public event EventHandler<Payload> OnSpeakingStart;
        public event EventHandler<Payload> OnSpeakingStop;
        public event EventHandler<Payload> OnMessageCreate;
        public event EventHandler<Payload> OnMessageUpdate;
        public event EventHandler<Payload> OnMessageDelete;
        public event EventHandler<Payload> OnNotificationCreate;
        public event EventHandler<Payload> OnActivityJoin;
        public event EventHandler<Payload> OnActivitySpectate;
        public event EventHandler<Payload> OnActivityJoinRequest;

        public string ApplicationID { get; set; }

        protected ILogger _logger;
        protected PipeClient _pipe;
        protected DiscordRpcClient _client;
        protected bool _connected = false;
        public bool IsConnected { get { return _connected; } }
        protected bool _disposed = false;
        public bool IsDisposed { get { return _disposed; } }

        public RPCClient(string applicationId)
        {
            ApplicationID = applicationId;
            _pipe = new PipeClient();
            _logger = Debugger.IsAttached && Debugger.IsLogging() ? new DebugLogger() : null;
            _client = new DiscordRpcClient(applicationID: ApplicationID, client: _pipe, logger: _logger);
        }

        public void Dispose()
        {
            _pipe?.Dispose();
            _client?.Dispose();
            _disposed = true;
        }

        public bool Start()
        {
            var config = PluginInstance.Plugin.configuration;
            if (String.IsNullOrEmpty(config.ClientId) || String.IsNullOrEmpty(config.ClientSecret))
                return false;

            _client.OnReady += LoginClient;
            _client.Initialize();

            _pipe.FrameRead += (object sender, PipeFrame frame) =>
            {
                Payload payload = JsonConvert.DeserializeObject<Payload>(frame.Message);
                OnDispatch?.Invoke(this, payload);
            };

            OnLoginComplete += async (object sender, AuthToken args) =>
            {
                OnDispatch += RouteEvent;
                _ = Subscribe("VOICE_CHANNEL_SELECT");
                _ = Subscribe("VOICE_SETTINGS_UPDATE");
                OnVoiceChannelSelect += Client_OnVoiceChannelSelect;

                await InitCurrentVoiceChannel();
            };

            return true;
        }

        private async Task InitCurrentVoiceChannel()
        {
            var payload = await Command("GET_SELECTED_VOICE_CHANNEL");

            if (payload.Data != null)
            {
                await SetCurrentChannel(payload.Data);
                _logger?.Info("\nCurrent Selected Voice Channel Response:\n{0}", JsonConvert.SerializeObject(payload));
            }
        }

        private async Task SetCurrentChannel(JObject payload) => await SetCurrentChannel(payload.ToObject<GetChannelResponse>());
        private async Task SetCurrentChannel(GetChannelResponse channel)
        {
            var cache = PluginInstance.cache;

            cache.VoiceState = channel.VoiceStates.First();
            if (ulong.TryParse(channel.GuildId, out ulong guildId))
            {
                cache.CurrentGuildID = guildId;
            }
            if (ulong.TryParse(channel.Id, out ulong channelId))
            {
                cache.CurrentVoiceChannelID = channelId;
            }

            if (cache.CurrentVoiceChannelID != default)
            {
                await Subscribe("VOICE_STATE_UPDATE", new { channel_id = (string)cache.CurrentVoiceChannelID.ToString() });
            }
            await Task.CompletedTask;
        }

        private void Client_OnVoiceChannelSelect(object sender, ChannelSelectResponse payload)
        {
            _logger?.Info("\nOnVoiceChannelSelect:\n{0}", JsonConvert.SerializeObject(payload).ToString());

            var cache = PluginInstance.cache;

            var oldVoiceChannelId = cache.CurrentVoiceChannelID;
            cache.CurrentVoiceChannelID = null;
            cache.CurrentGuildID = null;
            if (ulong.TryParse(payload.Id, out ulong channelId))
            {
                cache.CurrentVoiceChannelID = channelId;
            }
            if (ulong.TryParse(payload.GuildId, out ulong guildId))
            {
                cache.CurrentGuildID = guildId;
            }

            if (oldVoiceChannelId != default && cache.CurrentVoiceChannelID != oldVoiceChannelId)
            {
                _ = Unsubscribe("VOICE_STATE_UPDATE", new
                {
                    channel_id = (string)oldVoiceChannelId.ToString()
                });
            }
            if (cache.CurrentVoiceChannelID != default)
            {
                _ = Subscribe("VOICE_STATE_UPDATE", new
                {
                    channel_id = (string)cache.CurrentVoiceChannelID.ToString()
                });
            }
        }

        protected async void LoginClient(object sender, DiscordRPC.Message.ReadyMessage args)
        {
            if (!_connected)
            {
                AuthToken token = await GetCurrentToken();

                if (token == null || token.Scopes == null || !Enumerable.SequenceEqual(token.Scopes, SCOPES_REQUIRED))
                {
                    token = await GetNewToken();
                    CredentialsHelper.UpsertCredential("auth_token", token);
                }
                var response = await Authenticate(token.Token);
                if (response == null)
                {
                    CredentialsHelper.RemoveCredential("auth_token");
                    token = await GetNewToken();
                    CredentialsHelper.UpsertCredential("auth_token", token);
                    response = await Authenticate(token.Token);
                }
                PluginInstance.cache.CurrentUser = response.User;
                OnLoginComplete?.Invoke(sender, token);
                _connected = true;
            }
        }

        protected async Task<AuthToken> GetCurrentToken()
        {
            AuthToken token = null;
            var creds = PluginCredentials.GetPluginCredentials(PluginInstance.Plugin)?.First();
            if (creds != null && creds.ContainsKey("auth_token"))
            {
                var authToken = JsonConvert.DeserializeObject<AuthToken>(creds["auth_token"]);
                // TODO: Check expiration time
                if (authToken != null && authToken.Token != null)
                {
                    if (authToken.Expires.Subtract(new TimeSpan(TOKEN_REFRESH_BUFFER_HOURS, 0, 0)) > DateTime.Now)
                    {
                        token = authToken;
                    }
                    else if (authToken.RefreshToken != null)
                    {
                        token = await RenewToken(authToken);
                    }
                }
            }

            return token;
        }

        protected async Task<AuthToken> GetNewToken()
        {
            var code = await Authorize();
            var tokenResponse = await SwapForToken(code);
            var token = AuthTokenHelper.CreateFrom(SCOPES_REQUIRED, tokenResponse);
            return token;
        }

        protected async Task<AuthToken> RenewToken(AuthToken oldToken)
        {
            var tokenResponse = await RefreshToken(oldToken);

            if (tokenResponse == null)
                return null;

            var token = AuthTokenHelper.CreateFrom(SCOPES_REQUIRED, tokenResponse);

            return token;
        }

        protected static string GenerateNonce()
        {
            var ByteArray = new byte[20];
            //Generate a cryptographically random set of bytes
            using (var Rnd = RandomNumberGenerator.Create())
            {
                Rnd.GetBytes(ByteArray);
            }
            //Base64 encode and then return
            return Convert.ToBase64String(ByteArray);
        }

        protected async Task<string> Authorize()
        {
            var payload = await Command("AUTHORIZE", new
            {
                scopes = String.Join(" ", SCOPES_REQUIRED),
                client_id = PluginInstance.Plugin.configuration.ClientId
            });

            _logger?.Info("\nAuthorize Response:\n{0}", JsonConvert.SerializeObject(payload));
            var auth_response = payload.Data.ToObject<AuthorizeResponse>();

            return auth_response.Code;
        }

        protected async Task<TokenResponse> SwapForToken(string code)
        {
            // Post code to https://discord.com/api/oauth2/token for a token
            var http = new HttpClient();
            var http_request = new HttpRequestMessage(HttpMethod.Post, "https://discord.com/api/oauth2/token")
            {
                Content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("grant_type", "authorization_code"),
                        new KeyValuePair<string, string>("code", code.ToString()),
                        new KeyValuePair<string, string>("client_id", PluginInstance.Plugin.configuration.ClientId),
                        new KeyValuePair<string, string>("client_secret", PluginInstance.Plugin.configuration.ClientSecret)
                    })
            };
            var http_response = await http.SendAsync(http_request);
            http_response.EnsureSuccessStatusCode();

            var content = await http_response.Content.ReadAsStringAsync();
            _logger?.Info("\nToken Swap Response:\n{0}", content);

            var json_response = JsonConvert.DeserializeObject<TokenResponse>(content);
            return json_response;
        }

        protected async Task<TokenResponse> RefreshToken(AuthToken token)
        {
            // Post code to https://discord.com/api/oauth2/token for a token
            var http = new HttpClient();
            var http_request = new HttpRequestMessage(HttpMethod.Post, "https://discord.com/api/oauth2/token")
            {
                Content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("grant_type", "refresh_token"),
                        new KeyValuePair<string, string>("refresh_token", token.RefreshToken),
                        new KeyValuePair<string, string>("client_id", PluginInstance.Plugin.configuration.ClientId),
                        new KeyValuePair<string, string>("client_secret", PluginInstance.Plugin.configuration.ClientSecret)
                    })
            };
            var http_response = await http.SendAsync(http_request);
            TokenResponse json_response = null;
            try
            {
                http_response.EnsureSuccessStatusCode();

                var content = await http_response.Content.ReadAsStringAsync();
                _logger?.Info("\nToken Refresh Response:\n{0}", content);

                json_response = JsonConvert.DeserializeObject<TokenResponse>(content);
            }
            catch (Exception ex)
            {
                _logger?.Trace("\nToken Refresh Response Failed:\n{0}", ex.Message);
            }
            return json_response;
        }

        protected async Task<AuthenticateResponse> Authenticate(string token)
        {
            var payload = await Command("AUTHENTICATE", new
            {
                access_token = token
            });

            _logger?.Info("\nAuthenticate Response:\n{0}", JsonConvert.SerializeObject(payload));
            var auth_response = payload.Data.ToObject<AuthenticateResponse>();
            if (auth_response.User == null || auth_response.Expires == null || auth_response.Application == null || auth_response.Scopes == null)
            {
                return null;
            }

            return auth_response;
        }

        protected async Task Subscribe(string evt, object args = null)
        {
            var payload = await Command("SUBSCRIBE", args, evt);
            _logger?.Info("\nSubscribe Response:\n{0}", JsonConvert.SerializeObject(payload));
        }

        protected async Task Unsubscribe(string evt, object args = null)
        {
            var payload = await Command("UNSUBSCRIBE", args, evt);
            _logger?.Info("\nUnsubscribe Response:\n{0}", JsonConvert.SerializeObject(payload));
        }

        public async Task<Payload> Command(string command, object args = null, string evt = null)
        {

            var nonce = GenerateNonce();
            Payload payload = null;
            TaskCompletionSource<Payload> tcs = new TaskCompletionSource<Payload>();
            EventHandler<PipeFrame> handler = (sender, frame) =>
            {
                payload = JsonConvert.DeserializeObject<Payload>(frame.Message);
                if (payload.Nonce == nonce)
                {
                    _logger?.Info("\nCommand Response:\n{0}", JsonConvert.SerializeObject(payload));
                    tcs.SetResult(payload);
                }
            };

            _pipe.FrameRead += handler;

            _pipe.WriteFrame(new PipeFrame(Opcode.Frame, new
            {
                nonce,
                cmd = command,
                evt,
                args
            }));

            await tcs.Task;
            _pipe.FrameRead -= handler;
            return tcs.Task.Result;
        }

        protected void RouteEvent(object sender, Payload payload)
        {
            try
            {
                _logger?.Info("\nOnDispatch:\n{0}", JsonConvert.SerializeObject(payload));
                switch (payload.Evt)
                {
                    case "READY":
                        OnReady?.Invoke(this, payload);
                        break;
                    case "ERROR":
                        OnError?.Invoke(this, payload);
                        break;
                    case "GUILD_STATUS":
                        OnGuildStatus?.Invoke(this, payload);
                        break;
                    case "GUILD_CREATE":
                        OnGuildCreate?.Invoke(this, payload);
                        break;
                    case "CHANNEL_CREATE":
                        OnChannelCreate?.Invoke(this, payload);
                        break;
                    case "VOICE_CHANNEL_SELECT":
                        OnVoiceChannelSelect?.Invoke(this, payload.Data.ToObject<ChannelSelectResponse>());
                        break;
                    case "VOICE_STATE_CREATE":
                        OnVoiceStateCreate?.Invoke(this, payload.Data.ToObject<VoiceStateResponse>());
                        break;
                    case "VOICE_STATE_UPDATE":
                        OnVoiceStateUpdate?.Invoke(this, payload.Data.ToObject<VoiceStateResponse>());
                        break;
                    case "VOICE_STATE_DELETE":
                        OnVoiceStateDelete?.Invoke(this, payload.Data.ToObject<VoiceStateResponse>());
                        break;
                    case "VOICE_SETTINGS_UPDATE":
                        OnVoiceSettingsUpdate?.Invoke(this, payload.Data.ToObject<VoiceSettingsResponse>());
                        break;
                    case "VOICE_CONNECTION_STATUS":
                        OnVoiceConnectionStatus?.Invoke(this, payload);
                        break;
                    case "SPEAKING_START":
                        OnSpeakingStart?.Invoke(this, payload);
                        break;
                    case "SPEAKING_STOP":
                        OnSpeakingStop?.Invoke(this, payload);
                        break;
                    case "MESSAGE_CREATE":
                        OnMessageCreate?.Invoke(this, payload);
                        break;
                    case "MESSAGE_UPDATE":
                        OnMessageUpdate?.Invoke(this, payload);
                        break;
                    case "MESSAGE_DELETE":
                        OnMessageDelete?.Invoke(this, payload);
                        break;
                    case "NOTIFICATION_CREATE":
                        OnNotificationCreate?.Invoke(this, payload);
                        break;
                    case "ACTIVITY_JOIN":
                        OnActivityJoin?.Invoke(this, payload);
                        break;
                    case "ACTIVITY_SPECTATE":
                        OnActivitySpectate?.Invoke(this, payload);
                        break;
                    case "ACTIVITY_JOIN_REQUEST":
                        OnActivityJoinRequest?.Invoke(this, payload);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger?.Error(ex.Message);
            }
        }

    }
}
