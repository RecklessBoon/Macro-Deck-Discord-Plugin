using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class ThreadMember
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("join_timestamp")]
        public string JoinTimestamp { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }
    }
}
