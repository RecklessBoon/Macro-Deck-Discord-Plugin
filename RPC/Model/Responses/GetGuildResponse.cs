using Newtonsoft.Json;
using System;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class GetGuildResponse
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri IconUrl { get; set; }

        [JsonProperty("Members", NullValueHandling = NullValueHandling.Ignore)]
        public GuildMember[] GuildMembers { get; set; }
    }
}
