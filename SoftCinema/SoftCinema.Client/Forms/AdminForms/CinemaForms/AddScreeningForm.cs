using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    public partial class AddScreeningForm : Form
    {
        private readonly Cinema cinema;
        private readonly MovieService movieService;
        private readonly AuditoriumService auditoriumService;
        private readonly CinemaService cinemaService;
        private readonly ScreeningService screeningService;
        private readonly ScreeningValidator screeningValidator;

        public AddScreeningForm(Cinema cinema)
        {
            this.movieService = new MovieService();
            this.auditoriumService = new AuditoriumService();
            this.cinemaService = new CinemaService();
            this.screeningService = new ScreeningService();
            this.screeningValidator = new ScreeningValidator(screeningService);
            this.cinema = cinema;
            InitializeComponent();
        }

        private void AddScreeningForm_Load(object sender, EventArgs e)
        {
            DateCalendar.MinDate = DateTime.Now;
            this.ScreeningTaken.Visible = false;
            movieComboBox.Items.AddRange(movieService.GetAllMovies().Select(m => m.Name + "," + m.ReleaseYear).ToArray());
            auditoriumComboBox.Items.AddRange(auditoriumService.GetAudtitoriums(cinema.Id).Select(a => a.Number.ToString()).ToArray());
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Cinema cinemaWithScreenings = cinemaService.GetCinemaWithScreenings(cinema.Id);
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
                DateTime startTime = screeningService.GetDateTimeFromDateAndTime(date, time);
                byte auditoriumNumber = byte.Parse(auditoriumComboBox.Text);
                int auditoriumId = auditoriumService.GetAuditoriumId(auditoriumNumber, this.cinema.Id);
                int movieId = movieService.GetMovieId(movieName, year);
                screeningValidator.ValidateScreeningTimeAvailable(startTime, auditoriumId, movieName, year);
                screeningService.AddScreening(auditoriumId, movieId, startTime);
                MessageBox.Show("Screening added successfully!");
                Cinema cinema = cinemaService.GetCinemaWithScreenings(this.cinema.Id);
                SelectScreeningForm screeningsForm = new SelectScreeningForm(cinema);
                screeningsForm.TopLevel = false;
                screeningsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
                screeningsForm.Show();
            }
            catch (Exception)
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
            DateTime startTime = screeningService.GetDateTimeFromDateAndTime(date, time);
            byte auditoriumNumber = byte.Parse(auditoriumComboBox.Text);

            int auditoriumId = auditoriumService.GetAuditoriumId(auditoriumNumber, this.cinema.Id);
            if (!screeningService.IsScreeningAvailableInAuditorium(auditoriumId, startTime, movieName, year))
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