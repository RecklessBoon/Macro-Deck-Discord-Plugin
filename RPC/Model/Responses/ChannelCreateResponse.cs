using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class ChannelCreateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

    }
}
