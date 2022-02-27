using DiscordRPC.Logging;
using SuchByte.MacroDeck.Logging;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecklessBoon.MacroDeck.Discord
{
    public class MacroDeckLoggerProxy : ILogger
    {
        protected DiscordRPC.Logging.LogLevel logLevel = DiscordRPC.Logging.LogLevel.Warning;
        public DiscordRPC.Logging.LogLevel Level
        {
            get { return logLevel; }
            set { logLevel = value; }
        }

        public void Error(string message, params object[] args)
        {
            Task.Run(() =>
            {
                if (Level > DiscordRPC.Logging.LogLevel.Error) return;

                if (args.Length > 0) message = String.Format(message, args);
                message = ScrubSensitiveData(message);
                MacroDeckLogger.Error(PluginInstance.Plugin, message.ToString());
            });
        }

        public void Info(string message, params object[] args)
        {
            Task.Run(() =>
            {
                if (Level > DiscordRPC.Logging.LogLevel.Info) return;

                if (args.Length > 0) message = String.Format(message, args);
                message = ScrubSensitiveData(message);
                MacroDeckLogger.Info(PluginInstance.Plugin, message.ToString());
            });
        }

        public void Trace(string message, params object[] args)
        {
            Task.Run(() =>
            {
                if (Level > DiscordRPC.Logging.LogLevel.Trace) return;

                if (args.Length > 0) message = String.Format(message, args);
                message = ScrubSensitiveData(message);
                MacroDeckLogger.Trace(PluginInstance.Plugin, message.ToString());
            });
        }

        public void Warning(string message, params object[] args)
        {
            Task.Run(() =>
            {
                if (Level > DiscordRPC.Logging.LogLevel.Warning) return;

                if (args.Length > 0) message = String.Format(message, args);
                message = ScrubSensitiveData(message);
                MacroDeckLogger.Warning(PluginInstance.Plugin, message.ToString());
            });
        }

        protected string ScrubSensitiveData(string message)
        {
            var scrubbed_message = message;

            scrubbed_message = Regex.Replace(scrubbed_message, @"([""'](?>access_token|refresh_token)[""']\s*:\s*[""']?)(.*)([""'].*)", @"$1[=== REDACTED ===]$3", RegexOptions.Multiline);

            var clientSecret = PluginInstance.Plugin.configuration.ClientSecret;
            if (!String.IsNullOrWhiteSpace(clientSecret))
            {
                scrubbed_message = Regex.Replace(scrubbed_message, clientSecret, @"[=== REDACTED ===]", RegexOptions.Multiline);
            }

            return scrubbed_message;
        }
    }
}
