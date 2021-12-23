using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class MessageActivity
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("party_id")]
        public string PartyId { get; set; }
    }
}
