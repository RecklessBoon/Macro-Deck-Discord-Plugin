using RecklessBoon.MacroDeck.Discord.Actions;
using RecklessBoon.MacroDeck.Discord.RPC;
using RecklessBoon.MacroDeck.Discord.RPC.Model;
using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord
{

    public static class PluginInstance
    {
        public static AppLogger Logger;
        public static DiscordPlugin Plugin;
        public static StateCache cache = new StateCache()
        {
            VoiceState = new VoiceState()
        };
    }

    public class DiscordPlugin : MacroDeckPlugin
    {
        public Configuration configuration;

        // Optional; If your plugin can be configured, set to "true". It'll make the "Configure" button appear in the package manager.
        public override bool CanConfigure => true;

        protected RPCClient _RPCClient;
        public RPCClient RPCClient { get { return _RPCClient; } }

        private ContentSelectorButton statusButton = new ContentSelectorButton();
        private ToolTip statusToolTip = new ToolTip();

        private MainWindow mainWindow;

        private Task connectingStatusLoop;
        private CancellationTokenSource connectingStatusLoopCTS;

        public class VariableState
        {
            public string Name { get; set; }
            protected VariableType _type = VariableType.Bool;
            public VariableType Type { get { return _type; } set { _type = value; } }
            protected object _value = false;
            public object Value { get { return _value; } set { _value = value; } }
            protected bool _save = true;
            public bool Save { get { return _save; } set { _save = value; } }

        }

        public void SetVariable(VariableState variableState)
        {
            VariableManager.SetValue(string.Format("discord_{0}", variableState.Name), variableState.Value, variableState.Type, this);
        }

        public string GetVariable(string key)
        {
            var name = String.Format("discord_{0}", key);
            return VariableManager.Variables.FirstOrDefault(x => x.Name == name)?.Value;
        }

        public void SetVariable(VariableState[] variableStates)
        {
            foreach (VariableState state in variableStates)
            {
                SetVariable(state);
            }
        }

        public void UpdateVoiceStateVariables(VoiceState voiceState)
        {
            if (voiceState == null)
                voiceState = new VoiceState();

            PluginInstance.cache.VoiceState = voiceState;
            SetVariable(new[] {
                new VariableState { Name = "is_self_muted", Value = voiceState.SelfMute },
                new VariableState { Name = "is_self_deafened", Value = voiceState.SelfDeaf },
                new VariableState { Name = "is_server_muted", Value = voiceState.Mute },
                new VariableState { Name = "is_server_deafened", Value = voiceState.Deaf },
                new VariableState { Name = "is_any_muted", Value = voiceState.Mute || voiceState.SelfMute },
                new VariableState { Name = "is_any_deafened", Value = voiceState.Deaf || voiceState.SelfDeaf },
            });
        }

        public DiscordPlugin()
        {
            PluginInstance.Plugin ??= this;
            PluginInstance.Logger ??= new AppLogger();
            SuchByte.MacroDeck.MacroDeck.OnMainWindowLoad += MacroDeck_OnMainWindowLoad;
        }

        // Gets called when the plugin is loaded
        public override void Enable()
        {
            try
            {
                configuration ??= new Configuration(PluginInstance.Plugin);
                ResetVariables();
                InitClient();

                Actions = new List<PluginAction>
                {
                    // add the instances of your actions here
                    new ExecuteWebhookAction(),
                    new SetMuteOnAction(),
                    new SetMuteOffAction(),
                    new ToggleMuteAction(),
                    new SetDeafenOnAction(),
                    new SetDeafenOffAction(),
                    new ToggleDeafenAction(),
                    new SetRichPresenceAction(),
                    new ClearRichPresenceAction(),
                };
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        private void MacroDeck_OnMainWindowLoad(object sender, EventArgs e)
        {
            try
            {
                mainWindow = sender as MainWindow;
                statusButton = new ContentSelectorButton();
                statusButton.BackgroundImageLayout = ImageLayout.Zoom;
                UpdateStatusButton(RPCClient != null && RPCClient.IsConnected);
                statusButton.Click += StatusButton_Click;
                mainWindow.contentButtonPanel.Controls.Add(statusButton);
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (configuration == null || !configuration.IsFullySet)
                {
                    OpenConfigurator();
                }
                else
                {
                    Task.Run(() =>
                    {
                        if (RPCClient != null && !RPCClient.IsDisposed)
                        {
                            RPCClient.Dispose();
                        }
                        else if (RPCClient == null || RPCClient.IsDisposed || !RPCClient.IsConnected)
                        {
                            InitClient();
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        private async Task StartStatusLoop()
        {
            try
            {
                if (connectingStatusLoop == null || connectingStatusLoop.Status != TaskStatus.Running)
                {
                    connectingStatusLoopCTS = new CancellationTokenSource();
                    CancellationToken ct = connectingStatusLoopCTS.Token;

                    connectingStatusLoop = Task.Run(() =>
                    {
                        do
                        {
                            if (connectingStatusLoopCTS.IsCancellationRequested) return;
                            UpdateStatusButton(true);
                            Thread.Sleep(750);

                            if (connectingStatusLoopCTS.IsCancellationRequested) return;
                            UpdateStatusButton(false);
                            Thread.Sleep(750);
                        } while ((RPCClient == null || !RPCClient.IsConnected) && !connectingStatusLoopCTS.IsCancellationRequested);
                    }, ct);

                    await connectingStatusLoop;
                    UpdateStatusButton(RPCClient != null && RPCClient.IsConnected);
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        /**
         * Pad a bitmap with default padding
         */
        private Bitmap PadBitmap(Bitmap bm)
        {
            return PadBitmap(bm, 1.3f, 1.3f);
        }

        /**
         * Pad a bitmap with equal percentage on x and y axis
         */
        private Bitmap PadBitmap(Bitmap bm, float padding)
        {
            return PadBitmap(bm, padding, padding);
        }

        /**
         * Pad a bitmap with explicit percentage on x and y axis
         */
        private Bitmap PadBitmap(Bitmap bm, float xPadding, float yPadding)
        {
            Bitmap paddedBm = new Bitmap((int)(bm.Width * xPadding), (int)(bm.Height * yPadding));
            using (Graphics graphics = Graphics.FromImage(paddedBm))
            {
                graphics.Clear(Color.Transparent);
                int x = (paddedBm.Width - bm.Width) / 2;
                int y = (paddedBm.Height - bm.Height) / 2;
                graphics.DrawImage(bm, x, y, bm.Width, bm.Height);
            }
            return paddedBm;
        }

        private void UpdateStatusButton(bool connected)
        {
            try
            {
                if (mainWindow != null && mainWindow.IsHandleCreated)
                {
                    mainWindow.BeginInvoke(new Action(() =>
                    {
                        Bitmap bm = connected ? Properties.Resources.Discord_Logo_Color_64x49 : Properties.Resources.Discord_Logo_White_64x49;
                        statusButton.BackgroundImage = PadBitmap(bm, 1.35f);
                        statusToolTip.SetToolTip(statusButton, "Discord " + (connected ? " Connected" : "Disconnected"));
                    }));
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        protected void InitClient()
        {
            try
            {
                if ((RPCClient == null || RPCClient.IsDisposed) && !String.IsNullOrEmpty(PluginInstance.Plugin.configuration.ClientId))
                {
                    _RPCClient = new RPCClient(PluginInstance.Plugin.configuration.ClientId);
                    ConnectClients();
                    RPCClient.Start();
                }
            }
            catch (Exception ex)
            {
                if (RPCClient != null && !RPCClient.IsDisposed) RPCClient.Dispose();
                PluginInstance.Logger.Error("Unexpected Exception ocurred while initializing the RPC client:\n{0}", ex);
            }
        }

        protected void ConnectClients()
        {
            RPCClient.OnConnectBegin += Client_OnConnectBegin;
            RPCClient.OnConnectEnd += Client_OnConnectEnd;
            RPCClient.OnConnectFailed += Client_OnConnectFailed;
            RPCClient.OnConnectStateChanged += Client_OnConnectStateChanged;
            RPCClient.OnVoiceStateUpdate += Client_OnVoiceStateUpdate;
            RPCClient.OnVoiceSettingsUpdate += Client_OnVoiceSettingsUpdate;
        }

        private void CancelConnectingStatusLoop()
        {
            if (connectingStatusLoopCTS != null)
            {
                connectingStatusLoopCTS.Cancel();
            }
        }

        private void Client_OnConnectBegin(object sender, EventArgs e)
        {
            _ = StartStatusLoop();
        }

        private void Client_OnConnectStateChanged(object sender, bool connected)
        {
            UpdateStatusButton(connected);
        }
        private void Client_OnConnectFailed(object sender, EventArgs e)
        {
            if (RPCClient != null && !RPCClient.IsConnected && RPCClient.ConnectStarted)
            {
                _ = StartStatusLoop();
            }
        }

        private void Client_OnConnectEnd(object sender, EventArgs e)
        {
            try
            {
                if (RPCClient != null && !RPCClient.IsConnected)
                {
                    _RPCClient = null;
                }
                CancelConnectingStatusLoop();
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        protected void ResetVariables()
        {
            SetVariable(new[] {
                new VariableState { Name = "is_self_muted" },
                new VariableState { Name = "is_self_deafened" },
                new VariableState { Name = "is_server_muted" },
                new VariableState { Name = "is_server_deafened" },
                new VariableState { Name = "is_any_muted" },
                new VariableState { Name = "is_any_deafened" }
            });
        }

        private void Client_OnVoiceSettingsUpdate(object sender, VoiceSettingsResponse payload)
        {
            try
            {
                if (PluginInstance.cache.CurrentVoiceChannelID == null)
                {
                    var currentVoiceState = PluginInstance.cache.VoiceState;
                    currentVoiceState.SelfMute = payload.IsMute || payload.IsDeaf;
                    currentVoiceState.SelfDeaf = payload.IsDeaf;
                    UpdateVoiceStateVariables(currentVoiceState);
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        protected void Client_OnVoiceStateUpdate(object sender, VoiceStateResponse payload)
        {
            try
            {
                UpdateVoiceStateVariables(payload.VoiceState);
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
        }

        // Optional; Gets called when the user clicks on the "Configure" button in the package manager; If CanConfigure is not set to true, you don't need to add this
        public override void OpenConfigurator()
        {
            // Open your configuration form here
            using var configurator = new ConfigurationForm(configuration);
            configurator.OnSecretChanged += (object form, EventArgs e) =>
            {
                try
                {
                    if (RPCClient != null) RPCClient.Dispose();
                    InitClient();
                }
                catch (Exception ex)
                {
                    PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
                }
            };
            configurator.OnDebugLoggingChanged += (object form, EventArgs e) =>
            {
                try
                {
                    if (RPCClient != null)
                    {
                        RPCClient.SyncClientLogger();
                    }
                }
                catch (Exception ex)
                {
                    PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
                }
            };
            configurator.ShowDialog();
        }
    }
}