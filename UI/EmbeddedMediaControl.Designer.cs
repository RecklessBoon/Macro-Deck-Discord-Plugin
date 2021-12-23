namespace RecklessBoon.MacroDeck.Discord.UI
{
    partial class EmbeddedMediaControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fieldsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddField = new SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary();
            this.author = new RecklessBoon.MacroDeck.Discord.UI.EmbeddedMediaAuthorControl();
            this.label8 = new System.Windows.Forms.Label();
            this.url = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.color = new RecklessBoon.MacroDeck.Discord.UI.ColorPickerControl();
            this.footer = new RecklessBoon.MacroDeck.Discord.UI.EmbeddedMediaFooterControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageUrl = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thumbnailUrl = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.description = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fieldsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.url);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.color);
            this.groupBox1.Controls.Add(this.footer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imageUrl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.thumbnailUrl);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(337, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Embed";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.BorderRadius = 8;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(181, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Progress = 0;
            this.btnRemove.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnRemove.Size = new System.Drawing.Size(150, 25);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.fieldsContainer);
            this.panel1.Location = new System.Drawing.Point(5, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 44);
            this.panel1.TabIndex = 32;
            // 
            // fieldsContainer
            // 
            this.fieldsContainer.AutoSize = true;
            this.fieldsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.fieldsContainer.Controls.Add(this.btnAddField);
            this.fieldsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsContainer.Location = new System.Drawing.Point(0, 0);
            this.fieldsContainer.Name = "fieldsContainer";
            this.fieldsContainer.Padding = new System.Windows.Forms.Padding(6);
            this.fieldsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.fieldsContainer.Size = new System.Drawing.Size(328, 44);
            this.fieldsContainer.TabIndex = 31;
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddField.BorderRadius = 8;
            this.btnAddField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddField.FlatAppearance.BorderSize = 0;
            this.btnAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddField.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddField.ForeColor = System.Drawing.Color.White;
            this.btnAddField.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(184)))));
            this.btnAddField.Icon = null;
            this.btnAddField.Location = new System.Drawing.Point(9, 9);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Progress = 0;
            this.btnAddField.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnAddField.Size = new System.Drawing.Size(150, 25);
            this.btnAddField.TabIndex = 0;
            this.btnAddField.Text = "Add Field";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // author
            // 
            this.author.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.author.Location = new System.Drawing.Point(108, 18);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(223, 62);
            this.author.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 105);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Url:";
            // 
            // url
            // 
            this.url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.url.Cursor = System.Windows.Forms.Cursors.Hand;
            this.url.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.url.Icon = null;
            this.url.Location = new System.Drawing.Point(108, 105);
            this.url.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.url.MaxCharacters = 32767;
            this.url.Multiline = false;
            this.url.Name = "url";
            this.url.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.url.PasswordChar = false;
            this.url.PlaceHolderColor = System.Drawing.Color.Gray;
            this.url.PlaceHolderText = "";
            this.url.ReadOnly = false;
            this.url.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.url.SelectionStart = 0;
            this.url.Size = new System.Drawing.Size(223, 19);
            this.url.TabIndex = 28;
            this.url.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 215);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Color:";
            // 
            // color
            // 
            this.color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.color.Color = System.Drawing.Color.Black;
            this.color.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.color.Location = new System.Drawing.Point(108, 208);
            this.color.Margin = new System.Windows.Forms.Padding(6);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(223, 25);
            this.color.TabIndex = 26;
            // 
            // footer
            // 
            this.footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.footer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.footer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.footer.Location = new System.Drawing.Point(108, 288);
            this.footer.Margin = new System.Windows.Forms.Padding(6);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(223, 45);
            this.footer.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 288);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Footer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 262);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Image URL:";
            // 
            // imageUrl
            // 
            this.imageUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.imageUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imageUrl.Icon = null;
            this.imageUrl.Location = new System.Drawing.Point(108, 262);
            this.imageUrl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.imageUrl.MaxCharacters = 32767;
            this.imageUrl.Multiline = false;
            this.imageUrl.Name = "imageUrl";
            this.imageUrl.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.imageUrl.PasswordChar = false;
            this.imageUrl.PlaceHolderColor = System.Drawing.Color.Gray;
            this.imageUrl.PlaceHolderText = "";
            this.imageUrl.ReadOnly = false;
            this.imageUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.imageUrl.SelectionStart = 0;
            this.imageUrl.Size = new System.Drawing.Size(223, 19);
            this.imageUrl.TabIndex = 22;
            this.imageUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 240);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Thumbnail URL:";
            // 
            // thumbnailUrl
            // 
            this.thumbnailUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.thumbnailUrl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thumbnailUrl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.thumbnailUrl.Icon = null;
            this.thumbnailUrl.Location = new System.Drawing.Point(108, 240);
            this.thumbnailUrl.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.thumbnailUrl.MaxCharacters = 32767;
            this.thumbnailUrl.Multiline = false;
            this.thumbnailUrl.Name = "thumbnailUrl";
            this.thumbnailUrl.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.thumbnailUrl.PasswordChar = false;
            this.thumbnailUrl.PlaceHolderColor = System.Drawing.Color.Gray;
            this.thumbnailUrl.PlaceHolderText = "";
            this.thumbnailUrl.ReadOnly = false;
            this.thumbnailUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.thumbnailUrl.SelectionStart = 0;
            this.thumbnailUrl.Size = new System.Drawing.Size(223, 19);
            this.thumbnailUrl.TabIndex = 20;
            this.thumbnailUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.description.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Icon = null;
            this.description.Location = new System.Drawing.Point(108, 126);
            this.description.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.description.MaxCharacters = 32767;
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.description.PasswordChar = false;
            this.description.PlaceHolderColor = System.Drawing.Color.Gray;
            this.description.PlaceHolderText = "";
            this.description.ReadOnly = false;
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.description.SelectionStart = 0;
            this.description.Size = new System.Drawing.Size(223, 75);
            this.description.TabIndex = 19;
            this.description.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 126);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title:";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Icon = null;
            this.title.Location = new System.Drawing.Point(108, 84);
            this.title.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.title.MaxCharacters = 32767;
            this.title.Multiline = false;
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.title.PasswordChar = false;
            this.title.PlaceHolderColor = System.Drawing.Color.Gray;
            this.title.PlaceHolderText = "";
            this.title.ReadOnly = false;
            this.title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.title.SelectionStart = 0;
            this.title.Size = new System.Drawing.Size(223, 19);
            this.title.TabIndex = 16;
            this.title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Author:";
            // 
            // EmbeddedMediaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "EmbeddedMediaControl";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(343, 440);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.fieldsContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private ColorPickerControl color;
        private EmbeddedMediaFooterControl footer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox imageUrl;
        private System.Windows.Forms.Label label4;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox thumbnailUrl;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox url;
        private EmbeddedMediaAuthorControl author;
        private System.Windows.Forms.TableLayoutPanel fieldsContainer;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary btnAddField;
        private System.Windows.Forms.Panel panel1;
        private SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary btnRemove;
    }
}
