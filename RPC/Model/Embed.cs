﻿using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Embed
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("footer")]
        public EmbedFooter Footer { get; set; }

        [JsonProperty("image")]
        public EmbedImage Image { get; set; }

        [JsonProperty("thumbnail")]
        public EmbedThumbnail Thumbnail { get; set; }

        [JsonProperty("video")]
        public EmbedVideo Video { get; set; }

        [JsonProperty("provider")]
        public EmbedProvider Provider { get; set; }

        [JsonProperty("author")]
        public EmbedAuthor Author { get; set; }

        [JsonProperty("fields")]
        public EmbedField[] Fields { get; set; }
    }
}
