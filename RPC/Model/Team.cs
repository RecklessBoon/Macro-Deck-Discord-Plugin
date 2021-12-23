using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Team
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("members")]
        public TeamMember[] Members { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner_user_id")]
        public ulong OwnerUserId { get; set; }
    }
}
