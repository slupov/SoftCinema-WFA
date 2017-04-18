using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningReservationGroup : Panel
    {
        private Label _text { get; set; }
        public Ticket Ticket { get; set; }
        private ChoiceButton _approveButton { get; set; }
        private ChoiceButton _rejectButton { get; set; }

        public ScreeningReservationGroup(Point location, Ticket ticket)
        {
            this.Location = location;
            this.Ticket = ticket;

            this._text.Location = location;
            this._text.Font = new Font(new FontFamily("Comic Sans MS"), 14);

            _approveButton = new ChoiceButton(true);
            _rejectButton = new ChoiceButton(false);
        }

        private void RenderLabel()
        {
            this._text.Text = string.Format("Reserved: Row {0} Seat {1} | {2}, Price: {3}", this.Ticket.Seat.Row,
                this.Ticket.Seat.Number, this.Ticket.Type, this.Ticket.Price);

            _approveButton.Location = new Point(this.Location.X + this._text.Width + 10, this.Location.Y);
            _rejectButton.Location = new Point(_approveButton.Location.X + 5, this.Location.Y);
        }
    }
}