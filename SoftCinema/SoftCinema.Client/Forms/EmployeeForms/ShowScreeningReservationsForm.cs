using SoftCinema.Client.Utilities.CustomTools.EmployeeTools;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.EmployeeForms
{
    public partial class ShowScreeningReservationsForm : ContentHolderForm
    {
        private Screening _screening { get; set; }
        public List<Ticket> _reservedTickets { get; set; }
        private ScreeningReservationsHolder _reservationsHolder { get; set; }
        private readonly TicketService ticketService;

        public ShowScreeningReservationsForm(Screening screening)
        {
            this.ticketService = new TicketService();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this._screening = screening;
            this._reservedTickets = ticketService.GetTickets(screening).Where(t => !t.isPaid).ToList();
            this._reservationsHolder = new ScreeningReservationsHolder();

            InitializeComponent();
        }

        public void RenderReservationsHolder()
        {
            if (this._reservedTickets.Count == 0)
            {
                ClearReservationHolder();
                return;
            }
            var location = new Point(this.searchByUsernameLabel.Location.X, this.searchByUsernameTextBox.Location.Y + 40);
            var width = this.Size.Width - 100;
            var size = new Size(width, 200);

            if (this.Controls.Contains(this._reservationsHolder))
            {
                var reservationsHolderIndex = this.Controls.IndexOf(this._reservationsHolder);
                this.Controls.RemoveAt(reservationsHolderIndex);
            }

            this._reservationsHolder = new ScreeningReservationsHolder(location, size, _reservedTickets);

            this.Controls.Add(this._reservationsHolder);
            this.Refresh();
        }

        private void ShowScreeningReservationsForm_Load(object sender, EventArgs e)
        {
            var cinemaName = this._screening.Auditorium.Cinema.Name;
            var townName = this._screening.Auditorium.Cinema.Town.Name;
            var movieName = this._screening.Movie.Name;
            var startDate = this._screening.Start.ToString("f");

            this.titleLabel.Text = string.Format(Constants.ScreeningTitleLabel, cinemaName, townName, movieName,
                startDate);

            RenderReservationsHolder();
        }

        private void searchByUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearReservationHolder();

            var username = this.searchByUsernameTextBox.Text;
            if (username == "" || username == string.Empty)
            {
                this._reservedTickets = ticketService.GetTickets(this._screening)
                    .Where(t => t.isPaid == false)
                    .ToList();
            }
            else
            {
                this._reservedTickets = ticketService.GetTickets(this._screening)
                    .Where(t => t.Holder.Username == username && t.isPaid == false)
                    .ToList();
            }

            RenderReservationsHolder();
        }

        private void ClearReservationHolder()
        {
            this._reservationsHolder.Controls.Clear();
        }

        private void sellAllButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.WantToSellAllTicketsWarning,
                "Careful!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ticketService.SellTickets(this._reservedTickets);

                var ticketHolders = this._reservedTickets.Select(t => t.Holder.Username).ToList();
                var ticketHoldersString = string.Join(",", ticketHolders.Distinct());

                if (this._reservedTickets.Count == 0)
                {
                    MessageBox.Show(Constants.ErrorMessages.NoTicketsToSellMessage);
                    return;
                }
                MessageBox.Show(string.Format(Constants.SuccessMessages.TicketsSoldSuccessfully,
                    this._reservedTickets.Count,
                    ticketHoldersString));

                //update the holder
                this._reservedTickets = new List<Ticket>();
                RenderReservationsHolder();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
        }
    }
}