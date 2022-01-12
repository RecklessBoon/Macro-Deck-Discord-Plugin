using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class VoiceStateResponse
    {
        [JsonProperty("voice_state", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceState VoiceState { get; set; }

        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("nick", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int Volume { get; set; }

        [JsonProperty("mute", NullValueHandling = NullValueHandling.Ignore)]
        public bool IsMute { get; set; }

        [JsonProperty("pan", NullValueHandling = NullValueHandling.Ignore)]
        public Pan Pan { get; set; }

    }
}
