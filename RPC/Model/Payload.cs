using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Payload
    {
        [JsonProperty("cmd")]
        public string Cmd { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("evt")]
        public string Evt { get; set; }

        [JsonProperty("data")]
        public JObject Data { get; set; }

        [JsonProperty("args")]
        public JObject Args { get; set; }
    }
}
