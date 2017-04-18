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
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.EmployeeForms
{
    public partial class ShowScreeningReservationsForm : ContentHolderForm
    {
        private Screening _screening { get; set; }

        public ShowScreeningReservationsForm(Screening screening)
        {
            this._screening = screening;
            InitializeComponent();
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
        }
    }
}