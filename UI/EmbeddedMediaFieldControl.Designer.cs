namespace RecklessBoon.MacroDeck.Discord.UI
{
    partial class EmbeddedMediaFieldControl
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
            this.inline = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.value_field = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.inline);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.value_field);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Field";
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
            this.btnRemove.Location = new System.Drawing.Point(79, 84);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Progress = 0;
            this.btnRemove.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(94)))));
            this.btnRemove.Size = new System.Drawing.Size(138, 25);
            this.btnRemove.TabIndex = 34;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // inline
            // 
            this.inline.AutoSize = true;
            this.inline.ForeColor = System.Drawing.Color.White;
            this.inline.Location = new System.Drawing.Point(79, 63);
            this.inline.Name = "inline";
            this.inline.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.inline.Size = new System.Drawing.Size(20, 14);
            this.inline.TabIndex = 30;
            this.inline.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Value:";
            // 
            // value_field
            // 
            this.value_field.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.value_field.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.value_field.Cursor = System.Windows.Forms.Cursors.Hand;
            this.value_field.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_field.Icon = null;
            this.value_field.Location = new System.Drawing.Point(79, 40);
            this.value_field.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.value_field.MaxCharacters = 32767;
            this.value_field.Multiline = false;
            this.value_field.Name = "value_field";
            this.value_field.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.value_field.PasswordChar = false;
            this.value_field.PlaceHolderColor = System.Drawing.Color.Gray;
            this.value_field.PlaceHolderText = "";
            this.value_field.ReadOnly = false;
            this.value_field.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.value_field.SelectionStart = 0;
            this.value_field.Size = new System.Drawing.Size(139, 19);
            this.value_field.TabIndex = 28;
            this.value_field.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Inline:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name:";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Icon = null;
            this.name.Location = new System.Drawing.Point(79, 19);
            this.name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.name.MaxCharacters = 32767;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.name.PasswordChar = false;
            this.name.PlaceHolderColor = System.Drawing.Color.Gray;
            this.name.PlaceHolderText = "";
            this.name.ReadOnly = false;
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(139, 19);
            this.name.TabIndex = 25;
            this.name.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // EmbeddedMediaFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "EmbeddedMediaFieldControl";
            this.Size = new System.Drawing.Size(223, 120);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox inline;
        private System.Windows.Forms.Label label3;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox value_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuchByte.MacroDeck.GUI.CustomControls.RoundedTextBox name;
        internal SuchByte.MacroDeck.GUI.CustomControls.ButtonPrimary btnRemove;
    }
}
