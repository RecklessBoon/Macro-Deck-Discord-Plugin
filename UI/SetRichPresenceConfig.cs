using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecklessBoon.MacroDeck.Discord.Actions;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using System;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class SetRichPresenceConfig : ActionConfigControl
    {
        public class RichPresenceConfig
        {
            public string State { get; set; }
            public string Details { get; set; }
            public int? DelayStart { get; set; }
            public int? Duration { get; set; }
            public string LargeImageKey { get; set; }
            public string LargeImageText { get; set; }
            public string SmallImageKey { get; set; }
            public string SmallImageText { get; set; }
        }

        private SetRichPresenceAction _macroDeckAction;

        public SetRichPresenceConfig(SetRichPresenceAction macroDeckAction, ActionConfigurator actionConfigurator)
        {
            this._macroDeckAction = macroDeckAction;
            InitializeComponent();

            this.Load += SetRichPresenceConfig_Load;

            this.LoadConfig();
        }

        private void SetRichPresenceConfig_Load(object sender, EventArgs e)
        {
            this.Width = Parent.ClientSize.Width;
            this.Height = Parent.ClientSize.Height;
            panel1.Width = this.ClientSize.Width;
        }

        public override bool OnActionSave()
        {
            if (String.IsNullOrWhiteSpace(details.Text))
            {
                return false;
            }
            try
            {
                RichPresenceConfig configuration = new RichPresenceConfig
                {
                    Details = details.Text,
                    State = state.Text,
                    DelayStart = int.TryParse(startDelay.Text, out int delayStart) ? (int?)delayStart : null,
                    Duration = int.TryParse(duration.Text, out var durationValue) ? (int?)durationValue : null,
                    LargeImageKey = largeImageKey.Text,
                    LargeImageText = largeImageText.Text,
                    SmallImageKey = smallImageKey.Text,
                    SmallImageText = smallImageText.Text
                };
                this._macroDeckAction.ConfigurationSummary = state.Text;
                this._macroDeckAction.Configuration = JsonConvert.SerializeObject(configuration);
            }
            catch { }
            return true;
        }

        public static RichPresenceConfig LoadRichPresenceConfig(string configuration)
        {
            return JsonConvert.DeserializeObject<RichPresenceConfig>(configuration);
        }

        private void LoadConfig()
        {
            if (!String.IsNullOrWhiteSpace(this._macroDeckAction.Configuration))
            {
                var config = LoadRichPresenceConfig(this._macroDeckAction.Configuration);
                details.Text = config.Details;
                state.Text = config.State;
                startDelay.Text = config.DelayStart.ToString();
                duration.Text = config.Duration.ToString();
                largeImageKey.Text = config.LargeImageKey;
                largeImageText.Text = config.LargeImageText;
                smallImageKey.Text = config.SmallImageKey;
                smallImageText.Text = config.SmallImageText;
            }
        }
    }
}
