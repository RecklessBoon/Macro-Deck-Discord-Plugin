using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Channel
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong GuildId { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int Position { get; set; }

        [JsonProperty("permission_overwrites", NullValueHandling = NullValueHandling.Ignore)]
        public Overwrite[] PermissionOverwrites { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        [JsonProperty("nsfw", NullValueHandling = NullValueHandling.Ignore)]
        public bool Nsfw { get; set; }

        [JsonProperty("last_message_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong LastMessageId { get; set; }

        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int Bitrate { get; set; }

        [JsonProperty("user_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int UserLimit { get; set; }

        [JsonProperty("rate_limit_per_user", NullValueHandling = NullValueHandling.Ignore)]
        public int RateLimitPerUser { get; set; }

        [JsonProperty("recipients", NullValueHandling = NullValueHandling.Ignore)]
        public User[] Recipients { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong OwnerId { get; set; }

        [JsonProperty("appliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ApplicationId { get; set; }

        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ParentId { get; set; }

        [JsonProperty("last_pin_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string LastPinTimestamp { get; set; }

        [JsonProperty("rtc_region", NullValueHandling = NullValueHandling.Ignore)]
        public string RtcRegion { get; set; }

        [JsonProperty("video_quality_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int VideoQualityMode { get; set; }

        [JsonProperty("message_count", NullValueHandling = NullValueHandling.Ignore)]
        public int MessageCount { get; set; }

        [JsonProperty("member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int MemberCount { get; set; }

        [JsonProperty("thread_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public ThreadMetadata ThreadMetadata { get; set; }

        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public ThreadMember Member { get; set; }

        [JsonProperty("defeault_auto_archive_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int DefaultAutoArchiveDuration { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public string Permissions { get; set; }
    }
}
