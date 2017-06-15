using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    public partial class SelectScreeningForm : Form
    {
        private readonly Cinema cinema;
        private readonly ScreeningService screeningService;
        private readonly MovieService movieService;

        public SelectScreeningForm(Cinema cinema)
        {
            this.screeningService = new ScreeningService();
            this.movieService = new MovieService();
            this.cinema = cinema;
            InitializeComponent();
        }

        private void EditScreeningForm_Load(object sender, EventArgs e)
        {
            string[] movies =
                movieService.GetMoviesByCinemaAndTown(cinema.Name, cinema.Town.Name).Select(m => m.Name +","+m.ReleaseYear).ToArray();
            this.movieComboBox.Items.AddRange(movies);
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            string[] dates = screeningService.GetAllDatesForMovieInCinemaByNameAndYear(cinema.Town.Name, cinema.Name, movieName,
                movieYear);
            dateComboBox.Items.AddRange(dates);

        }


        

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timeComboBox.Items.Clear();
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            
            string date = dateComboBox.Text;
            string[] hours = screeningService.GetHoursForMoviesByDateMovieNameAndYear(cinema.Town.Name, cinema.Name, movieName,
                movieYear, date);
            timeComboBox.Items.AddRange(hours);
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

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movie = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            string cinemaName = cinema.Name;
            string townName = cinema.Town.Name;
            DateTime date = screeningService.GetDateTimeFromDateAndTime(dateComboBox.Text, timeComboBox.Text);
            Screening screening = screeningService.GetScreeningUsingMovieYear(townName, cinemaName, movie, date, movieYear);
            EditScreening editScreeningForm = new EditScreening(screening);
            editScreeningForm.TopLevel = false;
            editScreeningForm.AutoScroll = true;
            this.Hide();
            ((ComboBox)sender).Parent.Parent.Controls.Add(editScreeningForm);
            editScreeningForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CinemaEditForm cinemaeditForm = new CinemaEditForm(cinema);
            cinemaeditForm.TopLevel = false;
            cinemaeditForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(cinemaeditForm);
            cinemaeditForm.Show();
        }

        private void AddScreeningButton_Click(object sender, EventArgs e)
        {
            AddScreeningForm addScreeningForm = new AddScreeningForm(cinema);
            addScreeningForm.TopLevel = false;
            addScreeningForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(addScreeningForm);
            addScreeningForm.Show();
        }
    }
}
