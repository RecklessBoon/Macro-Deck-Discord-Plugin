using Newtonsoft.Json;
using SuchByte.MacroDeck.Plugins;
using System.Linq;

namespace RecklessBoon.MacroDeck.Discord
{

    public class Configuration
    {

        const string VAR_CLIENT_SECRET = "client_secret";

        [JsonIgnore]
        DiscordPlugin _plugin;

        [JsonIgnore]
        public string ClientSecret { get; set; }
        public string ClientId { get; set; }

        public Configuration(DiscordPlugin plugin)
        {
            if (plugin != null)
            {
                _plugin = plugin;
                Reload();
            }
        }

        public void Save()
        {
            SaveCredentials();
            SaveConfig();
            LoadConfig();
        }

        public void Reload()
        {
            LoadCredentials();
            LoadConfig();
        }

        protected void LoadCredentials()
        {
            var creds = PluginCredentials.GetPluginCredentials(_plugin);
            var data = creds.Count > 0 ? creds.First() : null;
            if (data != null && data.ContainsKey(VAR_CLIENT_SECRET))
            {
                ClientSecret = data[VAR_CLIENT_SECRET];
            }
        }

        protected void SaveCredentials()
        {
            CredentialsHelper.UpsertCredential(VAR_CLIENT_SECRET, ClientSecret);
        }

        protected void LoadConfig()
        {
            var json = PluginConfiguration.GetValue(_plugin, "config");
            if (json != null)
            {
                try
                {
                    var config = JsonConvert.DeserializeObject<Configuration>(json);
                    ClientId = config?.ClientId;
                }
                catch { }
            }
        }

        protected void SaveConfig()
        {
            var json = JsonConvert.SerializeObject(this);
            PluginConfiguration.SetValue(_plugin, "config", json);
        }

    }
}
