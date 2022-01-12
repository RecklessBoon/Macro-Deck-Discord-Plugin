using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class EmbedFooter
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("proxy_icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyIconUrl { get; set; }
    }
}
