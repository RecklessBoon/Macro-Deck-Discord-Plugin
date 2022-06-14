using SuchByte.MacroDeck.GUI.CustomControls;

namespace RecklessBoon.MacroDeck.Discord
{
    partial class ConfigurationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.clientId = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.btnOk = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.lblClientSecret = new System.Windows.Forms.Label();
            this.clientSecret = new RecklessBoon.MacroDeck.Discord.UI.PeekablePassword();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDebugLogging = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Client Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientId
            // 
            this.clientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.clientId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientId.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientId.Icon = null;
            this.clientId.Location = new System.Drawing.Point(123, 35);
            this.clientId.MaxCharacters = 32767;
            this.clientId.Multiline = false;
            this.clientId.Name = "clientId";
            this.clientId.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.clientId.PasswordChar = false;
            this.clientId.PlaceHolderColor = System.Drawing.Color.Gray;
            this.clientId.PlaceHolderText = "";
            this.clientId.ReadOnly = false;
            this.clientId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.clientId.SelectionStart = 0;
            this.clientId.Size = new System.Drawing.Size(283, 25);
            this.clientId.TabIndex = 1;
            this.clientId.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnOk
            // 
            this.btnOk.BorderRadius = 8;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(331, 137);
            this.btnOk.Name = "btnOk";
            this.btnOk.Progress = 0;
            this.btnOk.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.UseWindowsAccentColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClientSecret.Location = new System.Drawing.Point(8, 66);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(97, 29);
            this.lblClientSecret.TabIndex = 17;
            this.lblClientSecret.Text = "Client Secret:";
            this.lblClientSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientSecret
            // 
            this.clientSecret.AutoSize = true;
            this.clientSecret.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.clientSecret.Location = new System.Drawing.Point(123, 66);
            this.clientSecret.Name = "clientSecret";
            this.clientSecret.Size = new System.Drawing.Size(283, 30);
            this.clientSecret.TabIndex = 21;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.linkLabel1.Location = new System.Drawing.Point(293, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 16);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Debug Logging:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDebugLogging
            // 
            this.cbxDebugLogging.AutoSize = true;
            this.cbxDebugLogging.Location = new System.Drawing.Point(123, 108);
            this.cbxDebugLogging.Name = "cbxDebugLogging";
            this.cbxDebugLogging.Size = new System.Drawing.Size(15, 14);
            this.cbxDebugLogging.TabIndex = 24;
            this.cbxDebugLogging.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 171);
            this.Controls.Add(this.cbxDebugLogging);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.clientSecret);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientId);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblClientSecret);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ConfigurationForm";
            this.Padding = new System.Windows.Forms.Padding(5, 35, 5, 5);
            this.Text = "Discord Integration Plugin Configuration";
            this.Controls.SetChildIndex(this.lblClientSecret, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.clientId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.clientSecret, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbxDebugLogging, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundedTextBox clientId;
        private ButtonPrimary btnOk;
        private System.Windows.Forms.Label lblClientSecret;
        private UI.PeekablePassword clientSecret;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxDebugLogging;
    }
}