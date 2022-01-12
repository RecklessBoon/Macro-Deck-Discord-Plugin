using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class AuthorizeResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
    }
}
