namespace SoftCinema.Client.Forms
{
    using SoftCinema.Models;
    using SoftCinema.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    public partial class MovieForm : Form
    {
        private string _townName { get; set; }
        private string _cinemaName { get; set; }
        private string _movieName { get; set; }
        //        private ICollection<Screening> _screenings { get; set; }
        private ICollection<Movie> _movies { get; set; }
        public static Screening Screening;
        public Movie _movie { get; set; }

        public MovieForm(Movie movie)
        {
            InitializeComponent();
            System.Drawing.Image image = ImageService.byteArrayToImage(movie.Image.Content);
            this._movie = movie;
            this.pictureBox.Image = ImageService.ScaleImage(image,142,224);
            this.titleBox.Text = _movie.Name;
            this.genreBox.Text = string.Join(", ", this._movie.Categories.Select(c => c.Name));
            this.lengthBox.Text = _movie.Length.ToString() + " minutes";
            this.yearBox.Text = _movie.ReleaseYear.ToString();
            this.ratingBox.Text = _movie.Rating.ToString() + " / 10";
            this.directorBox.Text = _movie.DirectorName;
            this.ageRestrictionBox.Text = _movie.AgeRestriction.ToString();
            this.castBox.Text = string.Join(",", this._movie.Cast.Select(c => c.Name));
            this.synopsisBox.Text = _movie.Synopsis;
            this.townBox.Text = "Select town";
            this.townBox.Items.AddRange(TownService.GetTownsNames());
            
        }

        private void actorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void townBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cinemaComboBox.Text = "Select cinema";
            this.cinemaComboBox.Items.Clear();
            this.dateBox.Text = "";
            this.dateBox.Items.Clear();
            this.hourBox.Text = "";
            this.hourBox.Items.Clear();
            this._townName = this.townBox.SelectedItem.ToString();
            this._movieName = this._movie.Name;
            var cinemaNames = Services.CinemaService.GetCinemasByMovieAndTown(this._movieName,this._townName);

            this.cinemaComboBox.Items.AddRange(cinemaNames);

            if (this.cinemaComboBox.Items.Count == 0)
            {
                this.cinemaComboBox.Text = "(no cinemas)";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

        }

        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateBox.Text = "Select date";
            this.dateBox.Items.Clear();
            this._cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            var dates = Services.ScreeningService.GetAllDates(this._townName,
                this._cinemaName, this._movieName);
            this.dateBox.Items.AddRange(dates);
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hourBox.Text = "Select time";
            this.hourBox.Items.Clear();
            var date = this.dateBox.SelectedItem.ToString();

            var hours = Services.ScreeningService.GetHoursForMoviesByDate(this._townName,
                this._cinemaName, this._movieName, date);
            ;
            this.hourBox.Items.AddRange(hours);
        }
    }
}
