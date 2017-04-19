namespace SoftCinema.Client.Forms.AdminForms
{
    partial class CinemasForm
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
            this.TownsList = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.CinemasList = new System.Windows.Forms.ComboBox();
            this.CinameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddCinemaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CinemaLabel
            // 
            this.CinemaLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.CinemaLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.CinemaLabel.Location = new System.Drawing.Point(45, 11);
            this.CinemaLabel.Name = "CinemaLabel";
            this.CinemaLabel.Size = new System.Drawing.Size(924, 70);
            this.CinemaLabel.TabIndex = 5;
            this.CinemaLabel.Text = "Select a Cinema to Edit";
            // 
            // TownsList
            // 
            this.TownsList.DropDownHeight = 100;
            this.TownsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TownsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TownsList.FormattingEnabled = true;
            this.TownsList.IntegralHeight = false;
            this.TownsList.Location = new System.Drawing.Point(380, 162);
            this.TownsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TownsList.Name = "TownsList";
            this.TownsList.Size = new System.Drawing.Size(393, 39);
            this.TownsList.TabIndex = 6;
            this.TownsList.SelectedIndexChanged += new System.EventHandler(this.TownsList_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.usernameLabel.Location = new System.Drawing.Point(157, 167);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(92, 37);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Town";
            // 
            // CinemasList
            // 
            this.CinemasList.DropDownHeight = 100;
            this.CinemasList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CinemasList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinemasList.FormattingEnabled = true;
            this.CinemasList.IntegralHeight = false;
            this.CinemasList.Location = new System.Drawing.Point(380, 238);
            this.CinemasList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CinemasList.Name = "CinemasList";
            this.CinemasList.Size = new System.Drawing.Size(393, 39);
            this.CinemasList.TabIndex = 8;
            this.CinemasList.SelectedIndexChanged += new System.EventHandler(this.CinemasList_SelectedIndexChanged);
            // 
            // CinameLabel
            // 
            this.CinameLabel.AutoSize = true;
            this.CinameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CinameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.CinameLabel.Location = new System.Drawing.Point(157, 242);
            this.CinameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CinameLabel.Name = "CinameLabel";
            this.CinameLabel.Size = new System.Drawing.Size(133, 37);
            this.CinameLabel.TabIndex = 9;
            this.CinameLabel.Text = "Cinema";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.Location = new System.Drawing.Point(449, 425);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(253, 38);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back to Admin Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddCinemaButton
            // 
            this.AddCinemaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCinemaButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddCinemaButton.Location = new System.Drawing.Point(431, 347);
            this.AddCinemaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCinemaButton.Name = "AddCinemaButton";
            this.AddCinemaButton.Size = new System.Drawing.Size(295, 57);
            this.AddCinemaButton.TabIndex = 11;
            this.AddCinemaButton.Text = "Add a New Cinema";
            this.AddCinemaButton.UseVisualStyleBackColor = true;
            this.AddCinemaButton.Click += new System.EventHandler(this.AddCinemaButton_Click);
            // 
            // CinemasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1021, 538);
            this.Controls.Add(this.AddCinemaButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CinameLabel);
            this.Controls.Add(this.CinemasList);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.TownsList);
            this.Controls.Add(this.CinemaLabel);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CinemasForm";
            this.Text = "CinemasForm";
            this.Load += new System.EventHandler(this.CinemasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CinemaLabel;
        private System.Windows.Forms.ComboBox TownsList;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ComboBox CinemasList;
        private System.Windows.Forms.Label CinameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddCinemaButton;
    }
}