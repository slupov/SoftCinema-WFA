namespace SoftCinema.Client.Forms.AdminForms
{
    partial class CategoriesForm
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
            this.CategoriesList = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.seatButton1 = new SoftCinema.Client.Utilities.CustomTools.SeatButton();
            this.SuspendLayout();
            // 
            // CategoriesList
            // 
            this.CategoriesList.DropDownHeight = 100;
            this.CategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.IntegralHeight = false;
            this.CategoriesList.Location = new System.Drawing.Point(300, 154);
            this.CategoriesList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(393, 39);
            this.CategoriesList.TabIndex = 0;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.CategoryLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.CategoryLabel.Location = new System.Drawing.Point(45, 11);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(924, 70);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Select a Category to Edit:";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(347, 369);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(301, 38);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back to Admin Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCategoryButton.Location = new System.Drawing.Point(347, 284);
            this.AddCategoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(301, 57);
            this.AddCategoryButton.TabIndex = 7;
            this.AddCategoryButton.Text = "Add a New Category";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // seatButton1
            // 
            this.seatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.seatButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(172)))), ((int)(((byte)(73)))));
            this.seatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seatButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatButton1.ForeColor = System.Drawing.Color.White;
            this.seatButton1.Location = new System.Drawing.Point(554, 305);
            this.seatButton1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.seatButton1.MinimumSize = new System.Drawing.Size(10, 10);
            this.seatButton1.Name = "seatButton1";
            this.seatButton1.Number = 0;
            this.seatButton1.Padding = new System.Windows.Forms.Padding(3);
            this.seatButton1.Row = 0;
            this.seatButton1.Size = new System.Drawing.Size(10, 10);
            this.seatButton1.TabIndex = 8;
            this.seatButton1.Text = "seatButton1";
            this.seatButton1.UseVisualStyleBackColor = false;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1037, 521);
            this.Controls.Add(this.seatButton1);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesList;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddCategoryButton;
        private Client.Utilities.CustomTools.SeatButton seatButton1;
    }
}