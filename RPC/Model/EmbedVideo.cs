﻿using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class EmbedVideo
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("proxy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyUrl { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int Width { get; set; }
    }
}
