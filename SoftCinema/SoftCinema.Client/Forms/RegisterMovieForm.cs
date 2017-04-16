using System;
using System.Drawing;
using System.Web;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterMovieForm : Form
    {
        private byte[] movieImageBytes { get; set; }
        private AgeRestriction ageRestriction { get; set; }

        public RegisterMovieForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ImageService.AddImage(movieImageBytes);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|GIF|*gif";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var path = ofd.FileName;
                this.pictureBoxPhoto.ImageLocation = path;

                
                this.movieImageBytes = System.IO.File.ReadAllBytes(path);
            }
        }

        private void registerMovieButton_Click(object sender, EventArgs e)
        {
            var name = this.nameTextBox.Text;
            var directorName = this.directorNameTextBox.Text;
            float? rating = (float?) this.ratingUpDown.Value;
            var year = (int) this.yearUpDown.Value;
            var image = this.movieImageBytes;

            //TODO: CHECK IF IMAGE ALREADY EXISTS
            //TODO: IF NOT -> UPLOAD IT FIRST (code)
            MovieService.AddMovie(name, rating, 150, directorName, year, AgeRestriction.A, null, null, image);
        }

        private void ageRestrictionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
//            this.ageRestrictionComboBox.Items.AddRange(MovieService.GetAgeRestrictions());
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}