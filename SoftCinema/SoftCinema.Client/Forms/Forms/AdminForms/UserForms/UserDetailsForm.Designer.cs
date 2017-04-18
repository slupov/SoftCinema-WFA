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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameLabel.Location = new System.Drawing.Point(136, 129);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(208, 55);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UserDetailsLabel
            // 
            this.UserDetailsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.UserDetailsLabel.Location = new System.Drawing.Point(45, 11);
            this.UserDetailsLabel.Name = "UserDetailsLabel";
            this.UserDetailsLabel.Size = new System.Drawing.Size(311, 70);
            this.UserDetailsLabel.TabIndex = 3;
            this.UserDetailsLabel.Text = "Edit User";
            // 
            // EmailLabel
            // 
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailLabel.Location = new System.Drawing.Point(136, 185);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(208, 55);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(136, 240);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(272, 55);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RoleLabel.Location = new System.Drawing.Point(136, 295);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(208, 55);
            this.RoleLabel.TabIndex = 6;
            this.RoleLabel.Text = "Role";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(422, 130);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextBox.Multiline = true;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.UsernameTextBox.Size = new System.Drawing.Size(312, 38);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(422, 185);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Multiline = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EmailTextBox.Size = new System.Drawing.Size(312, 38);
            this.EmailTextBox.TabIndex = 9;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(422, 241);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumberTextBox.Multiline = true;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(312, 38);
            this.PhoneNumberTextBox.TabIndex = 10;
            this.PhoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // UsernameInfoLabel
            // 
            this.UsernameInfoLabel.AutoSize = true;
            this.UsernameInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.UsernameInfoLabel.Location = new System.Drawing.Point(749, 147);
            this.UsernameInfoLabel.Name = "UsernameInfoLabel";
            this.UsernameInfoLabel.Size = new System.Drawing.Size(96, 17);
            this.UsernameInfoLabel.TabIndex = 12;
            this.UsernameInfoLabel.Text = "UsernameInfo";
            // 
            // EmailInfoLabel
            // 
            this.EmailInfoLabel.AutoSize = true;
            this.EmailInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.EmailInfoLabel.Location = new System.Drawing.Point(749, 200);
            this.EmailInfoLabel.Name = "EmailInfoLabel";
            this.EmailInfoLabel.Size = new System.Drawing.Size(65, 17);
            this.EmailInfoLabel.TabIndex = 13;
            this.EmailInfoLabel.Text = "EmailInfo";
            // 
            // PhoneNumberInfoLabel
            // 
            this.PhoneNumberInfoLabel.AutoSize = true;
            this.PhoneNumberInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneNumberInfoLabel.Location = new System.Drawing.Point(749, 256);
            this.PhoneNumberInfoLabel.Name = "PhoneNumberInfoLabel";
            this.PhoneNumberInfoLabel.Size = new System.Drawing.Size(122, 17);
            this.PhoneNumberInfoLabel.TabIndex = 14;
            this.PhoneNumberInfoLabel.Text = "PhoneNumberInfo";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(422, 296);
            this.RoleComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(312, 41);
            this.RoleComboBox.TabIndex = 16;
            // 
            // EditUserButton
            // 
            this.EditUserButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserButton.Location = new System.Drawing.Point(658, 437);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(156, 46);
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
            this.YesRadioButton.Location = new System.Drawing.Point(444, 361);
            this.YesRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(67, 29);
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
            this.NoRadioButton.Location = new System.Drawing.Point(642, 361);
            this.NoRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(58, 29);
            this.NoRadioButton.TabIndex = 20;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            // 
            // IsDeletedLabel
            // 
            this.IsDeletedLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IsDeletedLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.IsDeletedLabel.Location = new System.Drawing.Point(138, 353);
            this.IsDeletedLabel.Name = "IsDeletedLabel";
            this.IsDeletedLabel.Size = new System.Drawing.Size(307, 55);
            this.IsDeletedLabel.TabIndex = 21;
            this.IsDeletedLabel.Text = "Account Active";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(327, 437);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 46);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(467, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Edit Tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1085, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NoRadioButton);
            this.Controls.Add(this.YesRadioButton);
            this.Controls.Add(this.EditUserButton);
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
            this.Controls.Add(this.IsDeletedLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button button1;
    }
}