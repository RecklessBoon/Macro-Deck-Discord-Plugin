using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Emoji
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public Role[] Roles { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("require_colons", NullValueHandling = NullValueHandling.Ignore)]
        public bool RequireColons { get; set; }

        [JsonProperty("managed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Managed { get; set; }

        [JsonProperty("animated", NullValueHandling = NullValueHandling.Ignore)]
        public bool Animated { get; set; }

        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public bool Available { get; set; }
    }
}
