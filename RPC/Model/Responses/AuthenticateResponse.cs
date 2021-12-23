using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class AuthenticateResponse
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("scopes")]
        public string[] Scopes { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("application")]
        public object Application { get; set; }
    }
}
