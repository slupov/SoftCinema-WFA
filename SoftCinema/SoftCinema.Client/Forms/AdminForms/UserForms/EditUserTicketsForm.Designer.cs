namespace SoftCinema.Client.Forms.AdminForms.UserForms
{
    partial class EditUserTicketsForm
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
            this.TicketsList = new System.Windows.Forms.ListView();
            this.Movie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cinema = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Auditorium = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Screening = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUserTicketsLabel
            // 
            this.EditUserTicketsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserTicketsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.EditUserTicketsLabel.Location = new System.Drawing.Point(37, 20);
            this.EditUserTicketsLabel.Name = "EditUserTicketsLabel";
            this.EditUserTicketsLabel.Size = new System.Drawing.Size(525, 70);
            this.EditUserTicketsLabel.TabIndex = 4;
            this.EditUserTicketsLabel.Text = "Edit User Tickets";
            // 
            // TicketsList
            // 
            this.TicketsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Movie,
            this.Cinema,
            this.Auditorium,
            this.Screening,
            this.Seat});
            this.TicketsList.FullRowSelect = true;
            this.TicketsList.Location = new System.Drawing.Point(115, 140);
            this.TicketsList.MultiSelect = false;
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.RightToLeftLayout = true;
            this.TicketsList.Size = new System.Drawing.Size(908, 320);
            this.TicketsList.TabIndex = 6;
            this.TicketsList.UseCompatibleStateImageBehavior = false;
            this.TicketsList.View = System.Windows.Forms.View.Details;
            // 
            // Movie
            // 
            this.Movie.Text = "Movie";
            this.Movie.Width = 206;
            // 
            // Cinema
            // 
            this.Cinema.Text = "Cinema";
            this.Cinema.Width = 202;
            // 
            // Auditorium
            // 
            this.Auditorium.Text = "Auditorium";
            this.Auditorium.Width = 93;
            // 
            // Screening
            // 
            this.Screening.Text = "Screening";
            this.Screening.Width = 148;
            // 
            // Seat
            // 
            this.Seat.Text = "Seat";
            this.Seat.Width = 242;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 212);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // EditUserTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1060, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TicketsList);
            this.Controls.Add(this.EditUserTicketsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserTicketsForm";
            this.Text = "EditUserTicketsForm";
            this.Load += new System.EventHandler(this.EditUserTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EditUserTicketsLabel;
        private System.Windows.Forms.ListView TicketsList;
        private System.Windows.Forms.ColumnHeader Movie;
        private System.Windows.Forms.ColumnHeader Cinema;
        private System.Windows.Forms.ColumnHeader Auditorium;
        private System.Windows.Forms.ColumnHeader Screening;
        private System.Windows.Forms.ColumnHeader Seat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}