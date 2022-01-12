using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class MessageComponent
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("custom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomId { get; set; }

        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool Disabled { get; set; }

        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public int Style { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("emjoi", NullValueHandling = NullValueHandling.Ignore)]
        public Emoji Emoji { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public SelectOption[] Options { get; set; }

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        [JsonProperty("min_values", NullValueHandling = NullValueHandling.Ignore)]
        public int MinValues { get; set; }

        [JsonProperty("max_values", NullValueHandling = NullValueHandling.Ignore)]
        public int MaxValues { get; set; }

        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public Component[] Components { get; set; }

        [JsonProperty("sticker_items", NullValueHandling = NullValueHandling.Ignore)]
        public StickerItem[] StickerItems { get; set; }
    }
}
