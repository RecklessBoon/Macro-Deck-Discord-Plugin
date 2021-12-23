using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Pan
    {
        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("right")]
        public double Right { get; set; }

    }
}
