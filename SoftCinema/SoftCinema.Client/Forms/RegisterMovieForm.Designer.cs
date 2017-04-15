namespace SoftCinema.Client.Forms
{
    partial class RegisterMovieForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ratingUpDown = new System.Windows.Forms.NumericUpDown();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.registerMovieButton = new System.Windows.Forms.Button();
            this.ageRestrictionComboBox = new System.Windows.Forms.ComboBox();
            this.ageRestrictionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(60, 63);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(132, 60);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ratingUpDown
            // 
            this.ratingUpDown.Location = new System.Drawing.Point(359, 56);
            this.ratingUpDown.Name = "ratingUpDown";
            this.ratingUpDown.Size = new System.Drawing.Size(120, 20);
            this.ratingUpDown.TabIndex = 3;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(284, 63);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(38, 13);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "Rating";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(284, 107);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(359, 100);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(120, 20);
            this.yearUpDown.TabIndex = 5;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Location = new System.Drawing.Point(132, 100);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.directorNameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Director Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Picture";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(317, 264);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 38);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(409, 264);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 38);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add Image only";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(509, 60);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(215, 261);
            this.pictureBoxPhoto.TabIndex = 12;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // registerMovieButton
            // 
            this.registerMovieButton.Location = new System.Drawing.Point(317, 348);
            this.registerMovieButton.Name = "registerMovieButton";
            this.registerMovieButton.Size = new System.Drawing.Size(174, 23);
            this.registerMovieButton.TabIndex = 13;
            this.registerMovieButton.Text = "Register Movie";
            this.registerMovieButton.UseVisualStyleBackColor = true;
            this.registerMovieButton.Click += new System.EventHandler(this.registerMovieButton_Click);
            // 
            // ageRestrictionComboBox
            // 
            this.ageRestrictionComboBox.FormattingEnabled = true;
            this.ageRestrictionComboBox.Location = new System.Drawing.Point(132, 151);
            this.ageRestrictionComboBox.Name = "ageRestrictionComboBox";
            this.ageRestrictionComboBox.Size = new System.Drawing.Size(121, 21);
            this.ageRestrictionComboBox.TabIndex = 14;
            this.ageRestrictionComboBox.SelectedIndexChanged += new System.EventHandler(this.ageRestrictionComboBox_SelectedIndexChanged);
            // 
            // ageRestrictionLabel
            // 
            this.ageRestrictionLabel.AutoSize = true;
            this.ageRestrictionLabel.Location = new System.Drawing.Point(20, 154);
            this.ageRestrictionLabel.Name = "ageRestrictionLabel";
            this.ageRestrictionLabel.Size = new System.Drawing.Size(79, 13);
            this.ageRestrictionLabel.TabIndex = 15;
            this.ageRestrictionLabel.Text = "Age Restriction";
            // 
            // RegisterMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.ageRestrictionLabel);
            this.Controls.Add(this.ageRestrictionComboBox);
            this.Controls.Add(this.registerMovieButton);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearUpDown);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingUpDown);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterMovieForm";
            this.Text = "RegisterMovieForm";
            ((System.ComponentModel.ISupportInitialize)(this.ratingUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown ratingUpDown;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown yearUpDown;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button registerMovieButton;
        private System.Windows.Forms.ComboBox ageRestrictionComboBox;
        private System.Windows.Forms.Label ageRestrictionLabel;
    }
}