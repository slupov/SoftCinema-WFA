using System.Drawing;
using SoftCinema.Models;
using SoftCinema.Services;
using Image = System.Drawing.Image;

namespace SoftCinema.Client.Forms
{
    partial class TopPanelForm
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
            LogoutButton = new System.Windows.Forms.Button();
            GreetingLabel = new System.Windows.Forms.Label();
            profilePicPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(profilePicPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = System.Drawing.Color.Silver;
            LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LogoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LogoutButton.ForeColor = System.Drawing.SystemColors.Desktop;
            LogoutButton.Location = new System.Drawing.Point(660, 19);
            LogoutButton.Margin = new System.Windows.Forms.Padding(0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new System.Drawing.Size(90, 34);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Visible = false;
            LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // GreetingLabel
            // 
            GreetingLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GreetingLabel.Location = new System.Drawing.Point(242, 23);
            GreetingLabel.Margin = new System.Windows.Forms.Padding(3, 5, 5, 0);
            GreetingLabel.Name = "GreetingLabel";
            GreetingLabel.Size = new System.Drawing.Size(340, 25);
            GreetingLabel.TabIndex = 5;
            GreetingLabel.Text = "label1";
            GreetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            GreetingLabel.Visible = false;
            // 
            // profilePicPictureBox
            // 
            profilePicPictureBox.Location = new System.Drawing.Point(410, 12);
            profilePicPictureBox.Name = "profilePicPictureBox";
            profilePicPictureBox.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            profilePicPictureBox.Size = new System.Drawing.Size(55, 54);
            profilePicPictureBox.TabIndex = 7;
            profilePicPictureBox.TabStop = false;
            // 
            // TopPanelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(769, 73);
            this.Controls.Add(profilePicPictureBox);
            this.Controls.Add(LogoutButton);
            this.Controls.Add(GreetingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TopPanelForm";
            this.Text = "TopPanelForm";
            this.Load += new System.EventHandler(this.TopPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(profilePicPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private static System.Windows.Forms.PictureBox profilePicPictureBox;
        public static System.Windows.Forms.Button LogoutButton;
        private static System.Windows.Forms.Label GreetingLabel;
    }
}