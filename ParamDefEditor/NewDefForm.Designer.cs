namespace ParamDefEditor
{
    partial class NewDefForm
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
            this.VersionCombobox = new System.Windows.Forms.ComboBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.FieldCountLabel = new System.Windows.Forms.Label();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.EncodingCombobox = new System.Windows.Forms.ComboBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathBrowseButton = new System.Windows.Forms.Button();
            this.FieldCountInput = new System.Windows.Forms.NumericUpDown();
            this.CreateButton = new System.Windows.Forms.Button();
            this.VersionHelpButton = new System.Windows.Forms.Button();
            this.EncodingHelpButton = new System.Windows.Forms.Button();
            this.TypeHelpButton = new System.Windows.Forms.Button();
            this.BigEndianCheckBox = new System.Windows.Forms.CheckBox();
            this.BigEndianHelpButton = new System.Windows.Forms.Button();
            this.DataVersionInput = new System.Windows.Forms.NumericUpDown();
            this.DataVersionLabel = new System.Windows.Forms.Label();
            this.DataVersionHelpButton = new System.Windows.Forms.Button();
            this.FieldCountHelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FieldCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVersionInput)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionCombobox
            // 
            this.VersionCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.VersionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VersionCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersionCombobox.ForeColor = System.Drawing.SystemColors.Control;
            this.VersionCombobox.FormattingEnabled = true;
            this.VersionCombobox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "201",
            "202",
            "203"});
            this.VersionCombobox.Location = new System.Drawing.Point(90, 6);
            this.VersionCombobox.Name = "VersionCombobox";
            this.VersionCombobox.Size = new System.Drawing.Size(195, 21);
            this.VersionCombobox.TabIndex = 0;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(12, 10);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(45, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 64);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(64, 13);
            this.TypeLabel.TabIndex = 2;
            this.TypeLabel.Text = "ParamType:";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TypeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TypeTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeTextBox.Location = new System.Drawing.Point(90, 60);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(195, 20);
            this.TypeTextBox.TabIndex = 3;
            this.TypeTextBox.Text = "AI_STANDARD_INFO_BANK";
            this.TypeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TypeTextBox_KeyPress);
            // 
            // FieldCountLabel
            // 
            this.FieldCountLabel.AutoSize = true;
            this.FieldCountLabel.Location = new System.Drawing.Point(12, 116);
            this.FieldCountLabel.Name = "FieldCountLabel";
            this.FieldCountLabel.Size = new System.Drawing.Size(63, 13);
            this.FieldCountLabel.TabIndex = 4;
            this.FieldCountLabel.Text = "Field Count:";
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Location = new System.Drawing.Point(12, 37);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(55, 13);
            this.EncodingLabel.TabIndex = 6;
            this.EncodingLabel.Text = "Encoding:";
            // 
            // EncodingCombobox
            // 
            this.EncodingCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.EncodingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncodingCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncodingCombobox.ForeColor = System.Drawing.SystemColors.Control;
            this.EncodingCombobox.FormattingEnabled = true;
            this.EncodingCombobox.Items.AddRange(new object[] {
            "Shift-JIS",
            "UTF-16"});
            this.EncodingCombobox.Location = new System.Drawing.Point(90, 33);
            this.EncodingCombobox.Name = "EncodingCombobox";
            this.EncodingCombobox.Size = new System.Drawing.Size(195, 21);
            this.EncodingCombobox.TabIndex = 7;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(12, 142);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(60, 13);
            this.PathLabel.TabIndex = 8;
            this.PathLabel.Text = "Save Path:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.PathTextBox.Location = new System.Drawing.Point(89, 139);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(168, 20);
            this.PathTextBox.TabIndex = 9;
            // 
            // PathBrowseButton
            // 
            this.PathBrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PathBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PathBrowseButton.Location = new System.Drawing.Point(263, 137);
            this.PathBrowseButton.Name = "PathBrowseButton";
            this.PathBrowseButton.Size = new System.Drawing.Size(54, 23);
            this.PathBrowseButton.TabIndex = 10;
            this.PathBrowseButton.Text = "Browse";
            this.PathBrowseButton.UseVisualStyleBackColor = true;
            this.PathBrowseButton.Click += new System.EventHandler(this.PathBrowseButton_Click);
            // 
            // FieldCountInput
            // 
            this.FieldCountInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FieldCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FieldCountInput.ForeColor = System.Drawing.SystemColors.Control;
            this.FieldCountInput.Location = new System.Drawing.Point(89, 113);
            this.FieldCountInput.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.FieldCountInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FieldCountInput.Name = "FieldCountInput";
            this.FieldCountInput.Size = new System.Drawing.Size(196, 20);
            this.FieldCountInput.TabIndex = 11;
            this.FieldCountInput.ThousandsSeparator = true;
            this.FieldCountInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateButton
            // 
            this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Location = new System.Drawing.Point(15, 192);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(302, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // VersionHelpButton
            // 
            this.VersionHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VersionHelpButton.Location = new System.Drawing.Point(290, 6);
            this.VersionHelpButton.Name = "VersionHelpButton";
            this.VersionHelpButton.Size = new System.Drawing.Size(27, 21);
            this.VersionHelpButton.TabIndex = 13;
            this.VersionHelpButton.Text = "?";
            this.VersionHelpButton.UseVisualStyleBackColor = true;
            this.VersionHelpButton.Click += new System.EventHandler(this.VersionHelpButton_Click);
            // 
            // EncodingHelpButton
            // 
            this.EncodingHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncodingHelpButton.Location = new System.Drawing.Point(290, 33);
            this.EncodingHelpButton.Name = "EncodingHelpButton";
            this.EncodingHelpButton.Size = new System.Drawing.Size(27, 21);
            this.EncodingHelpButton.TabIndex = 14;
            this.EncodingHelpButton.Text = "?";
            this.EncodingHelpButton.UseVisualStyleBackColor = true;
            this.EncodingHelpButton.Click += new System.EventHandler(this.EncodingHelpButton_Click);
            // 
            // TypeHelpButton
            // 
            this.TypeHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeHelpButton.Location = new System.Drawing.Point(290, 60);
            this.TypeHelpButton.Name = "TypeHelpButton";
            this.TypeHelpButton.Size = new System.Drawing.Size(27, 21);
            this.TypeHelpButton.TabIndex = 15;
            this.TypeHelpButton.Text = "?";
            this.TypeHelpButton.UseVisualStyleBackColor = true;
            this.TypeHelpButton.Click += new System.EventHandler(this.TypeHelpButton_Click);
            // 
            // BigEndianCheckBox
            // 
            this.BigEndianCheckBox.AutoSize = true;
            this.BigEndianCheckBox.Location = new System.Drawing.Point(15, 169);
            this.BigEndianCheckBox.Name = "BigEndianCheckBox";
            this.BigEndianCheckBox.Size = new System.Drawing.Size(77, 17);
            this.BigEndianCheckBox.TabIndex = 16;
            this.BigEndianCheckBox.Text = "Big Endian";
            this.BigEndianCheckBox.UseVisualStyleBackColor = true;
            // 
            // BigEndianHelpButton
            // 
            this.BigEndianHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BigEndianHelpButton.Location = new System.Drawing.Point(290, 166);
            this.BigEndianHelpButton.Name = "BigEndianHelpButton";
            this.BigEndianHelpButton.Size = new System.Drawing.Size(27, 21);
            this.BigEndianHelpButton.TabIndex = 17;
            this.BigEndianHelpButton.Text = "?";
            this.BigEndianHelpButton.UseVisualStyleBackColor = true;
            this.BigEndianHelpButton.Click += new System.EventHandler(this.BigEndianHelpButton_Click);
            // 
            // DataVersionInput
            // 
            this.DataVersionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DataVersionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataVersionInput.ForeColor = System.Drawing.SystemColors.Control;
            this.DataVersionInput.Location = new System.Drawing.Point(90, 86);
            this.DataVersionInput.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.DataVersionInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DataVersionInput.Name = "DataVersionInput";
            this.DataVersionInput.Size = new System.Drawing.Size(195, 20);
            this.DataVersionInput.TabIndex = 19;
            this.DataVersionInput.ThousandsSeparator = true;
            this.DataVersionInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DataVersionLabel
            // 
            this.DataVersionLabel.AutoSize = true;
            this.DataVersionLabel.Location = new System.Drawing.Point(12, 90);
            this.DataVersionLabel.Name = "DataVersionLabel";
            this.DataVersionLabel.Size = new System.Drawing.Size(71, 13);
            this.DataVersionLabel.TabIndex = 18;
            this.DataVersionLabel.Text = "Data Version:";
            // 
            // DataVersionHelpButton
            // 
            this.DataVersionHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataVersionHelpButton.Location = new System.Drawing.Point(290, 87);
            this.DataVersionHelpButton.Name = "DataVersionHelpButton";
            this.DataVersionHelpButton.Size = new System.Drawing.Size(27, 21);
            this.DataVersionHelpButton.TabIndex = 20;
            this.DataVersionHelpButton.Text = "?";
            this.DataVersionHelpButton.UseVisualStyleBackColor = true;
            this.DataVersionHelpButton.Click += new System.EventHandler(this.DataVersionHelpButton_Click);
            // 
            // FieldCountHelpButton
            // 
            this.FieldCountHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FieldCountHelpButton.Location = new System.Drawing.Point(290, 113);
            this.FieldCountHelpButton.Name = "FieldCountHelpButton";
            this.FieldCountHelpButton.Size = new System.Drawing.Size(27, 21);
            this.FieldCountHelpButton.TabIndex = 21;
            this.FieldCountHelpButton.Text = "?";
            this.FieldCountHelpButton.UseVisualStyleBackColor = true;
            this.FieldCountHelpButton.Click += new System.EventHandler(this.FieldCountHelpButton_Click);
            // 
            // NewDefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(332, 223);
            this.Controls.Add(this.FieldCountHelpButton);
            this.Controls.Add(this.DataVersionHelpButton);
            this.Controls.Add(this.DataVersionInput);
            this.Controls.Add(this.DataVersionLabel);
            this.Controls.Add(this.BigEndianHelpButton);
            this.Controls.Add(this.BigEndianCheckBox);
            this.Controls.Add(this.TypeHelpButton);
            this.Controls.Add(this.EncodingHelpButton);
            this.Controls.Add(this.VersionHelpButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FieldCountInput);
            this.Controls.Add(this.PathBrowseButton);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.EncodingCombobox);
            this.Controls.Add(this.EncodingLabel);
            this.Controls.Add(this.FieldCountLabel);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.VersionCombobox);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewDefForm";
            this.Text = "Create a new Param Def";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDefForm_FormClosing);
            this.Load += new System.EventHandler(this.NewDefForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FieldCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataVersionInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VersionCombobox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Label FieldCountLabel;
        private System.Windows.Forms.Label EncodingLabel;
        private System.Windows.Forms.ComboBox EncodingCombobox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button PathBrowseButton;
        private System.Windows.Forms.NumericUpDown FieldCountInput;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button VersionHelpButton;
        private System.Windows.Forms.Button EncodingHelpButton;
        private System.Windows.Forms.Button TypeHelpButton;
        private System.Windows.Forms.CheckBox BigEndianCheckBox;
        private System.Windows.Forms.Button BigEndianHelpButton;
        private System.Windows.Forms.NumericUpDown DataVersionInput;
        private System.Windows.Forms.Label DataVersionLabel;
        private System.Windows.Forms.Button DataVersionHelpButton;
        private System.Windows.Forms.Button FieldCountHelpButton;
    }
}