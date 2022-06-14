using DiscordRPC.Logging;
using SuchByte.MacroDeck.Logging;
using System;
using System.Collections.Generic;
using LogLevel = DiscordRPC.Logging.LogLevel;

namespace RecklessBoon.MacroDeck.Discord
{
    public class AppLogger
    {

        public void Error(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            MacroDeckLogger.Error(PluginInstance.Plugin, String.Format("[ERROR]: {0}", message.ToString()));
        }

        public void Info(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            MacroDeckLogger.Info(PluginInstance.Plugin, String.Format("[INFO]: {0}", message.ToString()));
        }

        public void Trace(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            MacroDeckLogger.Trace(PluginInstance.Plugin, String.Format("[TRACE]: {0}", message.ToString()));
        }

        public void Warning(string message, params object[] args)
        {
            if (args.Length > 0) message = String.Format(message, args);
            MacroDeckLogger.Warning(PluginInstance.Plugin, String.Format("[WARN]: {0}", message.ToString()));
        }
    }
}
