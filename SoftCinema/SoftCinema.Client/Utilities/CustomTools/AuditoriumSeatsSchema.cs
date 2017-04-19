using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Utilities.CustomTools
{
    class AuditoriumSeatsSchema : Panel
    {
        private Auditorium _Auditorium { get; set; }
        private static int _seatCountLimit { get; set; }
        private static List<SeatButton> _seats { get; set; }
        private Screening _screening { get; set; }


        public AuditoriumSeatsSchema(Auditorium auditorium, Screening screening, Point startingCoords, int width,
            int seatCount)
        {
            this._Auditorium = auditorium;
            this._screening = screening;
            _seats = new List<SeatButton>();
            _seatCountLimit = seatCount;
            this.Location = startingCoords;
            this.Size = new Size(width, 300);
            this.AutoSize = true;
            this.BackColor = Color.Bisque;

            VisualizeSeats();
            if (ShouldCancelReservtions(TicketForm.Screening,new TimeSpan(0,20,0)))
            {
                CancelReservtions(TicketForm.Screening);
                DisableAllSeats();
            }
           
        }
        private bool ShouldCancelReservtions(Screening screening, TimeSpan t)
        {
            var diffInSeconds = (DateTime.Now - screening.Start).TotalMinutes;
            if (diffInSeconds < t.TotalMinutes)
            {
                return true;
            }
            return false;
        }
        private void CancelReservtions(Screening screening)
        {
           Services.TicketService.RemoveUnpaidTickets(screening);
        }
        public void UpdateReserveButton()
        {
            var count = GetSelectedSeats().Count;
            var form = (SelectSeatsForm) this.Parent;
            if (count == _seatCountLimit)
            {
                form.reserveButton.Enabled = true;
            }
            else
            {
                form.reserveButton.Enabled = false;
            }
        }

        private void VisualizeSeats()
        {
            var maxRow = this._Auditorium.Seats.Max(s => s.Row);

            var rowLabelCoordinates = new Point(10, 10);
            var seatCoordinates = rowLabelCoordinates;

            var maxSeatsPerRow = 0;
            var seatNumber = 0;

            for (int row = 1; row <= maxRow; row++)
            {
                var seatsPerRow = _Auditorium.Seats.Count(s => s.Row == row);
                if (seatsPerRow > maxSeatsPerRow)
                {
                    maxSeatsPerRow = seatsPerRow;
                }

                Label rowLabel = new Label();
                rowLabel.Size = new Size(20, 20);
                rowLabel.Text = row.ToString();
                rowLabel.Location = rowLabelCoordinates;
                this.Controls.Add(rowLabel);

                for (int col = 1; col <= seatsPerRow; col++)
                {
                    ++seatNumber;

                    if (col == 1)
                    {
                        seatCoordinates.X = rowLabelCoordinates.X;
                    }
                    seatCoordinates.X += 40;

                    SeatButton seatButton = new SeatButton(seatNumber, row);
                    seatButton.Location = seatCoordinates;
                    seatButton.Text = seatNumber.ToString();
                    seatButton.ForeColor = Color.Black;

                    var ticket = TicketService.GetTicket(seatNumber, _screening);

                    if (this._screening.Contains(seatNumber))
                    {
                        seatButton.Enabled = false;
                        if (ticket.isPaid)
                        {
                            seatButton.BackColor = Constants.Colors.TakenSeatColor;
                        }
                        else
                        {
                            seatButton.BackColor = Constants.Colors.ReservedSeatColor;
                        }
                    }
                    this.Controls.Add(seatButton);
                    _seats.Add(seatButton);
                }

                //find max middle and split seats into two groups by leaving a space (Location.x)

                rowLabelCoordinates.Y += 40;
                seatCoordinates.Y += 40;
            }
        }


        //if seatCount of clicked buttons is reached -> make all buttons unclickable
        public static void LimitSeatsSelection()
        {
            var selectedSeats = _seats.Where(s => s.isSelected()).ToList();

            if (selectedSeats.Count() == _seatCountLimit)
            {
                DisableUnselectedSeats();
            }
            else
            {
                EnableAllSeats();
            }
        }

        private static void DisableUnselectedSeats()
        {
            foreach (var seatButton in _seats)
            {
                if (seatButton.isSelected())
                {
                    continue;
                }
                else
                {
                    seatButton.Enabled = false;
                }
            }
        }

        private static void EnableAllSeats()
        {
            foreach (var seatButton in _seats.Where(s => s.BackColor == Constants.Colors.FreeSeatColor))
            {
                seatButton.Enabled = true;
            }
        }
        private static void DisableAllSeats()
        {
            foreach (var seatButton in _seats)
            {
                seatButton.Enabled = false;
            }
        }

        public List<SeatButton> GetSelectedSeats()
        {
            return AuditoriumSeatsSchema._seats.Where(s => s.isSelected()).ToList();
        }
    }
}