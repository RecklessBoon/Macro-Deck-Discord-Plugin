using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Mention
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("member")]
        public GuildMember Member { get; set; }
    }
}
