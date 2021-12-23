using System;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    public class AuthToken
    {
        public string Token { get; set; }
        public string[] Scopes { get; set; }
        public DateTime Expires { get; set; }
        public string RefreshToken { get; set; }
        public string Type { get; set; }

    }
}
