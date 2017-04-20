namespace SoftCinema.Client.Forms.AdminForms
{
    partial class AdminMenuForm
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
            this.UserEditButton = new System.Windows.Forms.Button();
            this.EditCategoriesButton = new System.Windows.Forms.Button();
            this.EditCinemasButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.EditMoviesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserEditButton
            // 
            this.UserEditButton.BackColor = System.Drawing.SystemColors.Menu;
            this.UserEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEditButton.Location = new System.Drawing.Point(377, 146);
            this.UserEditButton.Name = "UserEditButton";
            this.UserEditButton.Size = new System.Drawing.Size(214, 58);
            this.UserEditButton.TabIndex = 2;
            this.UserEditButton.Text = "Edit Users";
            this.UserEditButton.UseVisualStyleBackColor = false;
            this.UserEditButton.Click += new System.EventHandler(this.UserEditButton_Click);
            // 
            // EditCategoriesButton
            // 
            this.EditCategoriesButton.BackColor = System.Drawing.SystemColors.Menu;
            this.EditCategoriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCategoriesButton.Location = new System.Drawing.Point(377, 300);
            this.EditCategoriesButton.Name = "EditCategoriesButton";
            this.EditCategoriesButton.Size = new System.Drawing.Size(214, 58);
            this.EditCategoriesButton.TabIndex = 4;
            this.EditCategoriesButton.Text = "Edit Categories";
            this.EditCategoriesButton.UseVisualStyleBackColor = false;
            this.EditCategoriesButton.Click += new System.EventHandler(this.EditCategoriesButton_Click);
            // 
            // EditCinemasButton
            // 
            this.EditCinemasButton.BackColor = System.Drawing.SystemColors.Menu;
            this.EditCinemasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCinemasButton.Location = new System.Drawing.Point(377, 223);
            this.EditCinemasButton.Name = "EditCinemasButton";
            this.EditCinemasButton.Size = new System.Drawing.Size(214, 58);
            this.EditCinemasButton.TabIndex = 5;
            this.EditCinemasButton.Text = "Edit Cinemas";
            this.EditCinemasButton.UseVisualStyleBackColor = false;
            this.EditCinemasButton.Click += new System.EventHandler(this.EditCinemasButton_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.MenuLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.MenuLabel.Location = new System.Drawing.Point(41, 38);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(856, 70);
            this.MenuLabel.TabIndex = 9;
            this.MenuLabel.Text = "Admin Menu";
            this.MenuLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // EditMoviesButton
            // 
            this.EditMoviesButton.BackColor = System.Drawing.SystemColors.Menu;
            this.EditMoviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditMoviesButton.Location = new System.Drawing.Point(377, 386);
            this.EditMoviesButton.Name = "EditMoviesButton";
            this.EditMoviesButton.Size = new System.Drawing.Size(214, 58);
            this.EditMoviesButton.TabIndex = 10;
            this.EditMoviesButton.Text = "Edit Movies";
            this.EditMoviesButton.UseVisualStyleBackColor = false;
            this.EditMoviesButton.Click += new System.EventHandler(this.EditMoviesButton_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1041, 512);
            this.Controls.Add(this.EditMoviesButton);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.EditCinemasButton);
            this.Controls.Add(this.EditCategoriesButton);
            this.Controls.Add(this.UserEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenuForm";
            this.Text = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button UserEditButton;
        private System.Windows.Forms.Button EditCategoriesButton;
        private System.Windows.Forms.Button EditCinemasButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button EditMoviesButton;
    }
}