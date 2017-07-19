using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using SoftCinema.Services.Utilities.Validators;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    public partial class EditScreening : Form
    {
        private readonly Screening screening;
        private readonly CinemaService cinemaService;
        private readonly ScreeningService screeningService;
        private readonly ScreeningValidator screeningValidator;

        public EditScreening(Screening screening)
        {
            this.screeningService = new ScreeningService();
            this.screeningValidator = new ScreeningValidator(screeningService);
            this.cinemaService = new CinemaService();
            this.screening = screening;
            InitializeComponent();
        }

        private void EditScreening_Load(object sender, EventArgs e)
        {
            DateCalendar.MinDate = DateTime.Now;
            TimePicker.Value = screening.Start;
            DateCalendar.TodayDate = screening.Start;
            DateCalendar.SetDate(screening.Start);
            DateCalendar.ShowToday = false;
            ScreeningTaken.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.UnsavedChanges, Constants.GoBackPrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Cinema cinema = cinemaService.GetCinemaWithScreenings(screening.Auditorium.CinemaId);
                SelectScreeningForm screeningsForm = new SelectScreeningForm(cinema);
                screeningsForm.TopLevel = false;
                screeningsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
                screeningsForm.Show();
            }
        }

        private void EditScreeningButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime getDate = DateCalendar.SelectionRange.Start;
                string date = getDate.Day.ToString() + " " + getDate.ToString("MMM") + " " + getDate.DayOfWeek.ToString();
                DateTime getTime = TimePicker.Value;
                string time = getTime.ToString("hh") + ":" + getTime.ToString("mm") + " " + getTime.ToString("tt", CultureInfo.InvariantCulture);

                DateTime startTime = screeningService.GetDateTimeFromDateAndTime(date, time);
                screeningValidator.ValidateScreeningAvailable(screening.Id, startTime);
                screeningService.UpdateScreening(screening.Id, startTime);
                MessageBox.Show("Screening updated successfully!");
                Cinema cinema = cinemaService.GetCinemaWithScreenings(screening.Auditorium.CinemaId);
                SelectScreeningForm screeningsForm = new SelectScreeningForm(cinema);
                screeningsForm.TopLevel = false;
                screeningsForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
                screeningsForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Screening updated failed!");
            }
        }

        private void DateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            CheckScreening();
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckScreening();
        }

        private void CheckScreening()
        {
            DateTime getDate = DateCalendar.SelectionRange.Start;
            string date = getDate.Day.ToString() + " " + getDate.ToString("MMM") + " " + getDate.DayOfWeek.ToString();
            DateTime getTime = TimePicker.Value;
            string time = getTime.ToString("hh") + ":" + getTime.ToString("mm") + " " + getTime.ToString("tt", CultureInfo.InvariantCulture);
            DateTime startTime = screeningService.GetDateTimeFromDateAndTime(date, time);
            if (!screeningService.IsScreeningAvailable(screening.Id, startTime))
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