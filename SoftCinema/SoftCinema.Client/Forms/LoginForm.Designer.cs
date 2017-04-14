namespace SoftCinema.Client.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.usernameInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(223, 110);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(223, 160);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(326, 107);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(173, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(326, 157);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(173, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(326, 256);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(113, 39);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.AutoSize = true;
            this.loginInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.loginInfoLabel.Location = new System.Drawing.Point(323, 212);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.loginInfoLabel.TabIndex = 12;
            this.loginInfoLabel.Text = "label1";
            this.loginInfoLabel.Visible = false;
            // 
            // usernameInfoLabel
            // 
            this.usernameInfoLabel.AutoSize = true;
            this.usernameInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameInfoLabel.Location = new System.Drawing.Point(529, 114);
            this.usernameInfoLabel.Name = "usernameInfoLabel";
            this.usernameInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameInfoLabel.TabIndex = 13;
            this.usernameInfoLabel.Text = "label1";
            this.usernameInfoLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.usernameInfoLabel);
            this.Controls.Add(this.loginInfoLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loginInfoLabel;
        private System.Windows.Forms.Label usernameInfoLabel;
    }
}