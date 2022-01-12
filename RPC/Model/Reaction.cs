using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Reaction
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int Count { get; set; }

        [JsonProperty("me", NullValueHandling = NullValueHandling.Ignore)]
        public bool Me { get; set; }

        [JsonProperty("emoji", NullValueHandling = NullValueHandling.Ignore)]
        public Emoji Emoji { get; set; }
    }
}
