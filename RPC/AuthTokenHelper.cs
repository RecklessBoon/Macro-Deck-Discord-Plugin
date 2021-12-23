using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using System;

namespace RecklessBoon.MacroDeck.Discord.RPC.Model
{
    static class AuthTokenHelper
    {
        public static AuthToken CreateFrom(string[] scopesRequired, TokenResponse tokenResponse)
        {
            return new AuthToken()
            {
                Token = tokenResponse.AccessToken,
                Scopes = scopesRequired,
                Expires = DateTime.Now.AddSeconds(tokenResponse.ExpiresIn),
                RefreshToken = tokenResponse.RefreshToken,
                Type = tokenResponse.TokenType
            };
        }
    }
}
