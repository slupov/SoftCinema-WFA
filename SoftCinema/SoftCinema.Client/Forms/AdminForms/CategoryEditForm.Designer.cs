namespace SoftCinema.Client.Forms.AdminForms
{
    partial class CategoryEditForm
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.EditCategoryButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveMoviesLabel = new System.Windows.Forms.Label();
            this.AddMoviesLabel = new System.Windows.Forms.Label();
            this.CategoryNotAddedMovies = new System.Windows.Forms.ListBox();
            this.RemoveMoviesButton = new System.Windows.Forms.Button();
            this.AddMoviesButton = new System.Windows.Forms.Button();
            this.CategoryAddedMovies = new System.Windows.Forms.ListBox();
            this.CategoryExistsLabel = new System.Windows.Forms.Label();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CategoryLabel.Location = new System.Drawing.Point(358, 57);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(337, 55);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Edit Category:";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(343, 130);
            this.CategoryNameTextBox.Multiline = true;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CategoryNameTextBox.Size = new System.Drawing.Size(352, 41);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsernameLabel.Location = new System.Drawing.Point(49, 128);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(491, 55);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Category Name:";
            // 
            // EditCategoryButton
            // 
            this.EditCategoryButton.Location = new System.Drawing.Point(456, 462);
            this.EditCategoryButton.Name = "EditCategoryButton";
            this.EditCategoryButton.Size = new System.Drawing.Size(118, 45);
            this.EditCategoryButton.TabIndex = 18;
            this.EditCategoryButton.Text = "Save Changes";
            this.EditCategoryButton.UseVisualStyleBackColor = true;
            this.EditCategoryButton.Click += new System.EventHandler(this.EditCategoryButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(329, 462);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 45);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveMoviesLabel
            // 
            this.RemoveMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMoviesLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.RemoveMoviesLabel.Location = new System.Drawing.Point(49, 240);
            this.RemoveMoviesLabel.Name = "RemoveMoviesLabel";
            this.RemoveMoviesLabel.Size = new System.Drawing.Size(245, 278);
            this.RemoveMoviesLabel.TabIndex = 24;
            this.RemoveMoviesLabel.Text = "Movies in category:";
            // 
            // AddMoviesLabel
            // 
            this.AddMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMoviesLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddMoviesLabel.Location = new System.Drawing.Point(767, 240);
            this.AddMoviesLabel.Name = "AddMoviesLabel";
            this.AddMoviesLabel.Size = new System.Drawing.Size(256, 183);
            this.AddMoviesLabel.TabIndex = 25;
            this.AddMoviesLabel.Text = "Movies not in category:";
            // 
            // CategoryNotAddedMovies
            // 
            this.CategoryNotAddedMovies.FormattingEnabled = true;
            this.CategoryNotAddedMovies.HorizontalScrollbar = true;
            this.CategoryNotAddedMovies.ItemHeight = 16;
            this.CategoryNotAddedMovies.Location = new System.Drawing.Point(575, 227);
            this.CategoryNotAddedMovies.Name = "CategoryNotAddedMovies";
            this.CategoryNotAddedMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CategoryNotAddedMovies.Size = new System.Drawing.Size(186, 196);
            this.CategoryNotAddedMovies.TabIndex = 11;
            this.CategoryNotAddedMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CategoryNotAddedMovies_DoubleClick);
            // 
            // RemoveMoviesButton
            // 
            this.RemoveMoviesButton.Location = new System.Drawing.Point(475, 337);
            this.RemoveMoviesButton.Name = "RemoveMoviesButton";
            this.RemoveMoviesButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveMoviesButton.TabIndex = 27;
            this.RemoveMoviesButton.Text = ">>";
            this.RemoveMoviesButton.UseVisualStyleBackColor = true;
            this.RemoveMoviesButton.Click += new System.EventHandler(this.RemoveMoviesButton_Click);
            // 
            // AddMoviesButton
            // 
            this.AddMoviesButton.Location = new System.Drawing.Point(475, 267);
            this.AddMoviesButton.Name = "AddMoviesButton";
            this.AddMoviesButton.Size = new System.Drawing.Size(75, 23);
            this.AddMoviesButton.TabIndex = 26;
            this.AddMoviesButton.Text = "<<";
            this.AddMoviesButton.UseVisualStyleBackColor = true;
            this.AddMoviesButton.Click += new System.EventHandler(this.AddMoviesButton_Click);
            // 
            // CategoryAddedMovies
            // 
            this.CategoryAddedMovies.FormattingEnabled = true;
            this.CategoryAddedMovies.HorizontalScrollbar = true;
            this.CategoryAddedMovies.ItemHeight = 16;
            this.CategoryAddedMovies.Location = new System.Drawing.Point(257, 227);
            this.CategoryAddedMovies.Name = "CategoryAddedMovies";
            this.CategoryAddedMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CategoryAddedMovies.Size = new System.Drawing.Size(186, 196);
            this.CategoryAddedMovies.TabIndex = 10;
            this.CategoryAddedMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CategoryAddedMovies_DoubleClick);
            // 
            // CategoryExistsLabel
            // 
            this.CategoryExistsLabel.AutoSize = true;
            this.CategoryExistsLabel.Location = new System.Drawing.Point(725, 146);
            this.CategoryExistsLabel.Name = "CategoryExistsLabel";
            this.CategoryExistsLabel.Size = new System.Drawing.Size(158, 17);
            this.CategoryExistsLabel.TabIndex = 28;
            this.CategoryExistsLabel.Text = "Category already exists!";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Location = new System.Drawing.Point(594, 462);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(91, 45);
            this.DeleteCategoryButton.TabIndex = 29;
            this.DeleteCategoryButton.Text = "Delete Category";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // CategoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1049, 530);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.CategoryExistsLabel);
            this.Controls.Add(this.RemoveMoviesButton);
            this.Controls.Add(this.AddMoviesButton);
            this.Controls.Add(this.AddMoviesLabel);
            this.Controls.Add(this.CategoryAddedMovies);
            this.Controls.Add(this.RemoveMoviesLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditCategoryButton);
            this.Controls.Add(this.CategoryNotAddedMovies);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryEditForm";
            this.Text = "CategoryEditForm";
            this.Load += new System.EventHandler(this.CategoryEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button EditCategoryButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label RemoveMoviesLabel;
        private System.Windows.Forms.Label AddMoviesLabel;
        private System.Windows.Forms.ListBox CategoryNotAddedMovies;
        private System.Windows.Forms.Button RemoveMoviesButton;
        private System.Windows.Forms.Button AddMoviesButton;
        private System.Windows.Forms.ListBox CategoryAddedMovies;
        private System.Windows.Forms.Label CategoryExistsLabel;
        private System.Windows.Forms.Button DeleteCategoryButton;
    }
}