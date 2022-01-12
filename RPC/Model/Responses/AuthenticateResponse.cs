using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class AuthenticateResponse
    {
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public User User { get; set; }

        [JsonProperty("scopes", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Scopes { get; set; }

        [JsonProperty("expires", NullValueHandling = NullValueHandling.Ignore)]
        public string Expires { get; set; }

        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public object Application { get; set; }
    }
}
