using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Payload
    {
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        [JsonProperty("nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string Nonce { get; set; }

        [JsonProperty("evt", NullValueHandling = NullValueHandling.Ignore)]
        public string Evt { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Data { get; set; }

        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public JObject Args { get; set; }
    }
}
