using Discord;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class EmbeddedMediaAuthorControl : UserControl
    {
        public EmbedAuthor Author
        {
            get
            {
                var builder = new EmbedAuthorBuilder()
                {
                    Name = name.Text,
                    Url = url.Text,
                    IconUrl = iconUrl.Text
                };
                return builder.Build();
            }
            set
            {
                name.Text = value.Name;
                url.Text = value.Url;
                iconUrl.Text = value.IconUrl;
            }
        }

        public EmbeddedMediaAuthorControl()
        {
            InitializeComponent();
        }
    }
}
