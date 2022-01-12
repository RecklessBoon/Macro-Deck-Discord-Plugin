using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Party
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int[] Size { get; set; }
    }
}
