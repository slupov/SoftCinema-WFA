namespace SoftCinema.Client.Forms.ContentHolders
{
    partial class RegisterForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameInfoLabel = new System.Windows.Forms.Label();
            this.passwordInfoLabel = new System.Windows.Forms.Label();
            this.rptpasswordInfoLabel = new System.Windows.Forms.Label();
            this.emailInfoLabel = new System.Windows.Forms.Label();
            this.phoneInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.usernameLabel.Location = new System.Drawing.Point(119, 115);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(113, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.ForeColor = System.Drawing.Color.LightGray;
            this.passwordLabel.Location = new System.Drawing.Point(119, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordLabel.ForeColor = System.Drawing.Color.LightGray;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(119, 205);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(188, 24);
            this.repeatPasswordLabel.TabIndex = 2;
            this.repeatPasswordLabel.Text = "Repeat password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.LightGray;
            this.emailLabel.Location = new System.Drawing.Point(119, 250);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 24);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.LightGray;
            this.phoneNumberLabel.Location = new System.Drawing.Point(119, 295);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(163, 24);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Phone number";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(335, 113);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(173, 26);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(335, 158);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(173, 26);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(335, 248);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(173, 26);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(335, 203);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(173, 26);
            this.repeatPasswordTextBox.TabIndex = 7;
            this.repeatPasswordTextBox.TextChanged += new System.EventHandler(this.repeatPasswordTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(335, 293);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(173, 26);
            this.phoneNumberTextBox.TabIndex = 9;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(368, 345);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(108, 40);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // usernameInfoLabel
            // 
            this.usernameInfoLabel.AutoSize = true;
            this.usernameInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameInfoLabel.Location = new System.Drawing.Point(332, 97);
            this.usernameInfoLabel.Name = "usernameInfoLabel";
            this.usernameInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameInfoLabel.TabIndex = 11;
            this.usernameInfoLabel.Text = "label1";
            this.usernameInfoLabel.Visible = false;
            // 
            // passwordInfoLabel
            // 
            this.passwordInfoLabel.AutoSize = true;
            this.passwordInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordInfoLabel.Location = new System.Drawing.Point(332, 140);
            this.passwordInfoLabel.Name = "passwordInfoLabel";
            this.passwordInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.passwordInfoLabel.TabIndex = 12;
            this.passwordInfoLabel.Text = "label1";
            this.passwordInfoLabel.Visible = false;
            // 
            // rptpasswordInfoLabel
            // 
            this.rptpasswordInfoLabel.AutoSize = true;
            this.rptpasswordInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.rptpasswordInfoLabel.Location = new System.Drawing.Point(332, 183);
            this.rptpasswordInfoLabel.Name = "rptpasswordInfoLabel";
            this.rptpasswordInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.rptpasswordInfoLabel.TabIndex = 13;
            this.rptpasswordInfoLabel.Text = "label1";
            this.rptpasswordInfoLabel.Visible = false;
            // 
            // emailInfoLabel
            // 
            this.emailInfoLabel.AutoSize = true;
            this.emailInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.emailInfoLabel.Location = new System.Drawing.Point(332, 228);
            this.emailInfoLabel.Name = "emailInfoLabel";
            this.emailInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.emailInfoLabel.TabIndex = 14;
            this.emailInfoLabel.Text = "label1";
            this.emailInfoLabel.Visible = false;
            // 
            // phoneInfoLabel
            // 
            this.phoneInfoLabel.AutoSize = true;
            this.phoneInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneInfoLabel.Location = new System.Drawing.Point(332, 273);
            this.phoneInfoLabel.Name = "phoneInfoLabel";
            this.phoneInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.phoneInfoLabel.TabIndex = 15;
            this.phoneInfoLabel.Text = "label1";
            this.phoneInfoLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 57);
            this.label1.TabIndex = 16;
            this.label1.Text = "Register";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(578, 113);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(138, 161);
            this.profilePictureBox.TabIndex = 17;
            this.profilePictureBox.TabStop = false;
            // 
            // profilePictureLabel
            // 
            this.profilePictureLabel.AutoSize = true;
            this.profilePictureLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilePictureLabel.ForeColor = System.Drawing.Color.LightGray;
            this.profilePictureLabel.Location = new System.Drawing.Point(574, 65);
            this.profilePictureLabel.Name = "profilePictureLabel";
            this.profilePictureLabel.Size = new System.Drawing.Size(148, 24);
            this.profilePictureLabel.TabIndex = 18;
            this.profilePictureLabel.Text = "Profile picture";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseButton.Location = new System.Drawing.Point(578, 288);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(79, 31);
            this.browseButton.TabIndex = 19;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.profilePictureLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneInfoLabel);
            this.Controls.Add(this.emailInfoLabel);
            this.Controls.Add(this.rptpasswordInfoLabel);
            this.Controls.Add(this.passwordInfoLabel);
            this.Controls.Add(this.usernameInfoLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label usernameInfoLabel;
        private System.Windows.Forms.Label passwordInfoLabel;
        private System.Windows.Forms.Label rptpasswordInfoLabel;
        private System.Windows.Forms.Label emailInfoLabel;
        private System.Windows.Forms.Label phoneInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label profilePictureLabel;
        private System.Windows.Forms.Button browseButton;
    }
}