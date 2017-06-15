using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.AdminForms.UserForms
{
    public partial class EditTicketForm : Form
    {
        private User user;
        private Ticket ticket;
        private readonly TownService townService;
        private readonly CinemaService cinemaService;
        private readonly TicketService ticketService;
        private readonly MovieService movieService;
        private readonly ScreeningService screeningService;
        private readonly SeatService seatService;

        public EditTicketForm(User user, Ticket ticket)
        {
            this.user = user;
            this.ticket = ticket;
            this.townService = new TownService();
            this.cinemaService = new CinemaService();
            this.ticketService = new TicketService();
            this.movieService = new MovieService();
            this.screeningService = new ScreeningService();
            this.seatService = new SeatService();
            InitializeComponent();
        }

        private void EditTicketForm_Load(object sender, EventArgs e)
        {
            string[] towns = townService.GetTownsNames();
            this.townComboBox.Items.AddRange(towns);
            string townCinema = ticket.Screening.Auditorium.Cinema.Town.Name;
            this.townComboBox.Text = townCinema;
            string cinemaName = ticket.Screening.Auditorium.Cinema.Name;
            this.cinemaComboBox.Text = cinemaName;
            string movieName = ticket.Screening.Movie.Name + "," + ticket.Screening.Movie.ReleaseYear;
            this.movieComboBox.Text = movieName;
            string ticketDate = ticketService.GetTicketDate(ticket.Id);
            this.dateComboBox.Text = ticketDate ;
            string ticketTime = ticketService.GetTicketTime(ticket.Id);
            this.timeComboBox.Text =ticketTime;
            string ticketType = ticket.Type.ToString();
            this.typeComboBox.Text = ticketType;
            string seatNumber = ticket.Seat.Number.ToString();
            this.seatComboBox.Text = seatNumber;


        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.cinemaComboBox.Items.Clear();
            this.movieComboBox.Items.Clear();
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            var cinemaNames = cinemaService.GetCinemasNamesBySelectedTown(this.townComboBox.SelectedItem.ToString());
            this.cinemaComboBox.Items.AddRange(cinemaNames);
           
        }

        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.movieComboBox.Items.Clear();
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            string cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            string townName = this.townComboBox.SelectedItem.ToString();
            this.movieComboBox.Items.AddRange(movieService.GetMoviesByCinemaAndTown(cinemaName, townName).Select(
                m =>m.Name+","+m.ReleaseYear).ToArray());

        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            string movieNameAndYear = this.movieComboBox.SelectedItem.ToString();
            string movieName = GetMovieName(movieNameAndYear);
            int movieYear = GetMovieYear(movieNameAndYear);
            string cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            string townName = this.townComboBox.SelectedItem.ToString();
            var dates = screeningService.GetAllDatesForMovieInCinemaByNameAndYear(townName,cinemaName,movieName,movieYear);
            this.dateComboBox.Items.AddRange(dates);
        }


        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            string date = this.dateComboBox.SelectedItem.ToString();
            string townName = this.townComboBox.SelectedItem.ToString();
            string cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            string movieName = GetMovieName(this.movieComboBox.Text);
            int movieYear = GetMovieYear(this.movieComboBox.Text);
            var hours = screeningService.GetHoursForMoviesByDateMovieNameAndYear(townName,
                cinemaName,movieName,movieYear, date);
            this.timeComboBox.Items.AddRange(hours);
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            string[] ticketTypes = TicketTypeProcessor.GetTicketTypes().ToArray();
            this.typeComboBox.Items.AddRange(ticketTypes);
            
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.seatComboBox.Items.Clear();
            this.seatComboBox.Items.Add(ticket.Seat.Number.ToString());
            string[] freeSeats =
                seatService.GetFreeSeatsForScreening(ticket.ScreeningId, ticket.Screening.AuditoriumId)
                    .Select(n => n.ToString())
                    .ToArray();
            this.seatComboBox.Items.AddRange(freeSeats);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.UnsavedChanges, Constants.GoBackPrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                EditUserTicketsForm ticketsForm = new EditUserTicketsForm(user);
                ticketsForm.TopLevel = false;
                ticketsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(ticketsForm);
                ticketsForm.Show();
            }
          
        }

        private void EditTicketButton_Click(object sender, EventArgs e)
        {

            
            try
            {
                int ticketId = ticket.Id;
                string date = dateComboBox.Text;
                string time = timeComboBox.Text;
                DateTime screeningDateTime = screeningService.GetDateTimeFromDateAndTime(date,time);
                string townName = townComboBox.Text;
                string cinemaName = cinemaComboBox.Text;
                string movieName = GetMovieName(movieComboBox.Text);
                int movieYear = GetMovieYear(movieComboBox.Text);
                Screening screening = screeningService.GetScreeningUsingMovieYear(townName, cinemaName,movieName,screeningDateTime,movieYear);
                int screeningId = screening.Id;
                int auditoriumId = screening.AuditoriumId;
                Seat seat = seatService.GetSeat(auditoriumId, byte.Parse(seatComboBox.Text));
                int seatId = seat.Id;
                string type = typeComboBox.Text;
                TicketType ticketType = (TicketType)Enum.Parse(typeof(TicketType), type);
                ticketService.UpdateTicket(ticketId,screeningId,seatId,ticketType);
                MessageBox.Show(Constants.SuccessMessages.TicketUpdatedSuccessfully);
                EditUserTicketsForm ticketsForm = new EditUserTicketsForm(user);
                ticketsForm.TopLevel = false;
                ticketsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(ticketsForm);
                ticketsForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.ErrorMessages.TicketUpdateErrorMessage);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.DeleteTicketMessage, Constants.TicketDeletePrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    ticketService.RemoveTicket(ticket.Id);
                    MessageBox.Show(Constants.SuccessMessages.TicketDeletedSuccessfully);
                    EditUserTicketsForm userTickets = new EditUserTicketsForm(user);
                    userTickets.TopLevel = false;
                    userTickets.AutoScroll = true;
                    this.Hide();
                    ((Button)sender).Parent.Parent.Controls.Add(userTickets);
                    userTickets.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show(Constants.ErrorMessages.TicketDeleteMessage);
                }
            }
            
        }

        private int GetMovieYear(string movieNameAndYear)
        {
            int yearIndex = movieNameAndYear.LastIndexOf(",");
            return int.Parse(movieNameAndYear.Substring(yearIndex + 1, movieNameAndYear.Length - yearIndex - 1));
        }

        private string GetMovieName(string movieNameAndYear)
        {
            return movieNameAndYear.Substring(0, movieNameAndYear.Length - GetMovieYear(movieNameAndYear).ToString().Length - 1);
        }
    }
}
