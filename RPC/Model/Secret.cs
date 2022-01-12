using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Secret
    {
        [JsonProperty("join", NullValueHandling = NullValueHandling.Ignore)]
        public string Join { get; set; }

        [JsonProperty("spectate", NullValueHandling = NullValueHandling.Ignore)]
        public string Spectate { get; set; }

        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public string Match { get; set; }
    }
}
