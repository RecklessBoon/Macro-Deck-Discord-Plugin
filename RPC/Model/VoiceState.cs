using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class VoiceState
    {
        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool Mute { get; set; }

        [JsonProperty("deaf", NullValueHandling = NullValueHandling.Ignore)]
        public bool Deaf { get; set; }

        [JsonProperty("self_mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool SelfMute { get; set; }

        [JsonProperty("self_deaf", NullValueHandling = NullValueHandling.Ignore)]
        public bool SelfDeaf { get; set; }

        [JsonProperty("suppress", NullValueHandling = NullValueHandling.Ignore)]
        public bool Suppress { get; set; }
    }
}
