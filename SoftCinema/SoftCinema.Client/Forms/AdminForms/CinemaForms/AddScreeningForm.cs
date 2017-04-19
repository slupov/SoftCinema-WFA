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
using SoftCinema.Services.Utilities.Validators;

namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    public partial class AddScreeningForm : Form
    {
        private Cinema cinema;
        public AddScreeningForm(Cinema cinema)
        {
            this.cinema = cinema;
            InitializeComponent();
        }

        private void AddScreeningForm_Load(object sender, EventArgs e)
        {
            DateCalendar.MinDate = DateTime.Now;
            this.ScreeningTaken.Visible = false;
            movieComboBox.Items.AddRange(MovieService.GetAllMovies().Select(m =>m.Name+","+m.ReleaseYear).ToArray());
            auditoriumComboBox.Items.AddRange(AuditoriumService.GetAudtitoriums(cinema.Id).Select(a => a.Number.ToString()).ToArray());
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Cinema cinemaWithScreenings = CinemaService.GetCinemaWithScreenings(cinema.Id);
            SelectScreeningForm screeningsForm = new SelectScreeningForm(cinemaWithScreenings);
            screeningsForm.TopLevel = false;
            screeningsForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
            screeningsForm.Show();
        }

        private void AddScreeningButton_Click(object sender, EventArgs e)
        {
            try
            {
                string movieName = GetMovieName(movieComboBox.Text);
                int year = GetMovieYear(movieComboBox.Text);
                DateTime getDate = DateCalendar.SelectionRange.Start;
                string date = getDate.Day.ToString() + " " + getDate.ToString("MMM") + " " + getDate.DayOfWeek.ToString();
                DateTime getTime = TimePicker.Value;
                string time = getTime.ToString("hh") + ":" + getTime.ToString("mm") + " " + getTime.ToString("tt", CultureInfo.InvariantCulture);
                DateTime startTime = ScreeningService.GetDateTimeFromDateAndTime(date, time);
                byte auditoriumNumber = byte.Parse(auditoriumComboBox.Text);
                int auditoriumId = AuditoriumService.GetAuditoriumId(auditoriumNumber, this.cinema.Id); 
                int movieId = MovieService.GetMovieId(movieName, year);
                ScreeningValidator.ValidateScreeningTimeAvailable(startTime,auditoriumId,movieName,year);
                ScreeningService.AddScreening(auditoriumId,movieId,startTime);
                MessageBox.Show("Screening added successfully!");
                Cinema cinema = CinemaService.GetCinemaWithScreenings(this.cinema.Id);
                SelectScreeningForm screeningsForm = new SelectScreeningForm(cinema);
                screeningsForm.TopLevel = false;
                screeningsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
                screeningsForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Add screening failed!");
            }
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

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckScreeningAvailable();
        }

        private void auditoriumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckScreeningAvailable();
        }

        private void DateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            CheckScreeningAvailable();
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckScreeningAvailable();
        }

        private void CheckScreeningAvailable()
        {
            if (movieComboBox.Text == "")
            {
                return;

            }
            if (auditoriumComboBox.Text == "")
            {
                return;

            }
            string movieName = GetMovieName(movieComboBox.Text);
            int year = GetMovieYear(movieComboBox.Text);
            DateTime getDate = DateCalendar.SelectionRange.Start;
            string date = getDate.Day.ToString() + " " + getDate.ToString("MMM") + " " + getDate.DayOfWeek.ToString();
            DateTime getTime = TimePicker.Value;
            string time = getTime.ToString("hh") + ":" + getTime.ToString("mm") + " " + getTime.ToString("tt", CultureInfo.InvariantCulture);
            DateTime startTime = ScreeningService.GetDateTimeFromDateAndTime(date, time);
            byte auditoriumNumber = byte.Parse(auditoriumComboBox.Text);

            int auditoriumId = AuditoriumService.GetAuditoriumId(auditoriumNumber, this.cinema.Id);
            if (!ScreeningService.IsScreeningAvailableInAuditorium(auditoriumId, startTime, movieName, year))
            {
                ScreeningTaken.Visible = true;
                ScreeningTaken.Text = "Screening is already taken!";
            }
            else
            {
                ScreeningTaken.Visible = false;
            }
        }
    }
}
