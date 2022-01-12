using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class ThreadMember
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong UserId { get; set; }

        [JsonProperty("join_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinTimestamp { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public int Flags { get; set; }
    }
}
