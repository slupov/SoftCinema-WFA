using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms.AdminForms.MovieForms
{
    public partial class MovieListForm : Form
    {
        private readonly MovieService movieService;

        public MovieListForm()
        {
            this.movieService = new MovieService();
            InitializeComponent();
        }

        private void MovieListForm_Load(object sender, EventArgs e)
        {
            movieComboBox.Items.AddRange(movieService.GetAllMovies().Select(m => m.Name + "," + m.ReleaseYear).ToArray());
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            Client.AdminForms.MovieForms.RegisterMovieForm movieForm = new Client.AdminForms.MovieForms.RegisterMovieForm();
            movieForm.TopLevel = false;
            movieForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(movieForm);
            movieForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.TopLevel = false;
            adminMenuForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(adminMenuForm);
            adminMenuForm.Show();
        }

        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieName = GetMovieName(movieComboBox.Text);
            int movieYear = GetMovieYear(movieComboBox.Text);
            Movie movie = movieService.GetMovieByYearAndName(movieYear, movieName);
            Client.AdminForms.MovieForms.MovieForm movieForm = new Client.AdminForms.MovieForms.MovieForm(movie);
            movieForm.TopLevel = false;
            movieForm.AutoScroll = true;
            this.Hide();
            ((ComboBox)sender).Parent.Parent.Controls.Add(movieForm);
            movieForm.Show();
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
