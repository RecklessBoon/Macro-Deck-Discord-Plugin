using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class VoiceSettingsResponse
    {
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public object Input { get; set; }

        [JsonProperty("output", NullValueHandling = NullValueHandling.Ignore)]
        public object Output { get; set; }

        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public object Mode { get; set; }

        [JsonProperty("automatic_gain_control", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsAutomaticGainControlEnabled { get; set; }

        [JsonProperty("echo_cancellation", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsEchoCancellationEnabled { get; set; }

        [JsonProperty("noise_suppression", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsNoiseSuppressionEnabled { get; set; }

        [JsonProperty("qos", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsQOSEnabled { get; set; }

        [JsonProperty("silence_warning", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsSilenceWarningShown { get; set; }

        [JsonProperty("deaf", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsDeaf { get; set; }

        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsMute { get; set; }
    }
}
