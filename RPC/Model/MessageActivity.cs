using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class MessageActivity
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("party_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartyId { get; set; }
    }
}
