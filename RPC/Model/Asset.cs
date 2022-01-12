using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Asset
    {
        [JsonProperty("large_image", NullValueHandling = NullValueHandling.Ignore)]
        public string LargeImage { get; set; }

        [JsonProperty("large_text", NullValueHandling = NullValueHandling.Ignore)]
        public string LargeText { get; set; }

        [JsonProperty("small_image", NullValueHandling = NullValueHandling.Ignore)]
        public string SmallImage { get; set; }

        [JsonProperty("small_text", NullValueHandling = NullValueHandling.Ignore)]
        public string SmallText { get; set; }
    }
}
