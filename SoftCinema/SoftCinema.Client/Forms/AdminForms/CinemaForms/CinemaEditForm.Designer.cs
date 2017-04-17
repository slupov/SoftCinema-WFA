namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    partial class CinemaEditForm
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
            this.CinemaLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.CinameLabel = new System.Windows.Forms.Label();
            this.TownName = new System.Windows.Forms.TextBox();
            this.CinemaName = new System.Windows.Forms.TextBox();
            this.CinemaExistsLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.EditCinemaButton = new System.Windows.Forms.Button();
            this.DeleteCinemaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CinemaLabel
            // 
            this.CinemaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.CinemaLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.CinemaLabel.Location = new System.Drawing.Point(256, 24);
            this.CinemaLabel.Name = "CinemaLabel";
            this.CinemaLabel.Size = new System.Drawing.Size(924, 70);
            this.CinemaLabel.TabIndex = 6;
            this.CinemaLabel.Text = "Edit Cinema:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.usernameLabel.Location = new System.Drawing.Point(234, 139);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(91, 33);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Town:";
            // 
            // CinameLabel
            // 
            this.CinameLabel.AutoSize = true;
            this.CinameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.CinameLabel.Location = new System.Drawing.Point(108, 199);
            this.CinameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CinameLabel.Name = "CinameLabel";
            this.CinameLabel.Size = new System.Drawing.Size(217, 33);
            this.CinameLabel.TabIndex = 10;
            this.CinameLabel.Text = "Cinema Name:";
            // 
            // TownName
            // 
            this.TownName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TownName.Location = new System.Drawing.Point(332, 137);
            this.TownName.Multiline = true;
            this.TownName.Name = "TownName";
            this.TownName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TownName.Size = new System.Drawing.Size(352, 41);
            this.TownName.TabIndex = 12;
            this.TownName.TextChanged += new System.EventHandler(this.TownCinemaName_TextChanged);
            // 
            // CinemaName
            // 
            this.CinemaName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CinemaName.Location = new System.Drawing.Point(332, 199);
            this.CinemaName.Multiline = true;
            this.CinemaName.Name = "CinemaName";
            this.CinemaName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CinemaName.Size = new System.Drawing.Size(352, 41);
            this.CinemaName.TabIndex = 13;
            this.CinemaName.TextChanged += new System.EventHandler(this.TownCinemaName_TextChanged);
            // 
            // CinemaExistsLabel
            // 
            this.CinemaExistsLabel.AutoSize = true;
            this.CinemaExistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemaExistsLabel.ForeColor = System.Drawing.Color.Red;
            this.CinemaExistsLabel.Location = new System.Drawing.Point(392, 257);
            this.CinemaExistsLabel.Name = "CinemaExistsLabel";
            this.CinemaExistsLabel.Size = new System.Drawing.Size(210, 25);
            this.CinemaExistsLabel.TabIndex = 30;
            this.CinemaExistsLabel.Text = "Cinema already exists!";
            // 
            // BackButton
            // 
            this.BackButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BackButton.Location = new System.Drawing.Point(311, 398);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 45);
            this.BackButton.TabIndex = 31;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditCinemaButton
            // 
            this.EditCinemaButton.Location = new System.Drawing.Point(430, 398);
            this.EditCinemaButton.Name = "EditCinemaButton";
            this.EditCinemaButton.Size = new System.Drawing.Size(152, 45);
            this.EditCinemaButton.TabIndex = 32;
            this.EditCinemaButton.Text = "SaveChanges";
            this.EditCinemaButton.UseVisualStyleBackColor = true;
            this.EditCinemaButton.Click += new System.EventHandler(this.EditCinemaButton_Click);
            // 
            // DeleteCinemaButton
            // 
            this.DeleteCinemaButton.Location = new System.Drawing.Point(602, 398);
            this.DeleteCinemaButton.Name = "DeleteCinemaButton";
            this.DeleteCinemaButton.Size = new System.Drawing.Size(91, 45);
            this.DeleteCinemaButton.TabIndex = 33;
            this.DeleteCinemaButton.Text = "Delete Cinema";
            this.DeleteCinemaButton.UseVisualStyleBackColor = true;
            this.DeleteCinemaButton.Click += new System.EventHandler(this.DeleteCinemaButton_Click);
            // 
            // CinemaEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1101, 549);
            this.Controls.Add(this.DeleteCinemaButton);
            this.Controls.Add(this.EditCinemaButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CinemaExistsLabel);
            this.Controls.Add(this.CinemaName);
            this.Controls.Add(this.TownName);
            this.Controls.Add(this.CinameLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.CinemaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CinemaEditForm";
            this.Text = "CinemaEditForm";
            this.Load += new System.EventHandler(this.CinemaEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CinemaLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label CinameLabel;
        private System.Windows.Forms.TextBox TownName;
        private System.Windows.Forms.TextBox CinemaName;
        private System.Windows.Forms.Label CinemaExistsLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EditCinemaButton;
        private System.Windows.Forms.Button DeleteCinemaButton;
    }
}