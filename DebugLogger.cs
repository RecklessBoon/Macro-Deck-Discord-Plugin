using DiscordRPC.Logging;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RecklessBoon.MacroDeck.Discord
{
    public class DebugLogger : ILogger
    {
        private AppLogger _logger;

        public DebugLogger(AppLogger logger)
        {
            _logger = logger;
        }

        private LogLevel _level = LogLevel.Trace;
        public LogLevel Level {
            get { return _level; }
            set { _level = value; }
        }

        public void Error(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            message = RedactSensitive(message);
            _logger.Error(message);
        }

        public void Info(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            message = RedactSensitive(message);
            _logger.Info(message);
        }

        public void Trace(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            message = RedactSensitive(message);
            _logger.Trace(message);
        }

        public void Warning(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            message = RedactSensitive(message);
            _logger.Warning(message);
        }

        private string RedactSensitive(string message)
        {
            // If we're debugging, I actually want to see this information
            if (Debugger.IsAttached) return message;

            var redaction = message;

            try
            {
                redaction = redaction.Replace(PluginInstance.Plugin.configuration.ClientSecret, "********");
            }
            catch (Exception)
            {
                // No need to break the app if the config isn't set yet somehow
                // Just being extra clinchy here
            }

            redaction = Regex.Replace(redaction, @"(.*{""access_token"":\s*"")(.*)(""\s*}.*)", "$1********$3");

            return redaction;
        }
    }
}
