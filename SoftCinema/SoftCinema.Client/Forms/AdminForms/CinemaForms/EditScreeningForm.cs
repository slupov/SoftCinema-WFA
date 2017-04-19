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
    public partial class EditScreeningForm : Form
    {
        private Cinema cinema;

        public EditScreeningForm(Cinema cinema)
        {
            this.cinema = cinema;
            InitializeComponent();
        }

        private void EditScreeningForm_Load(object sender, EventArgs e)
        {
            string cinemaName = cinema.Name;
            string townName = cinema.Town.Name;
            string[] movies =
                MovieService.GetMoviesByCinemaAndTown(cinema.Name, cinema.Town.Name).Select(m => m.Name +","+m.ReleaseYear).ToArray();
            this.movieComboBox.Items.AddRange(movies);
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AuditoriumComboBox.Items.Clear();
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            string[] auditoriums = AuditoriumService.GetAuditoriumsForScreening(movieName, movieYear, cinema.Id).Select(n => n.ToString()).ToArray();
            AuditoriumComboBox.Items.AddRange(auditoriums);
        }


        private void AuditoriumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateComboBox.Items.Clear();
            this.timeComboBox.Items.Clear();
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            byte auditorium = byte.Parse(AuditoriumComboBox.Text);
            
            string[] dates =ScreeningService.GetAllDatesForMovieInCinemaByNameYearAndAuditorium(cinema.Town.Name, cinema.Name, movieName,
                movieYear, auditorium);
            dateComboBox.Items.AddRange(dates);
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.timeComboBox.Items.Clear();
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            byte auditorium = byte.Parse(AuditoriumComboBox.Text);
            string date = dateComboBox.Text;
            string[] hours = ScreeningService.GetHoursForMoviesByDateMovieNameYearAndAuditorium(cinema.Town.Name, cinema.Name, movieName,
                movieYear, date,auditorium);
            timeComboBox.Items.AddRange(hours);
        }

        private int GetMovieYear(string movieNameAndYear)
        {
            int yearIndex = movieNameAndYear.LastIndexOf(",");
            return int.Parse(movieNameAndYear.Substring(yearIndex + 1, movieNameAndYear.Length - yearIndex - 1));
        }

        private string GetMovieName(string movieNameAndYear)
        {
            int yearIndex = movieNameAndYear.LastIndexOf(",");
            return movieNameAndYear.Substring(0, movieNameAndYear.Length - GetMovieYear(movieNameAndYear).ToString().Length - 1);
        }

        
    }
}
