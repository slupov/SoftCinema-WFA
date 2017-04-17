namespace SoftCinema.Client.Forms
{
    partial class UserDetailsForm
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UserDetailsLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.UsernameInfoLabel = new System.Windows.Forms.Label();
            this.EmailInfoLabel = new System.Windows.Forms.Label();
            this.PhoneNumberInfoLabel = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.IsDeletedLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameLabel.Location = new System.Drawing.Point(138, 105);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(156, 45);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UserDetailsLabel
            // 
            this.UserDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.UserDetailsLabel.Location = new System.Drawing.Point(34, 9);
            this.UserDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserDetailsLabel.Name = "UserDetailsLabel";
            this.UserDetailsLabel.Size = new System.Drawing.Size(233, 57);
            this.UserDetailsLabel.TabIndex = 3;
            this.UserDetailsLabel.Text = "Edit User";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailLabel.Location = new System.Drawing.Point(138, 150);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(156, 45);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(138, 195);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(204, 45);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RoleLabel.Location = new System.Drawing.Point(138, 240);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(156, 45);
            this.RoleLabel.TabIndex = 6;
            this.RoleLabel.Text = "Role";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(410, 104);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UsernameTextBox.Size = new System.Drawing.Size(235, 32);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(410, 149);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EmailTextBox.Size = new System.Drawing.Size(235, 32);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(410, 194);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(235, 32);
            this.PhoneNumberTextBox.TabIndex = 10;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // UsernameInfoLabel
            // 
            this.UsernameInfoLabel.AutoSize = true;
            this.UsernameInfoLabel.Location = new System.Drawing.Point(668, 119);
            this.UsernameInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameInfoLabel.Name = "UsernameInfoLabel";
            this.UsernameInfoLabel.Size = new System.Drawing.Size(73, 13);
            this.UsernameInfoLabel.TabIndex = 12;
            this.UsernameInfoLabel.Text = "UsernameInfo";
            // 
            // EmailInfoLabel
            // 
            this.EmailInfoLabel.AutoSize = true;
            this.EmailInfoLabel.Location = new System.Drawing.Point(668, 164);
            this.EmailInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailInfoLabel.Name = "EmailInfoLabel";
            this.EmailInfoLabel.Size = new System.Drawing.Size(50, 13);
            this.EmailInfoLabel.TabIndex = 13;
            this.EmailInfoLabel.Text = "EmailInfo";
            // 
            // PhoneNumberInfoLabel
            // 
            this.PhoneNumberInfoLabel.AutoSize = true;
            this.PhoneNumberInfoLabel.Location = new System.Drawing.Point(668, 209);
            this.PhoneNumberInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberInfoLabel.Name = "PhoneNumberInfoLabel";
            this.PhoneNumberInfoLabel.Size = new System.Drawing.Size(93, 13);
            this.PhoneNumberInfoLabel.TabIndex = 14;
            this.PhoneNumberInfoLabel.Text = "PhoneNumberInfo";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(410, 239);
            this.RoleComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(235, 37);
            this.RoleComboBox.TabIndex = 16;
            // 
            // EditUserButton
            // 
            this.EditUserButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserButton.Location = new System.Drawing.Point(458, 355);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(117, 37);
            this.EditUserButton.TabIndex = 17;
            this.EditUserButton.Text = "Save Changes";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesRadioButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.YesRadioButton.Location = new System.Drawing.Point(427, 292);
            this.YesRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(55, 24);
            this.YesRadioButton.TabIndex = 19;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoRadioButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.NoRadioButton.Location = new System.Drawing.Point(575, 292);
            this.NoRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(47, 24);
            this.NoRadioButton.TabIndex = 20;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // IsDeletedLabel
            // 
            this.IsDeletedLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsDeletedLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.IsDeletedLabel.Location = new System.Drawing.Point(138, 285);
            this.IsDeletedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IsDeletedLabel.Name = "IsDeletedLabel";
            this.IsDeletedLabel.Size = new System.Drawing.Size(230, 45);
            this.IsDeletedLabel.TabIndex = 21;
            this.IsDeletedLabel.Text = "Account Active";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(279, 355);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 37);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(814, 425);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.IsDeletedLabel);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.PhoneNumberInfoLabel);
            this.Controls.Add(this.EmailInfoLabel);
            this.Controls.Add(this.UsernameInfoLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserDetailsLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDetailsForm";
            this.Text = "UserDetailsForm";
            this.Load += new System.EventHandler(this.UserList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label UserDetailsLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label UsernameInfoLabel;
        private System.Windows.Forms.Label EmailInfoLabel;
        private System.Windows.Forms.Label PhoneNumberInfoLabel;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.RadioButton YesRadioButton;
        private System.Windows.Forms.RadioButton NoRadioButton;
        private System.Windows.Forms.Label IsDeletedLabel;
        private System.Windows.Forms.Button BackButton;
    }
}