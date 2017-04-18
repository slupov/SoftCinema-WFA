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

        public EditTicketForm(User user, Ticket ticket)
        {
            this.user = user;
            this.ticket = ticket;
            InitializeComponent();
        }

        private void EditTicketForm_Load(object sender, EventArgs e)
        {
            this.townComboBox.Items.AddRange(Services.TownService.GetTownsNames());
            this.townComboBox.Text = ticket.Screening.Auditorium.Cinema.Town.Name;
            var cinemaNames = Services.CinemaService.GetCinemasNamesBySelectedTown(this.townComboBox.SelectedItem.ToString());

            
            this.cinemaComboBox.Text = ticket.Screening.Auditorium.Cinema.Name;

            
            this.movieComboBox.Text = ticket.Screening.Movie.Name;

            this.dateComboBox.Text = ticket.Screening.Start.Day.ToString() + " " + ticket.Screening.Start.Date.ToString("MMM") + " " + ticket.Screening.Start.DayOfWeek;

            this.timeComboBox.Text = ticket.Screening.Start.ToString("hh") + ":" + ticket.Screening.Start.ToString("mm") +" "+ticket.Screening.Start.ToString("tt", CultureInfo.InvariantCulture);

            this.typeComboBox.Text = ticket.Type.ToString();
            this.seatComboBox.Text = ticket.Seat.Number.ToString();


        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.cinemaComboBox.Items.Clear();
            
            this.movieComboBox.Items.Clear();
            
            this.dateComboBox.Items.Clear();
            
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            var cinemaNames = Services.CinemaService.GetCinemasNamesBySelectedTown(this.townComboBox.SelectedItem.ToString());

            //adds options to the Cinema select box
            this.cinemaComboBox.Items.AddRange(cinemaNames);

            //default 
            if (this.cinemaComboBox.Items.Count == 0)
            {
                this.cinemaComboBox.Text = "(no cinemas)";
            }
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
            

            this.movieComboBox.Items.AddRange(Services.MovieService.GetMovies(cinemaName, townName).Select(m => m.Name).ToArray());

            //default
            if (this.movieComboBox.Items.Count == 0)
            {
                this.movieComboBox.Text = "(no movies)";
            }
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            string movieName = this.movieComboBox.SelectedItem.ToString();
            string cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            string townName = this.townComboBox.SelectedItem.ToString();

            var dates = Services.ScreeningService.GetAllDates(townName,cinemaName,movieName);
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
            string movieName = this.movieComboBox.SelectedItem.ToString();
            var hours = Services.ScreeningService.GetHoursForMoviesByDate(townName,
                cinemaName,movieName, date);
            ;
            this.timeComboBox.Items.AddRange(hours);
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.typeComboBox.Items.Clear();
            this.seatComboBox.Items.Clear();
            this.typeComboBox.Items.AddRange(TicketTypeProcessor.GetTicketTypes().ToArray());
            
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            this.seatComboBox.Items.Clear();
            this.typeComboBox.Items.AddRange(TicketTypeProcessor.GetTicketTypes().ToArray());

        }

    }
}
