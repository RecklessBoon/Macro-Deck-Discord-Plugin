using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class MessageComponent
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("style")]
        public int Style { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("emjoi")]
        public Emoji Emoji { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("options")]
        public SelectOption[] Options { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("min_values")]
        public int MinValues { get; set; }

        [JsonProperty("max_values")]
        public int MaxValues { get; set; }

        [JsonProperty("components")]
        public Component[] Components { get; set; }

        [JsonProperty("sticker_items")]
        public StickerItem[] StickerItems { get; set; }
    }
}
