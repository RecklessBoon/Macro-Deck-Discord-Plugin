using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Team
    {
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("members", NullValueHandling = NullValueHandling.Ignore)]
        public TeamMember[] Members { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("owner_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong OwnerUserId { get; set; }
    }
}
