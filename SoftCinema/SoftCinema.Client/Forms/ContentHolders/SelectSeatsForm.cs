using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class SelectSeatsForm : ContentHolderForm
    {
        public int ChildrenTicketsCount { get; set; }
        public int RegularTicketsCount { get; set; }
        public int SeniorsTicketsCount { get; set; }
        public int StudentsTicketsCount { get; set; }
        private Screening _screening { get; set; }
        private int _seatCount { get; set; }

        private AuditoriumSeatsSchema _seatsSchema { get; set; }

        public SelectSeatsForm(Screening screening, int seatCount, int regularTckets, int childrenTickets,
            int seniorTickets, int studentTickets)
        {
            this.RegularTicketsCount = regularTckets;
            this.ChildrenTicketsCount = childrenTickets;
            this.StudentsTicketsCount = studentTickets;
            this.SeniorsTicketsCount = seniorTickets;
            this._screening = screening;
            this._seatCount = seatCount;
            InitializeComponent();
        }

        private void SelectSeatsForm_Load(object sender, EventArgs e)
        {
            InitializeSeatsSchema();
            this.Controls.Add(this._seatsSchema);
        }

        private void InitializeSeatsSchema()
        {
            var startingPoint = new Point(this.freeSeatsLegendLabel.Location.X,
                this.freeSeatsLegendLabel.Location.Y + 30);
            int width = this.reserveButton.Location.X + this.reserveButton.Size.Width - startingPoint.X;

            this._seatsSchema = new AuditoriumSeatsSchema(this._screening.Auditorium, this._screening, startingPoint,
                width,
                this._seatCount);
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            ReserveTickets();
            MessageBox.Show(Constants.SuccessMessages.TicketsReservedSuccessfully);
            this.Close();
            SoftCinemaForm.SetContentHolderForm(new HomeForm());
        }

        private void reserveButton_Enter(object sender, EventArgs e)
        {
            this.reserveButton.BackColor = Color.FromArgb(255, 41, 60, 76);
            this.reserveButton.ForeColor = Color.White;
        }

        private void ReserveTickets()
        {
            var selectedSeats = this._seatsSchema.GetSelectedSeats();
            var holderId = Services.AuthenticationManager.GetCurrentUser().Id;
            for (int i = 0; i < selectedSeats.Count;)
            {
                while (RegularTicketsCount > 0)
                {
                    var seat = Services.SeatService.GetSeat(_screening.AuditoriumId, (byte) selectedSeats[i].Number);
                    Services.TicketService.AddTicket(this._screening.Id, TicketType.Regular, seat.Id, holderId);
                    RegularTicketsCount--;
                    i++;
                }
                while (ChildrenTicketsCount > 0)
                {
                    var seat = Services.SeatService.GetSeat(_screening.AuditoriumId, (byte) selectedSeats[i].Number);
                    Services.TicketService.AddTicket(this._screening.Id, TicketType.Children, seat.Id, holderId);
                    ChildrenTicketsCount--;
                    i++;
                }
                while (SeniorsTicketsCount > 0)
                {
                    var seat = Services.SeatService.GetSeat(_screening.AuditoriumId, (byte) selectedSeats[i].Number);
                    Services.TicketService.AddTicket(this._screening.Id, TicketType.Seniors, seat.Id, holderId);
                    SeniorsTicketsCount--;
                    i++;
                }
                while (StudentsTicketsCount > 0)
                {
                    var seat = Services.SeatService.GetSeat(_screening.AuditoriumId, (byte) selectedSeats[i].Number);
                    Services.TicketService.AddTicket(this._screening.Id, TicketType.Students, seat.Id, holderId);
                    StudentsTicketsCount--;
                    i++;
                }
            }
        }

        private void reserveButton_MouseLeave(object sender, EventArgs e)
        {
            this.reserveButton.BackColor = Color.Silver;
            this.reserveButton.ForeColor = Color.FromArgb(255, 41, 60, 76);
        }
    }
}