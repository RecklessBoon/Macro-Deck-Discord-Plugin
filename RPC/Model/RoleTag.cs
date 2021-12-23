using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class RoleTag
    {
        [JsonProperty("bot_id")]
        public ulong BotId { get; set; }

        [JsonProperty("integration_id")]
        public ulong IntegrationId { get; set; }

        [JsonProperty("premium_subscriber")]
        public bool PremiumSubscriber { get; set; }
    }
}
