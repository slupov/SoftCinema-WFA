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
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.CategoryLabel.Location = new System.Drawing.Point(34, 9);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(368, 74);
            this.CategoryLabel.TabIndex = 5;
            this.CategoryLabel.Text = "Edit Category";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(347, 105);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryNameTextBox.Multiline = true;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CategoryNameTextBox.Size = new System.Drawing.Size(265, 34);
            this.CategoryNameTextBox.TabIndex = 8;
            this.CategoryNameTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.UsernameLabel.Location = new System.Drawing.Point(156, 104);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(143, 36);
            this.UsernameLabel.TabIndex = 9;
            this.UsernameLabel.Text = "Category Name:";
            // 
            // EditCategoryButton
            // 
            this.EditCategoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditCategoryButton.Location = new System.Drawing.Point(315, 375);
            this.EditCategoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditCategoryButton.Name = "EditCategoryButton";
            this.EditCategoryButton.Size = new System.Drawing.Size(115, 37);
            this.EditCategoryButton.TabIndex = 18;
            this.EditCategoryButton.Text = "Save Changes";
            this.EditCategoryButton.UseVisualStyleBackColor = true;
            this.EditCategoryButton.Click += new System.EventHandler(this.EditCategoryButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(225, 375);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(74, 37);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveMoviesLabel
            // 
            this.RemoveMoviesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMoviesLabel.ForeColor = System.Drawing.Color.LightGray;
            this.RemoveMoviesLabel.Location = new System.Drawing.Point(147, 178);
            this.RemoveMoviesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RemoveMoviesLabel.Name = "RemoveMoviesLabel";
            this.RemoveMoviesLabel.Size = new System.Drawing.Size(174, 23);
            this.RemoveMoviesLabel.TabIndex = 24;
            this.RemoveMoviesLabel.Text = "Movies in category:";
            // 
            // AddMoviesLabel
            // 
            this.AddMoviesLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMoviesLabel.ForeColor = System.Drawing.Color.LightGray;
            this.AddMoviesLabel.Location = new System.Drawing.Point(447, 178);
            this.AddMoviesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddMoviesLabel.Name = "AddMoviesLabel";
            this.AddMoviesLabel.Size = new System.Drawing.Size(201, 26);
            this.AddMoviesLabel.TabIndex = 25;
            this.AddMoviesLabel.Text = "Movies not in category:";
            // 
            // CategoryNotAddedMovies
            // 
            this.CategoryNotAddedMovies.FormattingEnabled = true;
            this.CategoryNotAddedMovies.HorizontalScrollbar = true;
            this.CategoryNotAddedMovies.Location = new System.Drawing.Point(451, 206);
            this.CategoryNotAddedMovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryNotAddedMovies.Name = "CategoryNotAddedMovies";
            this.CategoryNotAddedMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CategoryNotAddedMovies.Size = new System.Drawing.Size(173, 147);
            this.CategoryNotAddedMovies.TabIndex = 11;
            this.CategoryNotAddedMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CategoryNotAddedMovies_DoubleClick);
            // 
            // RemoveMoviesButton
            // 
            this.RemoveMoviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMoviesButton.Location = new System.Drawing.Point(356, 292);
            this.RemoveMoviesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveMoviesButton.Name = "RemoveMoviesButton";
            this.RemoveMoviesButton.Size = new System.Drawing.Size(56, 25);
            this.RemoveMoviesButton.TabIndex = 27;
            this.RemoveMoviesButton.Text = ">>";
            this.RemoveMoviesButton.UseVisualStyleBackColor = true;
            this.RemoveMoviesButton.Click += new System.EventHandler(this.RemoveMoviesButton_Click);
            // 
            // AddMoviesButton
            // 
            this.AddMoviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMoviesButton.Location = new System.Drawing.Point(356, 248);
            this.AddMoviesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddMoviesButton.Name = "AddMoviesButton";
            this.AddMoviesButton.Size = new System.Drawing.Size(56, 25);
            this.AddMoviesButton.TabIndex = 26;
            this.AddMoviesButton.Text = "<<";
            this.AddMoviesButton.UseVisualStyleBackColor = true;
            this.AddMoviesButton.Click += new System.EventHandler(this.AddMoviesButton_Click);
            // 
            // CategoryAddedMovies
            // 
            this.CategoryAddedMovies.FormattingEnabled = true;
            this.CategoryAddedMovies.HorizontalScrollbar = true;
            this.CategoryAddedMovies.Location = new System.Drawing.Point(148, 206);
            this.CategoryAddedMovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryAddedMovies.Name = "CategoryAddedMovies";
            this.CategoryAddedMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.CategoryAddedMovies.Size = new System.Drawing.Size(173, 147);
            this.CategoryAddedMovies.TabIndex = 10;
            this.CategoryAddedMovies.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CategoryAddedMovies_DoubleClick);
            // 
            // CategoryExistsLabel
            // 
            this.CategoryExistsLabel.AutoSize = true;
            this.CategoryExistsLabel.ForeColor = System.Drawing.Color.Red;
            this.CategoryExistsLabel.Location = new System.Drawing.Point(344, 90);
            this.CategoryExistsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryExistsLabel.Name = "CategoryExistsLabel";
            this.CategoryExistsLabel.Size = new System.Drawing.Size(118, 13);
            this.CategoryExistsLabel.TabIndex = 28;
            this.CategoryExistsLabel.Text = "Category already exists!";
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCategoryButton.Location = new System.Drawing.Point(437, 375);
            this.DeleteCategoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(134, 37);
            this.DeleteCategoryButton.TabIndex = 29;
            this.DeleteCategoryButton.Text = "Delete Category";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // CategoryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(787, 431);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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