using Discord;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class EmbeddedMediaFooterControl : UserControl
    {

        public EmbedFooter Footer
        {
            get
            {
                var builder = new EmbedFooterBuilder()
                {
                    Text = text.Text,
                    IconUrl = iconUrl.Text
                };
                return builder.Build();
            }
            set
            {
                text.Text = value.Text;
                iconUrl.Text = value.IconUrl;
            }
        }
        public EmbeddedMediaFooterControl()
        {
            InitializeComponent();
        }
    }
}
