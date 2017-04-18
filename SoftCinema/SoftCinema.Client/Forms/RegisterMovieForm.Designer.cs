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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ratingUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.LightGray;
            this.nameLabel.Location = new System.Drawing.Point(91, 106);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(75, 24);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(293, 106);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(120, 24);
            this.nameTextBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ratingUpDown
            // 
            this.ratingUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingUpDown.Location = new System.Drawing.Point(293, 234);
            this.ratingUpDown.Name = "ratingUpDown";
            this.ratingUpDown.Size = new System.Drawing.Size(120, 24);
            this.ratingUpDown.TabIndex = 3;
            this.ratingUpDown.ValueChanged += new System.EventHandler(this.ratingUpDown_ValueChanged);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ratingLabel.Location = new System.Drawing.Point(91, 234);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(74, 24);
            this.ratingLabel.TabIndex = 4;
            this.ratingLabel.Text = "Rating";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.ForeColor = System.Drawing.Color.LightGray;
            this.yearLabel.Location = new System.Drawing.Point(91, 276);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(57, 24);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year";
            // 
            // yearUpDown
            // 
            this.yearUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearUpDown.Location = new System.Drawing.Point(292, 276);
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(120, 24);
            this.yearUpDown.TabIndex = 5;
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorNameTextBox.Location = new System.Drawing.Point(293, 148);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(120, 24);
            this.directorNameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(91, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Director Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(566, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Picture";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.browseButton.ForeColor = System.Drawing.Color.Black;
            this.browseButton.Location = new System.Drawing.Point(493, 353);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(71, 33);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(602, 354);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(126, 33);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Add Image only";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(502, 77);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(215, 258);
            this.pictureBoxPhoto.TabIndex = 12;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.Click += new System.EventHandler(this.pictureBoxPhoto_Click);
            // 
            // registerMovieButton
            // 
            this.registerMovieButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerMovieButton.ForeColor = System.Drawing.Color.Black;
            this.registerMovieButton.Location = new System.Drawing.Point(174, 353);
            this.registerMovieButton.Name = "registerMovieButton";
            this.registerMovieButton.Size = new System.Drawing.Size(177, 33);
            this.registerMovieButton.TabIndex = 13;
            this.registerMovieButton.Text = "Register Movie";
            this.registerMovieButton.UseVisualStyleBackColor = true;
            this.registerMovieButton.Click += new System.EventHandler(this.registerMovieButton_Click);
            // 
            // ageRestrictionComboBox
            // 
            this.ageRestrictionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageRestrictionComboBox.FormattingEnabled = true;
            this.ageRestrictionComboBox.Location = new System.Drawing.Point(293, 190);
            this.ageRestrictionComboBox.Name = "ageRestrictionComboBox";
            this.ageRestrictionComboBox.Size = new System.Drawing.Size(121, 26);
            this.ageRestrictionComboBox.TabIndex = 14;
            this.ageRestrictionComboBox.SelectedIndexChanged += new System.EventHandler(this.ageRestrictionComboBox_SelectedIndexChanged);
            // 
            // ageRestrictionLabel
            // 
            this.ageRestrictionLabel.AutoSize = true;
            this.ageRestrictionLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageRestrictionLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ageRestrictionLabel.Location = new System.Drawing.Point(91, 192);
            this.ageRestrictionLabel.Name = "ageRestrictionLabel";
            this.ageRestrictionLabel.Size = new System.Drawing.Size(161, 24);
            this.ageRestrictionLabel.TabIndex = 15;
            this.ageRestrictionLabel.Text = "Age Restriction";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 57);
            this.label3.TabIndex = 16;
            this.label3.Text = "Register Movie";
            // 
            // RegisterMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.label3);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.Name = "RegisterMovieForm";
            this.Text = "RegisterMovieForm";
            this.Load += new System.EventHandler(this.RegisterMovieForm_Load);
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
        private System.Windows.Forms.Label label3;
    }
}