using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Application
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("rpc_origins", NullValueHandling = NullValueHandling.Ignore)]
        public string[] RpcOrigins { get; set; }

        [JsonProperty("bot_public", NullValueHandling = NullValueHandling.Ignore)]
        public bool BotPublic { get; set; }

        [JsonProperty("bot_require_code_grant", NullValueHandling = NullValueHandling.Ignore)]
        public bool BotRequireCodeGrant { get; set; }

        [JsonProperty("terms_of_service_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TermsOfServiceUrl { get; set; }

        [JsonProperty("privacy_policy_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivacyPolicyUrl { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public User Owner { get; set; }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; set; }

        [JsonProperty("verify_key", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyKey { get; set; }

        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public Team Team { get; set; }

        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong GuildId { get; set; }

        [JsonProperty("primary_sku_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong PrimarySkuId { get; set; }

        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        [JsonProperty("cover_image", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverImage { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public int Flags { get; set; }
    }
}
