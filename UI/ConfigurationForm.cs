using DiscordRPC.Logging;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.Discord
{
    partial class ConfigurationForm : DialogForm
    {

        internal class Option
        {
            public object Value { get; set; }
            public string Label { get; set; }

            public override string ToString()
            {
                return Label;
            }
        }

        public static readonly List<Option> LogLevelOptions = new List<Option>()
        {
            new Option { Value = DiscordRPC.Logging.LogLevel.None, Label = "None" },
            new Option { Value = DiscordRPC.Logging.LogLevel.Error, Label = "Error" },
            new Option { Value = DiscordRPC.Logging.LogLevel.Warning, Label = "Warning" },
            new Option { Value = DiscordRPC.Logging.LogLevel.Info, Label = "Info" },
            new Option { Value = DiscordRPC.Logging.LogLevel.Trace, Label = "Debug" },
        };

protected static Configuration _config;

        public event EventHandler OnSecretChanged;
        public class TokenChangedArgs : EventArgs
        {
            public string oldToken;
            public string newToken;
        }

        public event EventHandler OnLogLevelChanged;
        public class LogLevelChangedArgs : EventArgs
        {
            public LogLevel? oldLogLevel;
            public LogLevel? newLogLevel;
        }

        public ConfigurationForm(Configuration config)
        {
            _config = config ?? _config;
            InitializeComponent();

            clientId.Text = config.ClientId;
            clientSecret.Text = config.ClientSecret;

            logLevel.Items.AddRange(LogLevelOptions.ToArray<Option>());
            logLevel.SelectedItem = LogLevelOptions.Find(item => item.Value.Equals(config.LogLevel));
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var oldSecret = _config.ClientSecret;
            var newSecret = clientSecret.Text;
            _config.ClientId = clientId.Text;
            _config.ClientSecret = newSecret;

            if (oldSecret != newSecret)
            {
                OnSecretChanged?.Invoke(this, new TokenChangedArgs
                {
                    oldToken = oldSecret,
                    newToken = newSecret
                });
            }

            var oldLogLevel = _config.LogLevel;
            var newLogLevel = (LogLevel)(logLevel.SelectedItem as Option)?.Value;
            _config.LogLevel = newLogLevel;

            if (!oldLogLevel.Equals(newLogLevel))
            {
                OnLogLevelChanged?.Invoke(this, new LogLevelChangedArgs { oldLogLevel = oldLogLevel, newLogLevel = newLogLevel });
            }

            _config.Save();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://github.com/RecklessBoon/Macro-Deck-Discord-Plugin#configuration");
        }

        // Yoinked from: https://stackoverflow.com/a/43232486
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

    }
}
