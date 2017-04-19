using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ReservationRow : GroupBox
    {
        private Label _text { get; set; }
        public Ticket Ticket { get; set; }
        private ChoiceButton _approveButton { get; set; }
        private ChoiceButton _rejectButton { get; set; }

        public ReservationRow(Point location, Size size, Ticket ticket)
        {
            _approveButton = new ChoiceButton(true);
            _rejectButton = new ChoiceButton(false);

            this.Location = location;
            this.Ticket = ticket;
            this.Size = size;
            this._text = new Label();
            this._text.Size = new Size(500, this.Size.Height);
            this._text.Location = new Point(location.X + 5, location.Y + 5);

            RenderLabel();
            RenderButtons();
        }

        private void RenderLabel()
        {
            this.Controls.Add(this._text);
            this._text.Font = new Font(new FontFamily("Comic Sans MS"), 10);

            this._text.Text = string.Format("{0} (Reserved): Row {1} Seat {2} | {3}, Price: {4}",
                this.Ticket.Holder.Username, this.Ticket.Seat.Row,
                this.Ticket.Seat.Number, this.Ticket.Type, this.Ticket.Price);
        }

        private void RenderButtons()
        {
            this._approveButton.Click += new System.EventHandler(this._approveButton_Click);
            this._rejectButton.Click += new System.EventHandler(this._rejectButton_Click);

            this._approveButton.Location = new Point(this._text.Location.X + this._text.Width + 5, this._text.Location.Y);
            this._rejectButton.Location = new Point(_approveButton.Location.X + _approveButton.Width + 10,
                _approveButton.Location.Y);

            this.Controls.Add(this._approveButton);
            this.Controls.Add(this._rejectButton);
        }

        private void _approveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.WantToSellTicketWarning,
                "Careful!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TicketService.SellTicket((Ticket) sender);
                MessageBox.Show("Ticket successfully sold!");
            }
            else
            {
                //do nothing
            }
        }

        private void _rejectButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.WantToRejectTicketWarning,
                "Careful!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TicketService.DeleteTicket((Ticket) sender);
            }
        }
    }
}