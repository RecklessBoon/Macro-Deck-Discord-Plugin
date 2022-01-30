using DiscordRPC.Logging;
using System;
using System.Diagnostics;

namespace RecklessBoon.MacroDeck.Discord
{
    public class DebugLogger : ILogger
    {
        public LogLevel Level { get; set; }

        public void Error(string message, params object[] args)
        {
            if (Level > LogLevel.Error) return;

            if (args.Length > 0) message = String.Format(message, args);
            Debug.WriteLine(String.Format("[ERROR]: {0}", message.ToString()));
        }

        public void Info(string message, params object[] args)
        {
            if (Level > LogLevel.Info) return;

            if (args.Length > 0) message = String.Format(message, args);
            Debug.WriteLine(String.Format("[INFO]: {0}", message.ToString()));
        }

        public void Trace(string message, params object[] args)
        {
            if (Level > LogLevel.Trace) return;

            if (args.Length > 0) message = String.Format(message, args);
            Debug.WriteLine(String.Format("[TRACE]: {0}", message.ToString()));
        }

        public void Warning(string message, params object[] args)
        {
            if (Level > LogLevel.Warning) return;

            if (args.Length > 0) message = String.Format(message, args);
            Debug.WriteLine(String.Format("[WARN]: {0}", message.ToString()));
        }
    }
}
