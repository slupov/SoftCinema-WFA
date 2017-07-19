using SoftCinema.Client.Utilities.CustomTools.EmployeeTools;
using SoftCinema.Models;
using SoftCinema.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace SoftCinema.Client.Forms.EmployeeForms
{
    public partial class ShowScreeningsForm : ContentHolderForm
    {
        private ScreeningsHolder _screeningsHolder { get; set; }
        private string _townName { get; set; }
        private string _cinemaName { get; set; }
        private string _movieName { get; set; }
        private List<Screening> _screenings { get; set; }
        private ICollection<Movie> _movies { get; set; }
        private readonly TownService townService;
        private readonly CinemaService cinemaService;
        private readonly MovieService movieService;
        private readonly ScreeningService screeningService;

        public ShowScreeningsForm()
        {
            this.cinemaService = new CinemaService();
            this.townService = new TownService();
            this.movieService = new MovieService();
            this.screeningService = new ScreeningService();
            this._screenings = new List<Screening>();
            this._screeningsHolder = new ScreeningsHolder();
            InitializeComponent();
        }

        private void ShowScreeningsForm_Load(object sender, EventArgs e)
        {
            this.townComboBox.Items.AddRange(townService.GetTownsNames());
        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearScreeningsHolder();

            this.cinemaComboBox.Text = "Select cinema: ";
            this.cinemaComboBox.Items.Clear();
            this.movieComboBox.Text = "";
            this.movieComboBox.Items.Clear();

            this._townName = this.townComboBox.SelectedItem.ToString();
            var cinemaNames = cinemaService.GetCinemasNamesBySelectedTown(this._townName);

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
            ClearScreeningsHolder();
            this.movieComboBox.Text = "Select movie";
            this.movieComboBox.Items.Clear();

            this._cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            this._movies = movieService.GetMoviesByCinemaAndTown(this._cinemaName, this._townName);

            this.movieComboBox.Items.AddRange(this._movies.Select(m => m.Name).ToArray());

            //default
            if (this.movieComboBox.Items.Count == 0)
            {
                this.movieComboBox.Text = "(no movies)";
            }
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearScreeningsHolder();
            this._movieName = this.movieComboBox.SelectedItem.ToString();

            var screenings = screeningService.GetScreeningsByTownCinemaAndMovie(this._townName, this._cinemaName,
                this._movieName);
            this._screenings = screenings.ToList();

            RenderScreeningsHolder();
        }

        private void RenderScreeningsHolder()
        {
            if (this._screenings.Count == 0)
            {
                ClearScreeningsHolder();
                return;
            }
            //calculate the right offset
            var width = this.Size.Width - this.townComboBox.Location.X - TopPanelForm.LogoutButton.Size.Width;
            var size = new Size(width, 400);

            if (this.Controls.Contains(this._screeningsHolder))
            {
                var screeningsHolderIndex = this.Controls.IndexOf(this._screeningsHolder);
                this.Controls.RemoveAt(screeningsHolderIndex);
            }

            this._screeningsHolder =
                new ScreeningsHolder(new Point(this.townComboBox.Location.X, this.townComboBox.Location.Y + 60), size,
                    this._screenings);

            this.Controls.Add(this._screeningsHolder);
            this.Refresh();
        }

        private void ClearScreeningsHolder()
        {
            this._screeningsHolder.Controls.Clear();
        }
    }
}