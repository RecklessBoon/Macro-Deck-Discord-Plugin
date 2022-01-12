using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class ThreadMetadata
    {
        [JsonProperty("archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool Archived { get; set; }

        [JsonProperty("auto_archived_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int AutoArchivedDuration { get; set; }

        [JsonProperty("archive_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchiveTimestamp { get; set; }

        [JsonProperty("locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool Locked { get; set; }

        [JsonProperty("invitable", NullValueHandling = NullValueHandling.Ignore)]
        public bool Inviteable { get; set; }
    }
}
