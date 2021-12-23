using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class VoiceStateResponse
    {
        [JsonProperty("voice_state")]
        public VoiceState VoiceState { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("nick")]
        public string Nickname { get; set; }

        [JsonProperty("volume")]
        public int Volume { get; set; }

        [JsonProperty("mute")]
        public bool IsMute { get; set; }

        [JsonProperty("pan")]
        public Pan Pan { get; set; }

    }
}
