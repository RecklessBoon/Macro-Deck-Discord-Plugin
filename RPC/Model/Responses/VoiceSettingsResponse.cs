using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class VoiceSettingsResponse
    {
        [JsonProperty("input")]
        public object Input { get; set; }

        [JsonProperty("output")]
        public object Output { get; set; }

        [JsonProperty("mode")]
        public object Mode { get; set; }

        [JsonProperty("automatic_gain_control")]
        public bool IsAutomaticGainControlEnabled { get; set; }

        [JsonProperty("echo_cancellation")]
        public bool IsEchoCancellationEnabled { get; set; }

        [JsonProperty("noise_suppression")]
        public bool IsNoiseSuppressionEnabled { get; set; }

        [JsonProperty("qos")]
        public bool IsQOSEnabled { get; set; }

        [JsonProperty("silence_warning")]
        public bool IsSilenceWarningShown { get; set; }

        [JsonProperty("deaf")]
        public bool IsDeaf { get; set; }

        [JsonProperty("mute")]
        public bool IsMute { get; set; }
    }
}
