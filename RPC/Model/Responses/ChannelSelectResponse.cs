using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class ChannelSelectResponse
    {
        [JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GuildId { get; set; }

    }
}
