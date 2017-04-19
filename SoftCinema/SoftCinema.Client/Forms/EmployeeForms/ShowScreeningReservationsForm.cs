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
        private Panel _reservationGroupsHolder { get; set; }

        public ShowScreeningReservationsForm(Screening screening)
        {
            this._screening = screening;
            RenderReservationGroupHolder();

            InitializeComponent();
        }


        private void RenderReservationGroupHolder()
        {
            this._reservationGroupsHolder = new Panel();
            //searchByUsernameTextBox returns null 
            this._reservationGroupsHolder.Location = new Point(this.searchByUsernameTextBox.Location.X,
                this.searchByUsernameTextBox.Location.Y + 20);

            this.Controls.Add(this._reservationGroupsHolder);
        }

        private void PopulateReservationGroupHolder(List<Ticket> tickets)
        {
            if (tickets.Count == 0)
            {
                this._reservationGroupsHolder.Controls.Clear();
                return;
            }

            var groupLocation = this._reservationGroupsHolder.Location;

            foreach (var ticket in tickets)
            {
                var reservationGroup = new ScreeningReservationGroup(groupLocation, ticket);
                this._reservationGroupsHolder.Controls.Add(reservationGroup);

                groupLocation.Y += 5;
            }
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
            var username = this.searchByUsernameTextBox.Text;
            var tickets =
                TicketService.GetTickets(this._screening)
                    .Where(t => t.Holder.Username == username && t.isPaid == false)
                    .ToList();

            PopulateReservationGroupHolder(tickets);
        }
    }
}