using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools
{
    class AuditoriumSeatsSchema : GroupBox
    {
        private Auditorium _Auditorium { get; set; }
        private Point _startingPoint { get; set; }

        private ICollection<Label> RowLabels { get; set; }
        private ICollection<SeatButton> SeatButtons { get; set; }

        public AuditoriumSeatsSchema(Auditorium auditorium, Point startingCoords)
        {
            this._Auditorium = auditorium;
            this._startingPoint = startingCoords;
            this.RowLabels = new List<Label>();
            this.SeatButtons = new List<SeatButton>();

            VisualizeSeats();
        }

        private void VisualizeSeats()
        {
            var maxRow = this._Auditorium.Seats.Max(s => s.Row);
            var maxCol = this._Auditorium.Seats.Max(s => s.Number);

            var rowLabelCoordinates = this._startingPoint;
            var seatCoordinates = this._startingPoint;

            for (int row = 1; row <= maxRow; row++)
            {
                Label rowLabel = new Label();
                rowLabel.Text = row.ToString();
                rowLabel.Location = rowLabelCoordinates;
                this.Controls.Add(rowLabel);

                for (int col = 1; col <= maxCol; col++)
                {
                    if (col != maxCol / 2)
                    {
                        seatCoordinates.X += 30;
                    }
                    else
                    {
                        seatCoordinates.X += 60;
                    }

                    SeatButton seatButton = new SeatButton();
                    seatButton.Location = seatCoordinates;
                    seatButton.Text = col.ToString();

                    this.Controls.Add(seatButton);
                }

                rowLabelCoordinates.Y += 30;
            }
        }
    }
}