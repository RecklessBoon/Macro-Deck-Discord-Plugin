using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class NotificationCreateResponse
    {
        [JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelId { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public Message Message { get; set; }

        [JsonProperty("icon_url", NullValueHandling = NullValueHandling.Ignore)]
        public string IconUrl { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }
    }
}
