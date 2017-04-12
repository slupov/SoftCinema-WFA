namespace SoftCinema.Client.Forms
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.userExists = new System.Windows.Forms.Label();
            this.wrongFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(189, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(189, 130);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(189, 180);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(90, 13);
            this.repeatPasswordLabel.TabIndex = 2;
            this.repeatPasswordLabel.Text = "Repeat password";
            this.repeatPasswordLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(189, 230);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
            this.emailLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneNumberLabel.Location = new System.Drawing.Point(189, 280);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.phoneNumberLabel.TabIndex = 4;
            this.phoneNumberLabel.Text = "Phone number";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(303, 77);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(173, 20);
            this.username.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(303, 127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(173, 20);
            this.password.TabIndex = 6;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(303, 227);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(173, 20);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // repeatPassword
            // 
            this.repeatPassword.Location = new System.Drawing.Point(303, 177);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(173, 20);
            this.repeatPassword.TabIndex = 8;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(303, 277);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(173, 20);
            this.phoneNumber.TabIndex = 9;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(335, 327);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(108, 40);
            this.register.TabIndex = 10;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            // 
            // userExists
            // 
            this.userExists.AutoSize = true;
            this.userExists.Location = new System.Drawing.Point(495, 77);
            this.userExists.Name = "userExists";
            this.userExists.Size = new System.Drawing.Size(145, 13);
            this.userExists.TabIndex = 11;
            this.userExists.Text = "This username already exists.";
            this.userExists.Visible = false;
            // 
            // wrongFormat
            // 
            this.wrongFormat.AutoSize = true;
            this.wrongFormat.Location = new System.Drawing.Point(495, 80);
            this.wrongFormat.Name = "wrongFormat";
            this.wrongFormat.Size = new System.Drawing.Size(183, 13);
            this.wrongFormat.TabIndex = 12;
            this.wrongFormat.Text = "Username is not in the correct format.";
            this.wrongFormat.Visible = false;
            this.wrongFormat.Click += new System.EventHandler(this.wrongFormat_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.wrongFormat);
            this.Controls.Add(this.userExists);
            this.Controls.Add(this.register);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox repeatPassword;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label userExists;
        private System.Windows.Forms.Label wrongFormat;
    }
}