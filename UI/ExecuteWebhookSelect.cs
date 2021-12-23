using Discord;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RecklessBoon.MacroDeck.Discord.Actions;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    public partial class ExecuteWebhookSelect : ActionConfigControl
    {
        public class WebhookConfig
        {
            public string Url { get; set; }
            public string Name { get; set; }
            public Uri AvatarUrl { get; set; }
            public string Message { get; set; }
            public Embed[] Embeds { get; set; }
        }

        private ExecuteWebhookAction _macroDeckAction;

        public ExecuteWebhookSelect(ExecuteWebhookAction macroDeckAction, ActionConfigurator actionConfigurator)
        {
            this._macroDeckAction = macroDeckAction;
            InitializeComponent();

            this.Load += ExecuteWebhookSelect_Load;

            this.LoadConfig();
        }

        private void ExecuteWebhookSelect_Load(object sender, EventArgs e)
        {
            this.Width = Parent.ClientSize.Width;
            this.Height = Parent.ClientSize.Height;
            panel1.Width = this.ClientSize.Width;
        }

        public override bool OnActionSave()
        {
            if (String.IsNullOrWhiteSpace(webhookUrl.Text))
            {
                return false; // Return false if the user has not filled out the text box
            }
            try
            {
                JObject configuration = new JObject
                {
                    ["url"] = StringCipher.Encrypt(webhookUrl.Text, StringCipher.GetMachineGuid()),
                    ["name"] = name.Text,
                    ["avatar_url"] = Uri.IsWellFormedUriString(avatarUrl.Text, UriKind.Absolute) ? avatarUrl.Text : null,
                    ["message"] = message.Text,
                    ["embeds"] = JsonConvert.SerializeObject(EmbedsValues)
                };
                this._macroDeckAction.ConfigurationSummary = message.Text.ToString(); // Set a summary of the configuration that gets displayed in the ButtonConfigurator item
                this._macroDeckAction.Configuration = configuration.ToString();
            }
            catch { }
            return true; // Return true if the action was configured successfully; This closes the ActionConfigurator
        }

        public static WebhookConfig LoadWebhook(string configuration)
        {
            var webhook = new WebhookConfig();
            JObject config = JObject.Parse(configuration);
            webhook.Url = config.ContainsKey("url") ? StringCipher.Decrypt(config["url"].ToString(), StringCipher.GetMachineGuid()) : default;
            webhook.Name = config.ContainsKey("name") ? config["name"].ToString() : default;
            webhook.AvatarUrl = config.ContainsKey("avatar_url") && Uri.IsWellFormedUriString(config["avatar_url"].ToString(), UriKind.Absolute) ? new Uri(config["avatar_url"].ToString()) : default;
            webhook.Message = config.ContainsKey("message") ? config["message"].ToString() : default;
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Converters.Add(new EmbedJsonConverter());
            webhook.Embeds = config.ContainsKey("embeds") ? JsonConvert.DeserializeObject<Embed[]>(config["embeds"].ToString(), settings) : new Embed[0];
            return webhook;
        }

        private void LoadConfig()
        {
            if (!String.IsNullOrWhiteSpace(this._macroDeckAction.Configuration))
            {
                var webhook = LoadWebhook(this._macroDeckAction.Configuration);
                webhookUrl.Text = webhook.Url;
                name.Text = webhook.Name;
                avatarUrl.Text = webhook.AvatarUrl?.ToString();
                message.Text = webhook.Message;
                foreach (var embed in webhook.Embeds)
                {
                    var embedControl = GenerateNextEmbedControl();
                    embedControl.Embed = embed;
                    AddEmbedToContainer(embedControl);
                }
            }
        }

        private EmbeddedMediaControl GenerateNextEmbedControl()
        {
            var embedControl = new EmbeddedMediaControl
            {
                Tag = embedsContainer.Controls.Count + 1
            };
            embedControl.Name = "Embed_" + embedControl.Tag;
            return embedControl;
        }

        private void AddEmbedToContainer(EmbeddedMediaControl embed)
        {
            embed.Dock = DockStyle.Top;
            embedsContainer.Controls.Add(embed);
            embedsContainer.Controls.SetChildIndex(embed, EmbedsValues.Length - 1);
            ScrollControlIntoView(btnAddEmbed);
        }

        private IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public Embed[] EmbedsValues
        {
            get
            {
                List<Embed> tmp = new List<Embed>();
                foreach (var control in GetAll(embedsContainer, typeof(EmbeddedMediaControl)))
                {
                    if (control is EmbeddedMediaControl embedControl)
                    {
                        var embed = embedControl.Embed;
                        var basic_embed = (new EmbedBuilder() { Timestamp = embed.Timestamp }).Build();
                        if (!embed.Equals(basic_embed))
                        {
                            var builder = new EmbedBuilder()
                            {
                                Author = new EmbedAuthorBuilder()
                                {
                                    Name = embed.Author.Value.Name,
                                    Url = embed.Author.Value.Url,
                                    IconUrl = embed.Author.Value.IconUrl,
                                },
                                Title = embed.Title,
                                Url = embed.Url,
                                Description = embed.Description,
                                ThumbnailUrl = embed.Thumbnail?.Url,
                                ImageUrl = embed.Image?.Url,
                                Color = embed.Color,
                                Footer = new EmbedFooterBuilder()
                                {
                                    Text = embed.Footer.Value.Text,
                                    IconUrl = embed.Footer.Value.IconUrl
                                }
                            };
                            builder.WithCurrentTimestamp();
                            tmp.Add(builder.Build());
                        }
                    }
                }
                return tmp.ToArray();
            }
        }

        private void btnAddEmbed_Click(object sender, EventArgs e)
        {
            var embedControl = GenerateNextEmbedControl();
            AddEmbedToContainer(embedControl);
            this.ScrollControlIntoView(btnAddEmbed);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
