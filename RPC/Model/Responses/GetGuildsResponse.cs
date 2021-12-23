using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class GetGuildsResponse
    {
        [JsonProperty("guilds")]
        public Guild[] Guilds { get; set; }
    }
}
