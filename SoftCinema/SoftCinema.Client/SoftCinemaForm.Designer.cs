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
            this.registerMovie = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.buyTicketsTeamButton = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.loginTeamButton = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.registerTeamButton = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.NamePanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ContentHolder = new System.Windows.Forms.Panel();
            this.BtnDashboard = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.SidePanel.SuspendLayout();
            this.NamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.SidePanel.Controls.Add(this.teamButton5);
            this.SidePanel.Controls.Add(this.registerMovie);
            this.SidePanel.Controls.Add(this.buyTicketsTeamButton);
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
            // registerMovie
            // 
            this.registerMovie.BackColor = System.Drawing.Color.Black;
            this.registerMovie.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.registerMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerMovie.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerMovie.ForeColor = System.Drawing.Color.White;
            this.registerMovie.Location = new System.Drawing.Point(0, 244);
            this.registerMovie.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.registerMovie.MinimumSize = new System.Drawing.Size(100, 30);
            this.registerMovie.Name = "registerMovie";
            this.registerMovie.Padding = new System.Windows.Forms.Padding(3);
            this.registerMovie.Size = new System.Drawing.Size(195, 57);
            this.registerMovie.TabIndex = 4;
            this.registerMovie.Text = "Register movie";
            this.registerMovie.UseVisualStyleBackColor = false;
            this.registerMovie.Click += new System.EventHandler(this.registerMovie_Click);
            // 
            // buyTicketsTeamButton
            // 
            this.buyTicketsTeamButton.BackColor = System.Drawing.Color.Black;
            this.buyTicketsTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buyTicketsTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyTicketsTeamButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyTicketsTeamButton.ForeColor = System.Drawing.Color.White;
            this.buyTicketsTeamButton.Location = new System.Drawing.Point(0, 187);
            this.buyTicketsTeamButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buyTicketsTeamButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.buyTicketsTeamButton.Name = "buyTicketsTeamButton";
            this.buyTicketsTeamButton.Padding = new System.Windows.Forms.Padding(3);
            this.buyTicketsTeamButton.Size = new System.Drawing.Size(195, 57);
            this.buyTicketsTeamButton.TabIndex = 3;
            this.buyTicketsTeamButton.Text = "Buy tickets";
            this.buyTicketsTeamButton.UseVisualStyleBackColor = false;
            this.buyTicketsTeamButton.Click += new System.EventHandler(this.buyTicketsTeamButton_Click);
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
            // TopPanel
            // 
            this.TopPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(195, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(769, 73);
            this.TopPanel.TabIndex = 1;
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
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Name = "SoftCinemaForm";
            this.Text = "SoftCinemaForm";
            this.Load += new System.EventHandler(this.SoftCinemaForm_Load);
            this.SidePanel.ResumeLayout(false);
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.Panel ContentHolder;
        private System.Windows.Forms.Panel NamePanel;
        private System.Windows.Forms.Label Title;

        //buttons 
        private TeamButton BtnDashboard;
        private TeamButton teamButton5;
        private TeamButton registerMovie;
        private TeamButton buyTicketsTeamButton;
        private TeamButton loginTeamButton;
        private TeamButton registerTeamButton;
      
    }
}

