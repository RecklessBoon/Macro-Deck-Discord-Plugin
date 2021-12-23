using Newtonsoft.Json;
using SuchByte.MacroDeck.Plugins;
using System.Collections.Generic;
using System.Linq;

namespace RecklessBoon.MacroDeck.Discord
{
    static class CredentialsHelper
    {
        public static void UpsertCredential(string key, string value)
        {
            var oldCreds = PluginCredentials.GetPluginCredentials(PluginInstance.Plugin);
            var creds = new Dictionary<string, string>();
            if (oldCreds.Count == 1)
            {
                creds = oldCreds.First();
            }

            creds[key] = value;
            PluginCredentials.SetCredentials(PluginInstance.Plugin, creds);
        }

        public static void UpsertCredential(string key, object value)
        {
            UpsertCredential(key, JsonConvert.SerializeObject(value));
        }

        public static void RemoveCredential(string key)
        {
            var oldCreds = PluginCredentials.GetPluginCredentials(PluginInstance.Plugin);
            if (oldCreds.Count == 1)
            {
                var creds = oldCreds.First();
                creds.Remove(key);
                PluginCredentials.SetCredentials(PluginInstance.Plugin, creds);
            }
        }
    }
}
