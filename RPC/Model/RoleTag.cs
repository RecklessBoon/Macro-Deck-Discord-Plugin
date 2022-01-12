using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class RoleTag
    {
        [JsonProperty("bot_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong BotId { get; set; }

        [JsonProperty("integration_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong IntegrationId { get; set; }

        [JsonProperty("premium_subscriber", NullValueHandling = NullValueHandling.Ignore)]
        public bool PremiumSubscriber { get; set; }
    }
}
