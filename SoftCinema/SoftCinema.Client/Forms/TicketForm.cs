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

namespace SoftCinema.Client.Forms
{
    public partial class TicketForm : ContentHolderForm
    {
        private string _townName { get; set; }
        private string _cinemaName { get; set; }
        private string _movieName { get; set; }
//        private ICollection<Screening> _screenings { get; set; }
        private ICollection<Movie> _movies { get; set; }
        public static Screening Screening;
        private string _date;
        private string _time;

        public TicketForm()
        {
            this._movies = new List<Movie>();

            InitializeComponent();
        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cinemaComboBox.Text = "Select cinema";
            this.cinemaComboBox.Items.Clear();
            this.movieComboBox.Text = "";
            this.movieComboBox.Items.Clear();
            this.dateComboBox.Text = "";
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Text = "";
            this.timeComboBox.Items.Clear();

            this._townName = this.townComboBox.SelectedItem.ToString();
            var cinemaNames = Services.CinemaService.GetCinemasNamesBySelectedTown(this._townName);

            //adds options to the Cinema select box
            this.cinemaComboBox.Items.AddRange(cinemaNames);

            //default 
            if (this.cinemaComboBox.Items.Count == 0)
            {
                this.cinemaComboBox.Text = "(no cinemas)";
            }
        }

        private void selectTicketTypeButton_Click(object sender, EventArgs e)
        {
            
                        TicketTypeForm ticketTypeForm = new TicketTypeForm();
            ticketTypeForm.TopLevel = false;
            ticketTypeForm.AutoScroll = true;
            this.Hide();
            var formsCount = ((Button) sender).Parent.Parent.Controls.Count;
            if (formsCount <=1)
            {
                ((Button)sender).Parent.Parent.Controls.Add(ticketTypeForm);
                ticketTypeForm.Show();
            }
            else
            {
                ((Button)sender).Parent.Parent.Controls[1].Show();
            }
            
        }

        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.movieComboBox.Text = "Select movie";
            this.movieComboBox.Items.Clear();

            this._cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            this._movies = Services.MovieService.GetMovies(this._cinemaName, this._townName);

            this.movieComboBox.Items.AddRange(this._movies.Select(m => m.Name).ToArray());

            //default
            if (this.movieComboBox.Items.Count == 0)
            {
                this.movieComboBox.Text = "(no movies)";
            }
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateComboBox.Text = "Select date";
            this.dateComboBox.Items.Clear();
            this._movieName = this.movieComboBox.SelectedItem.ToString();

            var dates = Services.ScreeningService.GetAllDates(this._townName,
                this._cinemaName, this._movieName);
            this.dateComboBox.Items.AddRange(dates);
        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._time = timeComboBox.SelectedItem.ToString();
            var dateTime = ScreeningService.GetDateTimeFromDateAndTime(_date, _time);
            TicketForm.Screening = ScreeningService.GetScreening(this._townName, this._cinemaName, this._movieName,
                dateTime);
            this.selectTicketTypeButton.Enabled = true;
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timeComboBox.Text = "Select time";
            this.timeComboBox.Items.Clear();
            this._date = this.dateComboBox.SelectedItem.ToString();

            var hours = Services.ScreeningService.GetHoursForMoviesByDate(this._townName,
                this._cinemaName, this._movieName, _date);
            ;
            this.timeComboBox.Items.AddRange(hours);
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            this.townComboBox.Items.AddRange(Services.TownService.GetTownsNames());
        }
    }
}