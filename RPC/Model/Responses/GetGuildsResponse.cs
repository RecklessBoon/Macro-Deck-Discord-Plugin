using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class GetGuildsResponse
    {
        [JsonProperty("guilds", NullValueHandling = NullValueHandling.Ignore)]
        public Guild[] Guilds { get; set; }
    }
}
