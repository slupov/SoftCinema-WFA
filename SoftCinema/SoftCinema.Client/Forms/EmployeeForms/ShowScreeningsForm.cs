using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools.EmployeeTools;
using SoftCinema.Models;
using SoftCinema.Services;

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

        public ShowScreeningsForm()
        {
            this._screenings = new List<Screening>();

            InitializeComponent();
        }

        private void ShowScreeningsForm_Load(object sender, EventArgs e)
        {
            this.townComboBox.Items.AddRange(TownService.GetTownsNames());
        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cinemaComboBox.Text = "Select cinema: ";
            this.cinemaComboBox.Items.Clear();
            this.movieComboBox.Text = "";
            this.movieComboBox.Items.Clear();

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
            this._movieName = this.movieComboBox.SelectedItem.ToString();

            var screenings = ScreeningService.GetScreenings(this._townName, this._cinemaName, this._movieName);
            this._screenings = screenings.ToList();

            RenderScreeningsHolder();
        }

        private void RenderScreeningsHolder()
        {
            if (this._screenings.Count == 0)
            {
                return;
            }
            this._screeningsHolder =
                new ScreeningsHolder(new Point(this.townComboBox.Location.X, this.townComboBox.Location.Y + 60),
                    this._screenings);

            this.Controls.Add(this._screeningsHolder);
        }
    }
}