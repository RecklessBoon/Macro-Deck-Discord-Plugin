using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Pan
    {
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public double Left { get; set; }

        [JsonProperty("right", NullValueHandling = NullValueHandling.Ignore)]
        public double Right { get; set; }

    }
}
