namespace SoftCinema.Client.Forms.AdminForms.UserForms
{
    partial class EditTicketForm
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
            this.EditUserTicketsLabel = new System.Windows.Forms.Label();
            this.movieLabel = new System.Windows.Forms.Label();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.townComboBox = new System.Windows.Forms.ComboBox();
            this.townLabel = new System.Windows.Forms.Label();
            this.EditTicketButton = new System.Windows.Forms.Button();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.cinemaLabel = new System.Windows.Forms.Label();
            this.cinemaComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.seatComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EditUserTicketsLabel
            // 
            this.EditUserTicketsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserTicketsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.EditUserTicketsLabel.Location = new System.Drawing.Point(70, 25);
            this.EditUserTicketsLabel.Name = "EditUserTicketsLabel";
            this.EditUserTicketsLabel.Size = new System.Drawing.Size(525, 70);
            this.EditUserTicketsLabel.TabIndex = 5;
            this.EditUserTicketsLabel.Text = "Edit TIcket";
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieLabel.ForeColor = System.Drawing.Color.LightGray;
            this.movieLabel.Location = new System.Drawing.Point(276, 179);
            this.movieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(106, 33);
            this.movieLabel.TabIndex = 26;
            this.movieLabel.Text = "Movie:";
            // 
            // movieComboBox
            // 
            this.movieComboBox.DisplayMember = "Name";
            this.movieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(413, 179);
            this.movieComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(160, 32);
            this.movieComboBox.TabIndex = 25;
            this.movieComboBox.SelectedIndexChanged += new System.EventHandler(this.movieComboBox_SelectedIndexChanged);
            // 
            // townComboBox
            // 
            this.townComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.townComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townComboBox.FormattingEnabled = true;
            this.townComboBox.Location = new System.Drawing.Point(413, 100);
            this.townComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.townComboBox.Name = "townComboBox";
            this.townComboBox.Size = new System.Drawing.Size(160, 32);
            this.townComboBox.TabIndex = 24;
            this.townComboBox.SelectedIndexChanged += new System.EventHandler(this.townComboBox_SelectedIndexChanged);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.townLabel.ForeColor = System.Drawing.Color.LightGray;
            this.townLabel.Location = new System.Drawing.Point(291, 100);
            this.townLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(91, 33);
            this.townLabel.TabIndex = 22;
            this.townLabel.Text = "Town:";
            // 
            // EditTicketButton
            // 
            this.EditTicketButton.Enabled = false;
            this.EditTicketButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditTicketButton.Location = new System.Drawing.Point(402, 410);
            this.EditTicketButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditTicketButton.Name = "EditTicketButton";
            this.EditTicketButton.Size = new System.Drawing.Size(171, 68);
            this.EditTicketButton.TabIndex = 23;
            this.EditTicketButton.Text = "Save Changes";
            this.EditTicketButton.UseVisualStyleBackColor = true;
            // 
            // dateComboBox
            // 
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(413, 223);
            this.dateComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(160, 32);
            this.dateComboBox.TabIndex = 21;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.LightGray;
            this.dateLabel.Location = new System.Drawing.Point(294, 223);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(88, 33);
            this.dateLabel.TabIndex = 20;
            this.dateLabel.Text = "Date:";
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(413, 268);
            this.timeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(160, 32);
            this.timeComboBox.TabIndex = 19;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.LightGray;
            this.timeLabel.Location = new System.Drawing.Point(299, 268);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(83, 33);
            this.timeLabel.TabIndex = 18;
            this.timeLabel.Text = "Time:";
            // 
            // cinemaLabel
            // 
            this.cinemaLabel.AutoSize = true;
            this.cinemaLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinemaLabel.ForeColor = System.Drawing.Color.LightGray;
            this.cinemaLabel.Location = new System.Drawing.Point(254, 139);
            this.cinemaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cinemaLabel.Name = "cinemaLabel";
            this.cinemaLabel.Size = new System.Drawing.Size(128, 33);
            this.cinemaLabel.TabIndex = 17;
            this.cinemaLabel.Text = "Cinema:";
            // 
            // cinemaComboBox
            // 
            this.cinemaComboBox.DisplayMember = "Name";
            this.cinemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinemaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cinemaComboBox.FormattingEnabled = true;
            this.cinemaComboBox.Location = new System.Drawing.Point(413, 139);
            this.cinemaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.cinemaComboBox.Name = "cinemaComboBox";
            this.cinemaComboBox.Size = new System.Drawing.Size(160, 32);
            this.cinemaComboBox.TabIndex = 16;
            this.cinemaComboBox.SelectedIndexChanged += new System.EventHandler(this.cinemaComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(222, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 56);
            this.button1.TabIndex = 27;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(600, 416);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 49);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete Ticket";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeatLabel.ForeColor = System.Drawing.Color.LightGray;
            this.SeatLabel.Location = new System.Drawing.Point(301, 358);
            this.SeatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(81, 33);
            this.SeatLabel.TabIndex = 29;
            this.SeatLabel.Text = "Seat:";
            // 
            // seatComboBox
            // 
            this.seatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatComboBox.FormattingEnabled = true;
            this.seatComboBox.Location = new System.Drawing.Point(413, 358);
            this.seatComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.seatComboBox.Name = "seatComboBox";
            this.seatComboBox.Size = new System.Drawing.Size(160, 32);
            this.seatComboBox.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(298, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(413, 311);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(160, 32);
            this.typeComboBox.TabIndex = 32;
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1067, 510);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatComboBox);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.townComboBox);
            this.Controls.Add(this.townLabel);
            this.Controls.Add(this.EditTicketButton);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.cinemaLabel);
            this.Controls.Add(this.cinemaComboBox);
            this.Controls.Add(this.EditUserTicketsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTicketForm";
            this.Text = "EditTicketForm";
            this.Load += new System.EventHandler(this.EditTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditUserTicketsLabel;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.ComboBox townComboBox;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Button EditTicketButton;
        internal System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label cinemaLabel;
        private System.Windows.Forms.ComboBox cinemaComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.ComboBox seatComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}