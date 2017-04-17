namespace SoftCinema.Client.Forms
{
    partial class TicketForm
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
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.selectTicketTypeButton = new System.Windows.Forms.Button();
            this.townLabel = new System.Windows.Forms.Label();
            this.townComboBox = new System.Windows.Forms.ComboBox();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.DisplayMember = "Name";
            this.cinemaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(352, 158);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(121, 26);
            this.cinemaComboBox.TabIndex = 0;
            this.cinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox_SelectedIndexChanged);
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.AutoSize = true;
            this.cinemaLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinemaLabel.ForeColor = System.Drawing.Color.LightGray;
            this.cinemaLabel.Location = new System.Drawing.Point(206, 160);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(97, 24);
            this.cinemaLabel.TabIndex = 1;
            this.cinemaLabel.Text = "Cinema:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.LightGray;
            this.timeLabel.Location = new System.Drawing.Point(206, 283);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(61, 24);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "Time:";
            // 
            // timeComboBox
            // 
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(352, 281);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 26);
            this.timeComboBox.TabIndex = 3;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.dateLabel.Location = new System.Drawing.Point(206, 242);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 24);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "Date:";
            // 
            // selectTicketTypeButton
            // 
            this.selectTicketTypeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectTicketTypeButton.Location = new System.Drawing.Point(357, 338);
            this.selectTicketTypeButton.Name = "selectTicketTypeButton";
            this.selectTicketTypeButton.Size = new System.Drawing.Size(108, 40);
            this.selectTicketTypeButton.TabIndex = 8;
            this.selectTicketTypeButton.Text = "Select tickets";
            this.selectTicketTypeButton.UseVisualStyleBackColor = true;
            this.selectTicketTypeButton.Click += new System.EventHandler(this.selectTicketTypeButton_Click);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townLabel.ForeColor = System.Drawing.Color.LightGray;
            this.townLabel.Location = new System.Drawing.Point(206, 119);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(68, 24);
            this.townLabel.TabIndex = 6;
            this.townLabel.Text = "Town:";
            // 
            // townComboBox
            // 
            this.townComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townComboBox.FormattingEnabled = true;
            this.townComboBox.Location = new System.Drawing.Point(352, 117);
            this.townComboBox.Name = "townComboBox";
            this.townComboBox.Size = new System.Drawing.Size(121, 26);
            this.townComboBox.TabIndex = 13;
            this.townComboBox.Text = "Select town";
            this.townComboBox.SelectedIndexChanged += new System.EventHandler(this.townComboBox_SelectedIndexChanged);
            // 
            // dateComboBox
            // 
            this.dateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(352, 240);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(121, 26);
            this.dateComboBox.TabIndex = 5;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieLabel.ForeColor = System.Drawing.Color.LightGray;
            this.movieLabel.Location = new System.Drawing.Point(206, 201);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(78, 24);
            this.movieLabel.TabIndex = 15;
            this.movieLabel.Text = "Movie:";
            // 
            // movieComboBox
            // 
            this.movieComboBox.DisplayMember = "Name";
            this.movieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(352, 199);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(121, 26);
            this.movieComboBox.TabIndex = 14;
            this.movieComboBox.SelectedIndexChanged += new System.EventHandler(this.movieComboBox_SelectedIndexChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.titleLabel.Location = new System.Drawing.Point(34, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(428, 57);
            this.titleLabel.TabIndex = 16;
            this.titleLabel.Text = "Select screenings";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(769, 418);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.townComboBox);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.selectTicketTypeButton);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.cinemaLabel);
            this.Controls.Add(this.cinemaComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button selectTicketTypeButton;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.ComboBox townComboBox;
        internal System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.Label titleLabel;
    }
}