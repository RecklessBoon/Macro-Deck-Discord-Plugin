using Discord;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class EmbeddedMediaControl : UserControl
    {

        public Embed Embed
        {
            get
            {
                var builder = new EmbedBuilder();
                if (!author.Author.Equals(default(EmbedAuthor)))
                {
                    builder.Author = new EmbedAuthorBuilder()
                    {
                        Name = author.Author.Name,
                        Url = author.Author.Url,
                        IconUrl = author.Author.IconUrl
                    };
                }
                if (!String.IsNullOrEmpty(title.Text)) builder.Title = title.Text;
                if (!String.IsNullOrEmpty(url.Text)) builder.Url = url.Text;
                if (!String.IsNullOrEmpty(description.Text)) builder.Description = description.Text;
                if (color.IsSet)
                    builder.Color = new global::Discord.Color(color.Color.R, color.Color.G, color.Color.B);
                if (EmbedFieldsValues.Length > 0)
                {
                    List<EmbedFieldBuilder> fieldBuilders = new List<EmbedFieldBuilder>();
                    foreach (var field in EmbedFieldsValues)
                    {
                        fieldBuilders.Add(new EmbedFieldBuilder()
                        {
                            Name = field.Name,
                            Value = field.Value,
                            IsInline = field.Inline
                        });
                    }
                    builder.Fields = fieldBuilders;
                }
                if (!String.IsNullOrEmpty(thumbnailUrl.Text)) builder.ThumbnailUrl = thumbnailUrl.Text;
                if (!String.IsNullOrEmpty(imageUrl.Text)) builder.ImageUrl = imageUrl.Text;
                if (!footer.Footer.Equals(default(EmbedFooter)))
                {
                    builder.Footer = new EmbedFooterBuilder()
                    {
                        Text = footer.Footer.Text,
                        IconUrl = footer.Footer.IconUrl
                    };
                }
                builder.WithCurrentTimestamp();
                return builder.Build();
            }
            set
            {
                if (value.Author is EmbedAuthor embedAuthor)
                {
                    author.Author = embedAuthor;
                }
                title.Text = value.Title;
                url.Text = value.Url;
                description.Text = value.Description;
                foreach (var field in value.Fields)
                {
                    var fieldControl = GenerateNextEmbedFieldControl();
                    fieldControl.Field = field;
                    AddEmbedFieldToContainer(fieldControl);
                }
                thumbnailUrl.Text = value.Thumbnail.Value.Url;
                imageUrl.Text = value.Image.Value.Url;
                if (value.Footer is EmbedFooter embedFooter)
                {
                    footer.Footer = embedFooter;
                }
                if (value.Color != null)
                {
                    color.Color = global::System.Drawing.Color.FromArgb(value.Color.Value.R, value.Color.Value.G, value.Color.Value.B);
                }
            }
        }

        public EmbeddedMediaControl()
        {
            InitializeComponent();
        }

        private EmbeddedMediaFieldControl GenerateNextEmbedFieldControl()
        {
            var fieldControl = new EmbeddedMediaFieldControl
            {
                Tag = fieldsContainer.Controls.Count + 1
            };
            fieldControl.Name = "Embed_" + fieldControl.Tag;
            return fieldControl;
        }

        private void AddEmbedFieldToContainer(EmbeddedMediaFieldControl field)
        {
            field.Dock = DockStyle.Top;
            var preAddHeight = fieldsContainer.Height;
            fieldsContainer.Controls.Add(field);
            fieldsContainer.Controls.SetChildIndex(field, EmbedFieldsValues.Length);
            var heightToAdd = fieldsContainer.Height - preAddHeight;
            btnRemove.Location = new Point(btnRemove.Location.X, btnRemove.Location.Y + heightToAdd);
            field.btnRemove.Click += (object sender, EventArgs e) =>
            {
                btnRemove.Location = new Point(btnRemove.Location.X, btnRemove.Location.Y - heightToAdd);
            };
            ScrollControlIntoView(btnAddField);
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public EmbedField[] EmbedFieldsValues
        {
            get
            {
                List<EmbedField> tmp = new List<EmbedField>();
                foreach (var control in GetAll(fieldsContainer, typeof(EmbeddedMediaFieldControl)))
                {
                    if (control is EmbeddedMediaFieldControl fieldControl)
                    {
                        var field = fieldControl.Field;
                        if (!field.Equals(fieldControl.BasicField))
                        {
                            var builder = new EmbedFieldBuilder()
                            {
                                Name = field.Name,
                                Value = field.Value,
                                IsInline = field.Inline
                            };
                            tmp.Add(builder.Build());
                        }
                    }
                }
                return tmp.ToArray();
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            var fieldControl = GenerateNextEmbedFieldControl();
            AddEmbedFieldToContainer(fieldControl);
            this.ScrollControlIntoView(btnAddField);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
