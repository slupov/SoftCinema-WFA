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
            this.components = new System.ComponentModel.Container();
            this.EditUserTicketsLabel = new System.Windows.Forms.Label();
            this.MovieImages = new System.Windows.Forms.ImageList(this.components);
            this.TicketsList = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auditorium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Screening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreeningId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsList)).BeginInit();
            this.SuspendLayout();
            // 
            // EditUserTicketsLabel
            // 
            this.EditUserTicketsLabel.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditUserTicketsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(204)))));
            this.EditUserTicketsLabel.Location = new System.Drawing.Point(-1, 18);
            this.EditUserTicketsLabel.Name = "EditUserTicketsLabel";
            this.EditUserTicketsLabel.Size = new System.Drawing.Size(525, 70);
            this.EditUserTicketsLabel.TabIndex = 4;
            this.EditUserTicketsLabel.Text = "Edit User Tickets";
            // 
            // MovieImages
            // 
            this.MovieImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.MovieImages.ImageSize = new System.Drawing.Size(16, 16);
            this.MovieImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TicketsList
            // 
            this.TicketsList.AllowUserToAddRows = false;
            this.TicketsList.AllowUserToDeleteRows = false;
            this.TicketsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TicketsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TicketsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Movie,
            this.Cinema,
            this.Auditorium,
            this.Screening,
            this.Seat,
            this.SeatId,
            this.ScreeningId});
            this.TicketsList.Location = new System.Drawing.Point(11, 109);
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.RowTemplate.Height = 24;
            this.TicketsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TicketsList.Size = new System.Drawing.Size(1004, 320);
            this.TicketsList.TabIndex = 7;
            this.TicketsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketsList_CellContentClick);
            // 
            // Image
            // 
            this.Image.HeaderText = "";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // Movie
            // 
            this.Movie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Movie.HeaderText = "Movie";
            this.Movie.Name = "Movie";
            this.Movie.ReadOnly = true;
            this.Movie.Width = 74;
            // 
            // Cinema
            // 
            this.Cinema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cinema.HeaderText = "Cinema";
            this.Cinema.Name = "Cinema";
            this.Cinema.ReadOnly = true;
            this.Cinema.Width = 84;
            // 
            // Auditorium
            // 
            this.Auditorium.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Auditorium.HeaderText = "Auditorium";
            this.Auditorium.Name = "Auditorium";
            this.Auditorium.ReadOnly = true;
            this.Auditorium.Width = 104;
            // 
            // Screening
            // 
            this.Screening.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Screening.HeaderText = "Screening";
            this.Screening.Name = "Screening";
            this.Screening.ReadOnly = true;
            this.Screening.Width = 101;
            // 
            // Seat
            // 
            this.Seat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Seat.HeaderText = "Seat";
            this.Seat.Name = "Seat";
            this.Seat.ReadOnly = true;
            this.Seat.Width = 66;
            // 
            // SeatId
            // 
            this.SeatId.HeaderText = "SeatId";
            this.SeatId.Name = "SeatId";
            this.SeatId.ReadOnly = true;
            this.SeatId.Visible = false;
            // 
            // ScreeningId
            // 
            this.ScreeningId.HeaderText = "ScreeningId";
            this.ScreeningId.Name = "ScreeningId";
            this.ScreeningId.ReadOnly = true;
            this.ScreeningId.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(425, 446);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 46);
            this.BackButton.TabIndex = 23;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditUserTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1060, 513);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TicketsList);
            this.Controls.Add(this.EditUserTicketsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUserTicketsForm";
            this.Text = "EditUserTicketsForm";
            this.Load += new System.EventHandler(this.EditUserTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EditUserTicketsLabel;
        private System.Windows.Forms.ImageList MovieImages;
        private System.Windows.Forms.DataGridView TicketsList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auditorium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Screening;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreeningId;
    }
}