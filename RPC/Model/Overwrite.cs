using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Overwrite
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("allow", NullValueHandling = NullValueHandling.Ignore)]
        public string Allow { get; set; }

        [JsonProperty("deny", NullValueHandling = NullValueHandling.Ignore)]
        public string Deny { get; set; }
    }
}
