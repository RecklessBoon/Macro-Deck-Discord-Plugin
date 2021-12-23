namespace RecklessBoon.MacroDeck.Discord.UI
{
    partial class EmbeddedMediaFooterControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.iconUrl = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Icon URL:";
            // 
            // iconUrl
            // 
            this.iconUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.iconUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconUrl.Icon = null;
            this.iconUrl.Location = new System.Drawing.Point(76, 22);
            this.iconUrl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.iconUrl.MaxCharacters = 32767;
            this.iconUrl.Multiline = false;
            this.iconUrl.Name = "iconUrl";
            this.iconUrl.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.iconUrl.PasswordChar = false;
            this.iconUrl.PlaceHolderColor = System.Drawing.Color.Gray;
            this.iconUrl.PlaceHolderText = "";
            this.iconUrl.ReadOnly = false;
            this.iconUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.iconUrl.SelectionStart = 0;
            this.iconUrl.Size = new System.Drawing.Size(96, 19);
            this.iconUrl.TabIndex = 10;
            this.iconUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text:";
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Icon = null;
            this.text.Location = new System.Drawing.Point(76, 1);
            this.text.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.text.MaxCharacters = 32767;
            this.text.Multiline = false;
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.text.PasswordChar = false;
            this.text.PlaceHolderColor = System.Drawing.Color.Gray;
            this.text.PlaceHolderText = "";
            this.text.ReadOnly = false;
            this.text.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text.SelectionStart = 0;
            this.text.Size = new System.Drawing.Size(96, 19);
            this.text.TabIndex = 8;
            this.text.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmbeddedMediaFooterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Name = "EmbeddedMediaFooterControl";
            this.Size = new System.Drawing.Size(174, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox iconUrl;
        private System.Windows.Forms.Label label1;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox text;
    }
}
