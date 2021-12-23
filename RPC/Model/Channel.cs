using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Channel
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("permission_overwrites")]
        public Overwrite[] PermissionOverwrites { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("nsfw")]
        public bool Nsfw { get; set; }

        [JsonProperty("last_message_id")]
        public ulong LastMessageId { get; set; }

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("user_limit")]
        public int UserLimit { get; set; }

        [JsonProperty("rate_limit_per_user")]
        public int RateLimitPerUser { get; set; }

        [JsonProperty("recipients")]
        public User[] Recipients { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("owner_id")]
        public ulong OwnerId { get; set; }

        [JsonProperty("appliation_id")]
        public ulong ApplicationId { get; set; }

        [JsonProperty("parent_id")]
        public ulong ParentId { get; set; }

        [JsonProperty("last_pin_timestamp")]
        public string LastPinTimestamp { get; set; }

        [JsonProperty("rtc_region")]
        public string RtcRegion { get; set; }

        [JsonProperty("video_quality_mode")]
        public int VideoQualityMode { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("thread_metadata")]
        public ThreadMetadata ThreadMetadata { get; set; }

        [JsonProperty("member")]
        public ThreadMember Member { get; set; }

        [JsonProperty("defeault_auto_archive_duration")]
        public int DefaultAutoArchiveDuration { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }
    }
}
