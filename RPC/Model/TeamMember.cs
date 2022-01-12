using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class TeamMember
    {
        [JsonProperty("membership_state", NullValueHandling = NullValueHandling.Ignore)]
        public int MembershipState { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Permissions { get; set; }

        [JsonProperty("team_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong TeamId { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }
    }
}
