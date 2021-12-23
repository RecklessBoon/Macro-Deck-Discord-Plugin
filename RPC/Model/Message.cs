using Newtonsoft.Json;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class Message
    {
        [JsonProperty("id")]
        public ulong Id { get; set; }

        [JsonProperty("channel_id")]
        public ulong ChannelId { get; set; }

        [JsonProperty("guild_id")]
        public ulong GuildId { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("Member")]
        public GuildMember Member { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("timestamp")]
        public string Timestampe { get; set; }

        [JsonProperty("edited_timestamp")]
        public string EditedTimestamp { get; set; }

        [JsonProperty("tts")]
        public bool TextToSpeech { get; set; }

        [JsonProperty("mention_everyone")]
        public bool MentionEveryone { get; set; }

        [JsonProperty("mentions")]
        public Mention[] Mentions { get; set; }

        [JsonProperty("mention_roles")]
        public Role[] MentionRoles { get; set; }

        [JsonProperty("mentions_channels")]
        public ChannelMention[] ChannelMentions { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("embeds")]
        public Embed[] Embeds { get; set; }

        [JsonProperty("reactions")]
        public Reaction[] Reactions { get; set; }

        [JsonProperty("nonce")]
        public string Nonce { get; set; }

        [JsonProperty("pinned")]
        public bool Pinned { get; set; }

        [JsonProperty("webhook_id")]
        public ulong WebhookId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("activity")]
        public MessageActivity Activity { get; set; }

        [JsonProperty("application")]
        public Application Application { get; set; }

        [JsonProperty("appliation_id")]
        public ulong ApplicationId { get; set; }

        [JsonProperty("message_reference")]
        public Message MessageReference { get; set; }

        [JsonProperty("flags")]
        public int Flags { get; set; }

        [JsonProperty("referenced_message")]
        public Message ReferencedMessage { get; set; }

        [JsonProperty("interaction")]
        public MessageInteraction Interaction { get; set; }

        [JsonProperty("thread")]
        public Channel Thread { get; set; }
    }
}
