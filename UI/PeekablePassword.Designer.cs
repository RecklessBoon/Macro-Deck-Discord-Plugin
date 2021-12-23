namespace RecklessBoon.MacroDeck.Discord.UI
{
    partial class PeekablePassword
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
            this.password = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.btnShow = new SuchByte.MacroDeck.GUI.CustomControls.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Icon = null;
            this.password.Location = new System.Drawing.Point(0, 0);
            this.password.MaxCharacters = 32767;
            this.password.Multiline = false;
            this.password.Name = "password";
            this.password.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.password.PasswordChar = true;
            this.password.PlaceHolderColor = System.Drawing.Color.Gray;
            this.password.PlaceHolderText = "";
            this.password.ReadOnly = false;
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectionStart = 0;
            this.password.Size = new System.Drawing.Size(294, 25);
            this.password.TabIndex = 50;
            this.password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = global::RecklessBoon.MacroDeck.Discord.Properties.Resources.eye_outline;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.HoverImage = null;
            this.btnShow.Location = new System.Drawing.Point(300, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(25, 25);
            this.btnShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnShow.TabIndex = 52;
            this.btnShow.TabStop = false;
            this.btnShow.Tag = "ToShow";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            this.btnShow.MouseEnter += new System.EventHandler(this.btnShow_MouseEnter);
            this.btnShow.MouseLeave += new System.EventHandler(this.btnShow_MouseLeave);
            // 
            // PeekablePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.password);
            this.Controls.Add(this.btnShow);
            this.Name = "PeekablePassword";
            this.Size = new System.Drawing.Size(328, 28);
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox password;
        private SuchByte.MacroDeck.GUI.CustomControls.PictureButton btnShow;
    }
}
