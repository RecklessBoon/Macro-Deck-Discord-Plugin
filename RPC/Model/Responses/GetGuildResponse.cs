using Newtonsoft.Json;
using System;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class GetGuildResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon_url")]
        public Uri IconUrl { get; set; }

        [JsonProperty("Members")]
        public GuildMember[] GuildMembers { get; set; }
    }
}
