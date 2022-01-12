using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Embed
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public int Color { get; set; }

        [JsonProperty("footer", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedFooter Footer { get; set; }

        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedImage Image { get; set; }

        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedThumbnail Thumbnail { get; set; }

        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedVideo Video { get; set; }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedProvider Provider { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedAuthor Author { get; set; }

        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public EmbedField[] Fields { get; set; }
    }
}
