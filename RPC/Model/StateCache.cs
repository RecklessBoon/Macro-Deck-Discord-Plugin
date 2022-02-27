using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class StateCache
    {
        public User CurrentUser { get; set; }
        public ulong? CurrentGuildID { get; set; }
        public ulong? CurrentTextChannelID { get; set; }
        public ulong? CurrentVoiceChannelID { get; set; }
        public VoiceState VoiceState { get; set; }
        public List<NotificationCreateResponse> Notifications { get; set; }
    }
}
