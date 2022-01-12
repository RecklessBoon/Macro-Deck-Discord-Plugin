using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Message
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong Id { get; set; }

        [JsonProperty("channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong GuildId { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public User Author { get; set; }

        [JsonProperty("Member", NullValueHandling = NullValueHandling.Ignore)]
        public GuildMember Member { get; set; }

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestampe { get; set; }

        [JsonProperty("edited_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string EditedTimestamp { get; set; }

        [JsonProperty("tts", NullValueHandling = NullValueHandling.Ignore)]
        public bool TextToSpeech { get; set; }

        [JsonProperty("mention_everyone", NullValueHandling = NullValueHandling.Ignore)]
        public bool MentionEveryone { get; set; }

        [JsonProperty("mentions", NullValueHandling = NullValueHandling.Ignore)]
        public Mention[] Mentions { get; set; }

        [JsonProperty("mention_roles", NullValueHandling = NullValueHandling.Ignore)]
        public Role[] MentionRoles { get; set; }

        [JsonProperty("mentions_channels", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelMention[] ChannelMentions { get; set; }

        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("embeds", NullValueHandling = NullValueHandling.Ignore)]
        public Embed[] Embeds { get; set; }

        [JsonProperty("reactions", NullValueHandling = NullValueHandling.Ignore)]
        public Reaction[] Reactions { get; set; }

        [JsonProperty("nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string Nonce { get; set; }

        [JsonProperty("pinned", NullValueHandling = NullValueHandling.Ignore)]
        public bool Pinned { get; set; }

        [JsonProperty("webhook_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong WebhookId { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int Type { get; set; }

        [JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
        public MessageActivity Activity { get; set; }

        [JsonProperty("application", NullValueHandling = NullValueHandling.Ignore)]
        public Application Application { get; set; }

        [JsonProperty("appliation_id", NullValueHandling = NullValueHandling.Ignore)]
        public ulong ApplicationId { get; set; }

        [JsonProperty("message_reference", NullValueHandling = NullValueHandling.Ignore)]
        public Message MessageReference { get; set; }

        [JsonProperty("flags", NullValueHandling = NullValueHandling.Ignore)]
        public int Flags { get; set; }

        [JsonProperty("referenced_message", NullValueHandling = NullValueHandling.Ignore)]
        public Message ReferencedMessage { get; set; }

        [JsonProperty("interaction", NullValueHandling = NullValueHandling.Ignore)]
        public MessageInteraction Interaction { get; set; }

        [JsonProperty("thread", NullValueHandling = NullValueHandling.Ignore)]
        public Channel Thread { get; set; }
    }
}
