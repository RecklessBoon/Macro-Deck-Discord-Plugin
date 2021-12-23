using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class AuthorizeResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
