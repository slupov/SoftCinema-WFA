namespace SoftCinema.Client.Forms
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
            this.categoriesLabel = new System.Windows.Forms.Label();
            this.synopsisLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.dateBox = new System.Windows.Forms.ComboBox();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.townBox = new System.Windows.Forms.ComboBox();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.seatsButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.categoriesBox = new System.Windows.Forms.TextBox();
            this.castBox = new System.Windows.Forms.TextBox();
            this.synopsisBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(197, 26);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(31, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "TItle:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(197, 53);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 2;
            this.genreLabel.Text = "Genre:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(197, 85);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(43, 13);
            this.lengthLabel.TabIndex = 3;
            this.lengthLabel.Text = "Length:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(197, 116);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(199, 145);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 13);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "Rating:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(199, 174);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 6;
            this.directorLabel.Text = "Director:";
            // 
            // castLabel
            // 
            this.castLabel.AutoSize = true;
            this.castLabel.Location = new System.Drawing.Point(199, 237);
            this.castLabel.Name = "castLabel";
            this.castLabel.Size = new System.Drawing.Size(31, 13);
            this.castLabel.TabIndex = 7;
            this.castLabel.Text = "Cast:";
            this.castLabel.Click += new System.EventHandler(this.actorsLabel_Click);
            // 
            // categoriesLabel
            // 
            this.categoriesLabel.AutoSize = true;
            this.categoriesLabel.Location = new System.Drawing.Point(199, 205);
            this.categoriesLabel.Name = "categoriesLabel";
            this.categoriesLabel.Size = new System.Drawing.Size(60, 13);
            this.categoriesLabel.TabIndex = 8;
            this.categoriesLabel.Text = "Categories:";
            this.categoriesLabel.Click += new System.EventHandler(this.categoriesLabel_Click);
            // 
            // synopsisLabel
            // 
            this.synopsisLabel.AutoSize = true;
            this.synopsisLabel.Location = new System.Drawing.Point(199, 270);
            this.synopsisLabel.Name = "synopsisLabel";
            this.synopsisLabel.Size = new System.Drawing.Size(52, 13);
            this.synopsisLabel.TabIndex = 9;
            this.synopsisLabel.Text = "Synopsis:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(24, 48);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(113, 139);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(156, 348);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(121, 21);
            this.cinemaComboBox.TabIndex = 11;
            // 
            // dateBox
            // 
            this.dateBox.FormattingEnabled = true;
            this.dateBox.Location = new System.Drawing.Point(294, 348);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(121, 21);
            this.dateBox.TabIndex = 12;
            // 
            // hourBox
            // 
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Location = new System.Drawing.Point(438, 348);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(121, 21);
            this.hourBox.TabIndex = 13;
            // 
            // townBox
            // 
            this.townBox.FormattingEnabled = true;
            this.townBox.Location = new System.Drawing.Point(12, 348);
            this.townBox.Name = "townBox";
            this.townBox.Size = new System.Drawing.Size(121, 21);
            this.townBox.TabIndex = 14;
            this.townBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ticketsButton
            // 
            this.ticketsButton.Location = new System.Drawing.Point(12, 383);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(125, 32);
            this.ticketsButton.TabIndex = 15;
            this.ticketsButton.Text = "Choose Tickets";
            this.ticketsButton.UseVisualStyleBackColor = true;
            // 
            // seatsButton
            // 
            this.seatsButton.Location = new System.Drawing.Point(156, 383);
            this.seatsButton.Name = "seatsButton";
            this.seatsButton.Size = new System.Drawing.Size(121, 32);
            this.seatsButton.TabIndex = 16;
            this.seatsButton.Text = "Choose Seats";
            this.seatsButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(611, 348);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(135, 58);
            this.orderButton.TabIndex = 17;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(283, 23);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 18;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(283, 53);
            this.genreBox.Name = "genreBox";
            this.genreBox.ReadOnly = true;
            this.genreBox.Size = new System.Drawing.Size(100, 20);
            this.genreBox.TabIndex = 19;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(283, 85);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.ReadOnly = true;
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 20;
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(283, 116);
            this.yearBox.Name = "yearBox";
            this.yearBox.ReadOnly = true;
            this.yearBox.Size = new System.Drawing.Size(100, 20);
            this.yearBox.TabIndex = 21;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(283, 145);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.ReadOnly = true;
            this.ratingBox.Size = new System.Drawing.Size(100, 20);
            this.ratingBox.TabIndex = 22;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(283, 174);
            this.directorBox.Name = "directorBox";
            this.directorBox.ReadOnly = true;
            this.directorBox.Size = new System.Drawing.Size(100, 20);
            this.directorBox.TabIndex = 23;
            // 
            // categoriesBox
            // 
            this.categoriesBox.Location = new System.Drawing.Point(283, 205);
            this.categoriesBox.Name = "categoriesBox";
            this.categoriesBox.ReadOnly = true;
            this.categoriesBox.Size = new System.Drawing.Size(100, 20);
            this.categoriesBox.TabIndex = 24;
            // 
            // castBox
            // 
            this.castBox.Location = new System.Drawing.Point(283, 237);
            this.castBox.Name = "castBox";
            this.castBox.ReadOnly = true;
            this.castBox.Size = new System.Drawing.Size(100, 20);
            this.castBox.TabIndex = 25;
            // 
            // synopsisBox
            // 
            this.synopsisBox.Location = new System.Drawing.Point(283, 270);
            this.synopsisBox.Name = "synopsisBox";
            this.synopsisBox.ReadOnly = true;
            this.synopsisBox.Size = new System.Drawing.Size(100, 20);
            this.synopsisBox.TabIndex = 26;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.synopsisBox);
            this.Controls.Add(this.castBox);
            this.Controls.Add(this.categoriesBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.seatsButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.townBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.cinemaComboBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.synopsisLabel);
            this.Controls.Add(this.categoriesLabel);
            this.Controls.Add(this.castLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label categoriesLabel;
        private System.Windows.Forms.Label synopsisLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.ComboBox dateBox;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox townBox;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.Button seatsButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox categoriesBox;
        private System.Windows.Forms.TextBox castBox;
        private System.Windows.Forms.TextBox synopsisBox;
    }
}