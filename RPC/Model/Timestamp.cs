using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Timestamp
    {
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int Start { get; set; }

        [JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
        public int End { get; set; }
    }
}
