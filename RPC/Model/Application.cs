using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Application
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rpc_origins")]
        public string[] RpcOrigins { get; set; }

        [JsonProperty("bot_public")]
        public bool BotPublic { get; set; }

        [JsonProperty("bot_require_code_grant")]
        public bool BotRequireCodeGrant { get; set; }

        [JsonProperty("terms_of_service_url")]
        public string TermsOfServiceUrl { get; set; }

        [JsonProperty("privacy_policy_url")]
        public string PrivacyPolicyUrl { get; set; }

        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("verify_key")]
        public string VerifyKey { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("primary_sku_id")]
        public ulong PrimarySkuId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("cover_image")]
        public string CoverImage { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }
    }
}
