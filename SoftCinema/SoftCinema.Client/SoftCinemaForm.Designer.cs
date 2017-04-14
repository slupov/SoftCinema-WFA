using System.Reflection.Emit;

namespace SoftCinema.Client
{
    using SoftCinema.Client.Utilities.CustomTools;

    partial class SoftCinemaForm
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.teamButton5 = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.teamButton4 = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.teamButton3 = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.loginTeamButton = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.registerTeamButton = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            LogoutButton = new System.Windows.Forms.Button();
            GreetingLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ContentHolder = new System.Windows.Forms.Panel();
            this.BtnDashboard = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.SidePanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.SidePanel.Controls.Add(this.teamButton5);
            this.SidePanel.Controls.Add(this.teamButton4);
            this.SidePanel.Controls.Add(this.teamButton3);
            this.SidePanel.Controls.Add(this.loginTeamButton);
            this.SidePanel.Controls.Add(this.registerTeamButton);
            this.SidePanel.Controls.Add(this.NamePanel);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(195, 491);
            this.SidePanel.TabIndex = 0;
            // 
            // teamButton5
            // 
            this.teamButton5.BackColor = System.Drawing.Color.Black;
            this.teamButton5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.teamButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamButton5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamButton5.ForeColor = System.Drawing.Color.White;
            this.teamButton5.Location = new System.Drawing.Point(0, 301);
            this.teamButton5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamButton5.MinimumSize = new System.Drawing.Size(100, 30);
            this.teamButton5.Name = "teamButton5";
            this.teamButton5.Padding = new System.Windows.Forms.Padding(3);
            this.teamButton5.Size = new System.Drawing.Size(195, 57);
            this.teamButton5.TabIndex = 5;
            this.teamButton5.Text = "teamButton5";
            this.teamButton5.UseVisualStyleBackColor = false;
            // 
            // teamButton4
            // 
            this.teamButton4.BackColor = System.Drawing.Color.Black;
            this.teamButton4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.teamButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamButton4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamButton4.ForeColor = System.Drawing.Color.White;
            this.teamButton4.Location = new System.Drawing.Point(0, 244);
            this.teamButton4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamButton4.MinimumSize = new System.Drawing.Size(100, 30);
            this.teamButton4.Name = "teamButton4";
            this.teamButton4.Padding = new System.Windows.Forms.Padding(3);
            this.teamButton4.Size = new System.Drawing.Size(195, 57);
            this.teamButton4.TabIndex = 4;
            this.teamButton4.Text = "teamButton4";
            this.teamButton4.UseVisualStyleBackColor = false;
            // 
            // teamButton3
            // 
            this.teamButton3.BackColor = System.Drawing.Color.Black;
            this.teamButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.teamButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamButton3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamButton3.ForeColor = System.Drawing.Color.White;
            this.teamButton3.Location = new System.Drawing.Point(0, 187);
            this.teamButton3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.teamButton3.MinimumSize = new System.Drawing.Size(100, 30);
            this.teamButton3.Name = "teamButton3";
            this.teamButton3.Padding = new System.Windows.Forms.Padding(3);
            this.teamButton3.Size = new System.Drawing.Size(195, 57);
            this.teamButton3.TabIndex = 3;
            this.teamButton3.Text = "teamButton3";
            this.teamButton3.UseVisualStyleBackColor = false;
            // 
            // loginTeamButton
            // 
            this.loginTeamButton.BackColor = System.Drawing.Color.Black;
            this.loginTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.loginTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginTeamButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTeamButton.ForeColor = System.Drawing.Color.White;
            this.loginTeamButton.Location = new System.Drawing.Point(0, 130);
            this.loginTeamButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loginTeamButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.loginTeamButton.Name = "loginTeamButton";
            this.loginTeamButton.Padding = new System.Windows.Forms.Padding(3);
            this.loginTeamButton.Size = new System.Drawing.Size(195, 57);
            this.loginTeamButton.TabIndex = 2;
            this.loginTeamButton.Text = "Login";
            this.loginTeamButton.UseVisualStyleBackColor = false;
            this.loginTeamButton.Click += new System.EventHandler(this.loginTeamButton_Click);
            // 
            // registerTeamButton
            // 
            this.registerTeamButton.BackColor = System.Drawing.Color.Black;
            this.registerTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.registerTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerTeamButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTeamButton.ForeColor = System.Drawing.Color.White;
            this.registerTeamButton.Location = new System.Drawing.Point(0, 73);
            this.registerTeamButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerTeamButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.registerTeamButton.Name = "registerTeamButton";
            this.registerTeamButton.Padding = new System.Windows.Forms.Padding(3);
            this.registerTeamButton.Size = new System.Drawing.Size(195, 57);
            this.registerTeamButton.TabIndex = 1;
            this.registerTeamButton.Text = "Register";
            this.registerTeamButton.UseVisualStyleBackColor = false;
            this.registerTeamButton.Click += new System.EventHandler(this.registerTeamButton_Click);
            // 
            // NamePanel
            // 
            this.NamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(155)))), ((int)(((byte)(2)))));
            this.NamePanel.Controls.Add(this.Title);
            this.NamePanel.Location = new System.Drawing.Point(0, 0);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(195, 73);
            this.NamePanel.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(20, 20);
            this.Title.Name = "Title";
            this.Title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Title.Size = new System.Drawing.Size(151, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "SoftCinema";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpperPanel
            // 
            this.UpperPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.UpperPanel.BackColor = System.Drawing.Color.White;
            this.UpperPanel.Controls.Add(LogoutButton);
            this.UpperPanel.Controls.Add(GreetingLabel);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(195, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(769, 73);
            this.UpperPanel.TabIndex = 1;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new System.Drawing.Point(631, 44);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new System.Drawing.Size(75, 23);
            LogoutButton.TabIndex = 4;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Visible = false;
            LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // GreetingLabel
            // 
            GreetingLabel.AutoSize = true;
            GreetingLabel.Font = new System.Drawing.Font("Charlemagne Std", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            GreetingLabel.Location = new System.Drawing.Point(642, 26);
            GreetingLabel.Name = "GreetingLabel";
            GreetingLabel.Size = new System.Drawing.Size(55, 15);
            GreetingLabel.TabIndex = 3;
            GreetingLabel.Text = "label1";
            GreetingLabel.Visible = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ContentHolder
            // 
            this.ContentHolder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentHolder.Location = new System.Drawing.Point(195, 73);
            this.ContentHolder.Name = "ContentHolder";
            this.ContentHolder.Size = new System.Drawing.Size(769, 418);
            this.ContentHolder.TabIndex = 2;
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Black;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Location = new System.Drawing.Point(0, 0);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDashboard.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.BtnDashboard.Size = new System.Drawing.Size(100, 30);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            // 
            // SoftCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.ContentHolder);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "SoftCinemaForm";
            this.Text = "SoftCinemaForm";
            this.Load += new System.EventHandler(this.SoftCinemaForm_Load);
            this.SidePanel.ResumeLayout(false);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel ContentHolder;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label Title;

        //buttons 
        private TeamButton BtnDashboard;
        private TeamButton teamButton5;
        private TeamButton teamButton4;
        private TeamButton teamButton3;
        private TeamButton loginTeamButton;
        private TeamButton registerTeamButton;


        public static System.Windows.Forms.Label GetGreetingLabel()
        {
            return GreetingLabel;
        }

        private static System.Windows.Forms.Button LogoutButton;
        private static System.Windows.Forms.Label GreetingLabel;
    }
}

