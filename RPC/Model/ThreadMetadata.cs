using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class ThreadMetadata
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("auto_archived_duration")]
        public int AutoArchivedDuration { get; set; }

        [JsonProperty("archive_timestamp")]
        public string ArchiveTimestamp { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("invitable")]
        public bool Inviteable { get; set; }
    }
}
