using Discord;
using System;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class EmbeddedMediaFieldControl : UserControl
    {
        const string DEFAULT_NAME = "Name";
        const string DEFAULT_VALUE = "Value";
        const bool DEFAULT_INLINE = false;

        public EmbedField BasicField
        {
            get
            {
                return (new EmbedFieldBuilder()
                {
                    Name = DEFAULT_NAME,
                    Value = DEFAULT_VALUE,
                    IsInline = DEFAULT_INLINE
                }).Build();
            }
        }

        public EmbedField Field
        {
            get
            {
                var builder = new EmbedFieldBuilder()
                {
                    Name = !String.IsNullOrWhiteSpace(name.Text) ? name.Text : DEFAULT_NAME,
                    Value = !String.IsNullOrWhiteSpace(value_field.Text) ? value_field.Text : DEFAULT_VALUE,
                    IsInline = inline.Checked,
                };
                return builder.Build();
            }
            set
            {
                name.Text = value.Name;
                value_field.Text = value.Value;
                inline.Checked = value.Inline;
            }
        }

        public EmbeddedMediaFieldControl()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
