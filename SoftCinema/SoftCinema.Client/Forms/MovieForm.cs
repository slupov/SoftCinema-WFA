namespace SoftCinema.Client.Forms
{
    using SoftCinema.Models;
    using SoftCinema.Services;
    using System;
    using System.Linq;
    using System.Windows.Forms;
    public partial class MovieForm : Form
    {
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
            this.townBox.Items.AddRange(TownService.GetTownsNames());
     //       this.cinemaComboBox.Items.AddRange(CinemaService.GetCinemasByMovieAndTown(titleBox.Text, townBox.SelectedItem.ToString()));
            //etc.
        }

        private void actorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
