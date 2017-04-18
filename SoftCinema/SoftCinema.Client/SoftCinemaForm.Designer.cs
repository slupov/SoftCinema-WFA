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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ContentHolder = new System.Windows.Forms.Panel();
            this.BtnDashboard = new SoftCinema.Client.Utilities.CustomTools.TeamButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
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
          ContentHolder.BackColor = System.Drawing.SystemColors.ActiveBorder;
          ContentHolder.Location = new System.Drawing.Point(195, 73);
          ContentHolder.Name = "ContentHolder";
          ContentHolder.Size = new System.Drawing.Size(769, 418);
          ContentHolder.TabIndex = 2;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 73);
            this.panel1.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.titleLabel.Location = new System.Drawing.Point(5, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(151, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SoftCinema";
            // 
            // SoftCinemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(ContentHolder);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SoftCinemaForm";
            this.Text = "SoftCinemaForm";
            this.Load += new System.EventHandler(this.SoftCinemaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.MaximizeBox = false;
        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.IO.FileSystemWatcher fileSystemWatcher1;

        //buttons 
        private TeamButton BtnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;
        public static System.Windows.Forms.Panel ContentHolder;
    }
}

