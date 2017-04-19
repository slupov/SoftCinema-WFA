using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools.EmployeeTools;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.EmployeeForms
{
    public partial class ShowScreeningReservationsForm : ContentHolderForm
    {
        private Screening _screening { get; set; }
        private List<Ticket> _reservedTickets { get; set; }
        private ScreeningReservationsHolder _reservationsHolder { get; set; }

        public ShowScreeningReservationsForm(Screening screening)
        {
            this._screening = screening;
            this._reservedTickets = TicketService.GetTickets(screening).Where(t => !t.isPaid).ToList();
            this._reservationsHolder = new ScreeningReservationsHolder();
            RenderReservationsHolder();

            InitializeComponent();
        }

        private void RenderReservationsHolder()
        {
            if (this._reservedTickets.Count == 0)
            {
                ClearReservationHolder();
                return;
            }
            var location = new Point(this.searchByUsernameLabel.Location.X, this.searchByUsernameTextBox.Location.Y + 60);
            var width = this.Size.Width - this.titleLabel.Location.X;
            var size = new Size(width, 400);

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
            var startDate = this._screening.Start.ToString("f0");

            this.titleLabel.Text = string.Format(Constants.ScreeningTitleLabel, cinemaName, townName, movieName,
                startDate);
        }

        private void searchByUsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearReservationHolder();

            var username = this.searchByUsernameTextBox.Text;
            var tickets =
                TicketService.GetTickets(this._screening)
                    .Where(t => t.Holder.Username == username && t.isPaid == false)
                    .ToList();
            this._reservedTickets = tickets;

            RenderReservationsHolder();
        }

        private void ClearReservationHolder()
        {
            this._reservationsHolder.Controls.Clear();
        }
    }
}