using SuchByte.MacroDeck.GUI.CustomControls;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RecklessBoon.MacroDeck.Discord
{
    partial class ConfigurationForm : DialogForm
    {

        protected static Configuration _config;

        public event EventHandler OnSecretChanged;
        public event EventHandler OnDebugLoggingChanged;

        class TokenChangedArgs : EventArgs
        {
            public string oldToken;
            public string newToken;
        }

        public ConfigurationForm(Configuration config)
        {
            _config = config ?? _config;
            InitializeComponent();

            clientId.Text = config.ClientId;
            clientSecret.Text = config.ClientSecret;
            cbxDebugLogging.Checked = config.Debug;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var oldSecret = _config.ClientSecret;
            var newSecret = clientSecret.Text;
            _config.ClientId = clientId.Text;
            _config.ClientSecret = newSecret;
            var oldDebugLogging = _config.Debug;
            _config.Debug = cbxDebugLogging.Checked;

            if (oldSecret != newSecret)
            {
                OnSecretChanged.Invoke(this, new TokenChangedArgs
                {
                    oldToken = oldSecret,
                    newToken = newSecret
                });
            }

            if (oldDebugLogging != _config.Debug)
            {
                OnDebugLoggingChanged?.Invoke(this, EventArgs.Empty);
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
