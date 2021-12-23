using SuchByte.MacroDeck.GUI.CustomControls;

namespace RecklessBoon.MacroDeck.Discord.UI
{
    partial class ExecuteWebhookSelect
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.webhookUrl = new RecklessBoon.MacroDeck.Discord.UI.PeekablePassword();
            this.avatarUrl = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.name = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.embedsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddEmbed = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.lblAvatarUrl = new System.Windows.Forms.Label();
            this.lblWebhookUrl = new System.Windows.Forms.Label();
            this.message = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.panel1.SuspendLayout();
            this.embedsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.webhookUrl);
            this.panel1.Controls.Add(this.avatarUrl);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.embedsContainer);
            this.panel1.Controls.Add(this.lblAvatarUrl);
            this.panel1.Controls.Add(this.lblWebhookUrl);
            this.panel1.Controls.Add(this.message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(342, 631);
            this.panel1.TabIndex = 45;
            // 
            // webhookUrl
            // 
            this.webhookUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webhookUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.webhookUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.webhookUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.webhookUrl.Location = new System.Drawing.Point(115, 11);
            this.webhookUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webhookUrl.Name = "webhookUrl";
            this.webhookUrl.Size = new System.Drawing.Size(215, 28);
            this.webhookUrl.TabIndex = 55;
            // 
            // avatarUrl
            // 
            this.avatarUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avatarUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.avatarUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.avatarUrl.Icon = null;
            this.avatarUrl.Location = new System.Drawing.Point(114, 71);
            this.avatarUrl.MaxCharacters = 32767;
            this.avatarUrl.Multiline = false;
            this.avatarUrl.Name = "avatarUrl";
            this.avatarUrl.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.avatarUrl.PasswordChar = false;
            this.avatarUrl.PlaceHolderColor = System.Drawing.Color.Gray;
            this.avatarUrl.PlaceHolderText = "";
            this.avatarUrl.ReadOnly = false;
            this.avatarUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.avatarUrl.SelectionStart = 0;
            this.avatarUrl.Size = new System.Drawing.Size(216, 25);
            this.avatarUrl.TabIndex = 53;
            this.avatarUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(9, 40);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5);
            this.lblName.Size = new System.Drawing.Size(52, 24);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name:";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Icon = null;
            this.name.Location = new System.Drawing.Point(114, 40);
            this.name.MaxCharacters = 32767;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.name.PasswordChar = false;
            this.name.PlaceHolderColor = System.Drawing.Color.Gray;
            this.name.PlaceHolderText = "";
            this.name.ReadOnly = false;
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(216, 25);
            this.name.TabIndex = 51;
            this.name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessage.Location = new System.Drawing.Point(9, 102);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5);
            this.lblMessage.Size = new System.Drawing.Size(97, 24);
            this.lblMessage.TabIndex = 47;
            this.lblMessage.Text = "Message Text:";
            // 
            // embedsContainer
            // 
            this.embedsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.embedsContainer.AutoSize = true;
            this.embedsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.embedsContainer.ColumnCount = 1;
            this.embedsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.embedsContainer.Controls.Add(this.btnAddEmbed);
            this.embedsContainer.Location = new System.Drawing.Point(0, 193);
            this.embedsContainer.Name = "embedsContainer";
            this.embedsContainer.Padding = new System.Windows.Forms.Padding(6);
            this.embedsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.embedsContainer.Size = new System.Drawing.Size(342, 39);
            this.embedsContainer.TabIndex = 50;
            // 
            // btnAddEmbed
            // 
            this.btnAddEmbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddEmbed.BorderRadius = 8;
            this.btnAddEmbed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmbed.FlatAppearance.BorderSize = 0;
            this.btnAddEmbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmbed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddEmbed.ForeColor = System.Drawing.Color.White;
            this.btnAddEmbed.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnAddEmbed.Icon = null;
            this.btnAddEmbed.Location = new System.Drawing.Point(9, 9);
            this.btnAddEmbed.Name = "btnAddEmbed";
            this.btnAddEmbed.Progress = 0;
            this.btnAddEmbed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnAddEmbed.Size = new System.Drawing.Size(324, 21);
            this.btnAddEmbed.TabIndex = 2;
            this.btnAddEmbed.Text = "Add Embed";
            this.btnAddEmbed.UseVisualStyleBackColor = false;
            this.btnAddEmbed.Click += new System.EventHandler(this.btnAddEmbed_Click);
            // 
            // lblAvatarUrl
            // 
            this.lblAvatarUrl.AutoSize = true;
            this.lblAvatarUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvatarUrl.Location = new System.Drawing.Point(9, 71);
            this.lblAvatarUrl.Name = "lblAvatarUrl";
            this.lblAvatarUrl.Padding = new System.Windows.Forms.Padding(5);
            this.lblAvatarUrl.Size = new System.Drawing.Size(81, 24);
            this.lblAvatarUrl.TabIndex = 54;
            this.lblAvatarUrl.Text = "Avatar URL:";
            // 
            // lblWebhookUrl
            // 
            this.lblWebhookUrl.AutoSize = true;
            this.lblWebhookUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWebhookUrl.Location = new System.Drawing.Point(9, 9);
            this.lblWebhookUrl.Name = "lblWebhookUrl";
            this.lblWebhookUrl.Padding = new System.Windows.Forms.Padding(5);
            this.lblWebhookUrl.Size = new System.Drawing.Size(99, 24);
            this.lblWebhookUrl.TabIndex = 46;
            this.lblWebhookUrl.Text = "Webhook URL:";
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message.Icon = null;
            this.message.Location = new System.Drawing.Point(114, 102);
            this.message.MaxCharacters = 2000;
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.message.PasswordChar = false;
            this.message.PlaceHolderColor = System.Drawing.Color.Gray;
            this.message.PlaceHolderText = "";
            this.message.ReadOnly = false;
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.message.SelectionStart = 0;
            this.message.Size = new System.Drawing.Size(216, 85);
            this.message.TabIndex = 48;
            this.message.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ExecuteWebhookSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel1);
            this.Name = "ExecuteWebhookSelect";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(362, 651);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.embedsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RoundedTextBox avatarUrl;
        private System.Windows.Forms.Label lblName;
        private RoundedTextBox name;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TableLayoutPanel embedsContainer;
        private System.Windows.Forms.Label lblAvatarUrl;
        private System.Windows.Forms.Label lblWebhookUrl;
        private RoundedTextBox message;
        private ButtonPrimary btnAddEmbed;
        private PeekablePassword webhookUrl;
    }
}
