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

namespace SoftCinema.Client.Utilities.CustomTools
{
    class AuditoriumSeatsSchema : Panel
    {
        private Auditorium _Auditorium { get; set; }
        private static int _seatCountLimit { get; set; }

        //TODO:make not static, + getters
        private static List<SeatButton> _seats { get; set; }

       
        public AuditoriumSeatsSchema(Auditorium auditorium, Point startingCoords, int width, int seatCount)
        {
            this._Auditorium = auditorium;
            _seats = new List<SeatButton>();
            _seatCountLimit = seatCount;
            this.Location = startingCoords;
            this.Size = new Size(width, 300);
            this.BackColor = Color.LightSkyBlue;
            
            VisualizeSeats();
        }

        public  void UpdateReserveButton()
        {
            var count = GetSelectedSeats().Count;
            var form = (SelectSeatsForm)this.Parent;
            if (count==_seatCountLimit)
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

            var rowLabelCoordinates = this.Location;
            var seatCoordinates = this.Location;

            var maxSeatsPerRow = 0;

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
                    if (col == 1)
                    {
                        seatCoordinates.X = rowLabelCoordinates.X;
                    }
                    seatCoordinates.X += 30;

                    SeatButton seatButton = new SeatButton();
                    seatButton.Location = seatCoordinates;
                    seatButton.Text = col.ToString();

                    this.Controls.Add(seatButton);
                    _seats.Add(seatButton);
                }

                //find max middle and split seats into two groups by leaving a space (Location.x)

                rowLabelCoordinates.Y += 30;
                seatCoordinates.Y += 30;
            }
        }

       
        //if seatCount of clicked buttons is reached -> make all buttons unclickable
        public static void LimitSeatsSelection()
        {
            var selectedSeats = _seats.Where(s => s.isSelected()).ToList();

            if (selectedSeats.Count() == _seatCountLimit)
            {
                DisableUnselectedSeats();
                //maraw
            }
            else
            {
                //too many calls?
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
            foreach (var seatButton in _seats)
            {
                seatButton.Enabled = true;
            }
        }

        public List<SeatButton> GetSelectedSeats()
        {
            return AuditoriumSeatsSchema._seats.Where(s => s.isSelected()).ToList();
        }
    }
}