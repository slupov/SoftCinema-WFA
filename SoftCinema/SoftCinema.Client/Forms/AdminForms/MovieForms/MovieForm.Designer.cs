using SoftCinema.Services;


namespace SoftCinema.Client.AdminForms.MovieForms
{
    partial class MovieForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.castLabel = new System.Windows.Forms.Label();
            this.synopsisLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.townBox = new System.Windows.Forms.ComboBox();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.ageRestrictionBox = new System.Windows.Forms.TextBox();
            this.castBox = new System.Windows.Forms.TextBox();
            this.synopsisBox = new System.Windows.Forms.TextBox();
            this.ageRestrictionLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.titleLabel.Location = new System.Drawing.Point(299, 32);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 33);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreLabel.ForeColor = System.Drawing.Color.LightGray;
            this.genreLabel.Location = new System.Drawing.Point(299, 71);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(106, 33);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.ForeColor = System.Drawing.Color.LightGray;
            this.lengthLabel.Location = new System.Drawing.Point(297, 111);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(112, 33);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Length:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearLabel.ForeColor = System.Drawing.Color.LightGray;
            this.yearLabel.Location = new System.Drawing.Point(297, 150);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(82, 33);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ratingLabel.Location = new System.Drawing.Point(299, 190);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(106, 33);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "Rating:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.ForeColor = System.Drawing.Color.LightGray;
            this.directorLabel.Location = new System.Drawing.Point(299, 229);
            this.directorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(127, 33);
            this.directorLabel.TabIndex = 6;
            this.directorLabel.Text = "Director:";
            // 
            // castLabel
            // 
            this.castLabel.AutoSize = true;
            this.castLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.castLabel.ForeColor = System.Drawing.Color.LightGray;
            this.castLabel.Location = new System.Drawing.Point(297, 308);
            this.castLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.castLabel.Name = "castLabel";
            this.castLabel.Size = new System.Drawing.Size(82, 33);
            this.castLabel.TabIndex = 7;
            this.castLabel.Text = "Cast:";
       
            // 
            // synopsisLabel
            // 
            this.synopsisLabel.AutoSize = true;
            this.synopsisLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.synopsisLabel.ForeColor = System.Drawing.Color.LightGray;
            this.synopsisLabel.Location = new System.Drawing.Point(297, 347);
            this.synopsisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.synopsisLabel.Name = "synopsisLabel";
            this.synopsisLabel.Size = new System.Drawing.Size(128, 33);
            this.synopsisLabel.TabIndex = 9;
            this.synopsisLabel.Text = "Synopsis:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(28, 71);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(235, 305);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
           
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(156, 348);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(121, 28);
            this.cinemaComboBox.TabIndex = 11;
            this.cinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox_SelectedIndexChanged);
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(294, 348);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(121, 28);
            this.dateBox.TabIndex = 12;
            this.dateBox.SelectedIndexChanged += new System.EventHandler(this.dateBox_SelectedIndexChanged);
            // 
            // hourBox
            // 
            this.hourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Location = new System.Drawing.Point(441, 348);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(121, 28);
            this.hourBox.TabIndex = 13;
            this.hourBox.SelectedIndexChanged += new System.EventHandler(this.hourBox_SelectedIndexChanged_1);
            // 
            // townBox
            // 
            this.townBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townBox.FormattingEnabled = true;
            this.townBox.Location = new System.Drawing.Point(12, 348);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(121, 28);
            this.townBox.TabIndex = 14;
            this.townBox.SelectedIndexChanged += new System.EventHandler(this.townBox_SelectedIndexChanged);
            // 
            // ticketsButton
            // 
            this.ticketsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsButton.Location = new System.Drawing.Point(593, 331);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(150, 56);
            this.ticketsButton.TabIndex = 15;
            this.ticketsButton.Text = "Select Tickets";
            this.ticketsButton.UseVisualStyleBackColor = true;
            this.ticketsButton.Click += new System.EventHandler(this.ticketsButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBox.Location = new System.Drawing.Point(540, 34);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(132, 26);
            this.titleBox.TabIndex = 18;
            // 
            // genreBox
            // 
            this.genreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreBox.Location = new System.Drawing.Point(540, 74);
            this.genreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genreBox.Name = "genreBox";
            this.genreBox.ReadOnly = true;
            this.genreBox.Size = new System.Drawing.Size(132, 26);
            this.genreBox.TabIndex = 19;
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthBox.Location = new System.Drawing.Point(540, 113);
            this.lengthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.ReadOnly = true;
            this.lengthBox.Size = new System.Drawing.Size(132, 26);
            this.lengthBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBox.Location = new System.Drawing.Point(540, 153);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(132, 26);
            this.yearBox.TabIndex = 21;
            // 
            // ratingBox
            // 
            this.ratingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingBox.Location = new System.Drawing.Point(540, 192);
            this.ratingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(132, 26);
            this.ratingBox.TabIndex = 22;
            // 
            // directorBox
            // 
            this.directorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorBox.Location = new System.Drawing.Point(540, 231);
            this.directorBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directorBox.Name = "directorBox";
            this.directorBox.ReadOnly = true;
            this.directorBox.Size = new System.Drawing.Size(132, 26);
            this.directorBox.TabIndex = 23;
            // 
            // ageRestrictionBox
            // 
            this.ageRestrictionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageRestrictionBox.Location = new System.Drawing.Point(540, 271);
            this.ageRestrictionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageRestrictionBox.Name = "ageRestrictionBox";
            this.ageRestrictionBox.ReadOnly = true;
            this.ageRestrictionBox.Size = new System.Drawing.Size(132, 26);
            this.ageRestrictionBox.TabIndex = 24;
            // 
            // castBox
            // 
            this.castBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.castBox.Location = new System.Drawing.Point(540, 310);
            this.castBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.castBox.Name = "castBox";
            this.castBox.ReadOnly = true;
            this.castBox.Size = new System.Drawing.Size(132, 26);
            this.castBox.TabIndex = 25;
            // 
            // synopsisBox
            // 
            this.synopsisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.synopsisBox.Location = new System.Drawing.Point(540, 350);
            this.synopsisBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.synopsisBox.Name = "synopsisBox";
            this.synopsisBox.ReadOnly = true;
            this.synopsisBox.Size = new System.Drawing.Size(132, 26);
            this.synopsisBox.TabIndex = 26;
            // 
            // ageRestrictionLabel
            // 
            this.ageRestrictionLabel.AutoSize = true;
            this.ageRestrictionLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageRestrictionLabel.ForeColor = System.Drawing.Color.LightGray;
            this.ageRestrictionLabel.Location = new System.Drawing.Point(297, 268);
            this.ageRestrictionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageRestrictionLabel.Name = "ageRestrictionLabel";
            this.ageRestrictionLabel.Size = new System.Drawing.Size(219, 33);
            this.ageRestrictionLabel.TabIndex = 8;
            this.ageRestrictionLabel.Text = "Age Restriction:";
           
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(378, 411);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(200, 69);
            this.back.TabIndex = 27;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1025, 514);
            this.Controls.Add(this.back);
            this.Controls.Add(this.synopsisBox);
            this.Controls.Add(this.castBox);
            this.Controls.Add(this.ageRestrictionBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.synopsisLabel);
            this.Controls.Add(this.ageRestrictionLabel);
            this.Controls.Add(this.castLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MovieForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label castLabel;
        private System.Windows.Forms.Label synopsisLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox townBox;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox ageRestrictionBox;
        private System.Windows.Forms.TextBox castBox;
        private System.Windows.Forms.TextBox synopsisBox;
        private System.Windows.Forms.Label ageRestrictionLabel;
        private System.Windows.Forms.Button back;
    }
}