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
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(189, 230);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email";
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
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(303, 77);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(173, 20);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(303, 127);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(173, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(303, 227);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(173, 20);
            this.emailTextBox.TabIndex = 8;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(303, 177);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(173, 20);
            this.repeatPasswordTextBox.TabIndex = 7;
            this.repeatPasswordTextBox.TextChanged += new System.EventHandler(this.repeatPasswordTextBox_TextChanged);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(303, 277);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(173, 20);
            this.phoneNumberTextBox.TabIndex = 9;
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.phoneNumberTextBox_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(335, 327);
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
            this.usernameInfoLabel.Location = new System.Drawing.Point(509, 84);
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
            this.passwordInfoLabel.Location = new System.Drawing.Point(509, 134);
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
            this.rptpasswordInfoLabel.Location = new System.Drawing.Point(509, 184);
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
            this.emailInfoLabel.Location = new System.Drawing.Point(509, 234);
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
            this.phoneInfoLabel.Location = new System.Drawing.Point(509, 284);
            this.phoneInfoLabel.Name = "phoneInfoLabel";
            this.phoneInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.phoneInfoLabel.TabIndex = 15;
            this.phoneInfoLabel.Text = "label1";
            this.phoneInfoLabel.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}