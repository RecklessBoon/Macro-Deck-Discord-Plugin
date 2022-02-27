using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model.Responses
{
    public class ErrorResponse
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
    }
}
