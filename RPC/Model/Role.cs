using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Role
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public int Color { get; set; }

        [JsonProperty("hoist", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsPinned { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("unicode_emoji", NullValueHandling = NullValueHandling.Ignore)]
        public string UnicodeEmoji { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int Position { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public string Permissions { get; set; }

        [JsonProperty("managed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Managed { get; set; }

        [JsonProperty("mentionable", NullValueHandling = NullValueHandling.Ignore)]
        public bool Mentionable { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public RoleTag[] Tags { get; set; }
    }
}
