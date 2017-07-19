using SoftCinema.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    internal class ScreeningReservationsHolder : Panel
    {
        private List<Ticket> _reservedTickets { get; set; }

        public ScreeningReservationsHolder()
        {
        }

        public ScreeningReservationsHolder(Point startingPoint, Size size, List<Ticket> reservations)
        {
            this._reservedTickets = reservations;
            this.AutoSize = true;
            this.Location = startingPoint;
            this.Size = size;
            RenderReservationRows();
        }

        private void RenderReservationRows()
        {
            if (this._reservedTickets.Count == 0)
            {
                this.Controls.Clear();
                MessageBox.Show("No reservations");
                return;
            }

            this.Controls.Clear();

            var rowCoordinates = new Point(10, 10);
            var rowSize = new Size(this.Width - 20, 60);

            foreach (var reservedTicket in _reservedTickets)
            {
                var row = new ReservationRow(rowCoordinates, rowSize, reservedTicket);
                this.Controls.Add(row);

                rowCoordinates.Y += row.Height;
            }
;
        }
    }
}