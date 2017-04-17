namespace SoftCinema.Client.Forms.AdminForms
{
    partial class CreateCategoryForm
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
            this.CategoryNameLabel = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.MoviesLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CreateCategoryButton = new System.Windows.Forms.Button();
            this.MoviesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CategoryExistsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CategoryLabel.Location = new System.Drawing.Point(338, 44);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(337, 55);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Create Category:";
            // 
            // CategoryNameLabel
            // 
            this.CategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryNameLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CategoryNameLabel.Location = new System.Drawing.Point(56, 116);
            this.CategoryNameLabel.Name = "CategoryNameLabel";
            this.CategoryNameLabel.Size = new System.Drawing.Size(491, 55);
            this.CategoryNameLabel.TabIndex = 10;
            this.CategoryNameLabel.Text = "Category Name:";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameTextBox.Location = new System.Drawing.Point(345, 118);
            this.CategoryNameTextBox.Multiline = true;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CategoryNameTextBox.Size = new System.Drawing.Size(352, 41);
            this.CategoryNameTextBox.TabIndex = 11;
            this.CategoryNameTextBox.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);
            // 
            // MoviesLabel
            // 
            this.MoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoviesLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.MoviesLabel.Location = new System.Drawing.Point(145, 238);
            this.MoviesLabel.Name = "MoviesLabel";
            this.MoviesLabel.Size = new System.Drawing.Size(245, 278);
            this.MoviesLabel.TabIndex = 25;
            this.MoviesLabel.Text = "Movies in category:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(377, 435);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(98, 45);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateCategoryButton
            // 
            this.CreateCategoryButton.Location = new System.Drawing.Point(513, 435);
            this.CreateCategoryButton.Name = "CreateCategoryButton";
            this.CreateCategoryButton.Size = new System.Drawing.Size(118, 45);
            this.CreateCategoryButton.TabIndex = 27;
            this.CreateCategoryButton.Text = "Create Category";
            this.CreateCategoryButton.UseVisualStyleBackColor = true;
            this.CreateCategoryButton.Click += new System.EventHandler(this.CreateCategoryButton_Click);
            // 
            // MoviesCheckedListBox
            // 
            this.MoviesCheckedListBox.FormattingEnabled = true;
            this.MoviesCheckedListBox.Location = new System.Drawing.Point(343, 207);
            this.MoviesCheckedListBox.Name = "MoviesCheckedListBox";
            this.MoviesCheckedListBox.Size = new System.Drawing.Size(354, 191);
            this.MoviesCheckedListBox.TabIndex = 28;
            // 
            // CategoryExistsLabel
            // 
            this.CategoryExistsLabel.AutoSize = true;
            this.CategoryExistsLabel.Location = new System.Drawing.Point(721, 134);
            this.CategoryExistsLabel.Name = "CategoryExistsLabel";
            this.CategoryExistsLabel.Size = new System.Drawing.Size(158, 17);
            this.CategoryExistsLabel.TabIndex = 29;
            this.CategoryExistsLabel.Text = "Category already exists!";
            // 
            // CreateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1004, 513);
            this.Controls.Add(this.CategoryExistsLabel);
            this.Controls.Add(this.MoviesCheckedListBox);
            this.Controls.Add(this.CreateCategoryButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MoviesLabel);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.CategoryNameLabel);
            this.Controls.Add(this.CategoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateCategoryForm";
            this.Text = "CreateCategoryForm";
            this.Load += new System.EventHandler(this.CreateCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CategoryNameLabel;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label MoviesLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateCategoryButton;
        private System.Windows.Forms.CheckedListBox MoviesCheckedListBox;
        private System.Windows.Forms.Label CategoryExistsLabel;
    }
}