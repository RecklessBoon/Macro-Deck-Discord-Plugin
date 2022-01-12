using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class RichPresence
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedAt { get; set; }

        [JsonProperty("timestamps", NullValueHandling = NullValueHandling.Ignore)]
        public Timestamp[] Timestamps { get; set; }

        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong? ApplicationID { get; set; }

        [JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
        public string Details { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("emoji", NullValueHandling = NullValueHandling.Ignore)]
        public Emoji Emoji { get; set; }

        [JsonProperty("party", NullValueHandling = NullValueHandling.Ignore)]
        public Party Party { get; set; }

        [JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
        public Asset[] Assets { get; set; }

        [JsonProperty("secrets", NullValueHandling = NullValueHandling.Ignore)]
        public Secret[] Secrets { get; set; }

        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public bool Instance { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public int? Flags { get; set; }

        [JsonProperty("buttons", NullValueHandling = NullValueHandling.Ignore)]
        public Button[] Buttons { get; set; }
    }
}
