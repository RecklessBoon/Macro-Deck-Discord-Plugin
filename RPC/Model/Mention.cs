using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Mention
    {
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public GuildMember Member { get; set; }
    }
}
