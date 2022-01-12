using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class GuildMember
    {
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("nick", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        [JsonProperty("avatar", NullValueHandling = NullValueHandling.Ignore)]
        public string Avatar { get; set; }

        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Roles { get; set; }

        [JsonProperty("joined_at", NullValueHandling = NullValueHandling.Ignore)]
        public string JoinedAt { get; set; }

        [JsonProperty("premium_since", NullValueHandling = NullValueHandling.Ignore)]
        public string PremiumSince { get; set; }

        [JsonProperty("deaf", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDeaf { get; set; }

        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsMute { get; set; }

        [JsonProperty("pending", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsPending { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Permissions { get; set; }
    }
}
