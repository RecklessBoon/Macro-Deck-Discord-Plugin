using SuchByte.MacroDeck.GUI.CustomControls;
using System;

namespace RecklessBoon.MacroDeck.Discord
{
    partial class ConfigurationForm : DialogForm
    {

        protected static Configuration _config;

        public event EventHandler OnSecretChanged;
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
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var oldSecret = _config.ClientSecret;
            var newSecret = clientSecret.Text;
            _config.ClientId = clientId.Text;
            _config.ClientSecret = newSecret;

            if (oldSecret != newSecret)
            {
                OnSecretChanged.Invoke(this, new TokenChangedArgs
                {
                    oldToken = oldSecret,
                    newToken = newSecret
                });
            }

            _config.Save();
            this.Close();
        }

    }
}
