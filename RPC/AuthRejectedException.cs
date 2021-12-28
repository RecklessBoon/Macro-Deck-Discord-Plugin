using System;

namespace RecklessBoon.MacroDeck.Discord.RPC
{
    public class AuthRejectedException : Exception {

        public AuthRejectedException(string message) : base(message) { }
    
    }
}
