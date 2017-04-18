using System;
using System.Drawing;
using System.Web;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterMovieForm : ContentHolderForm
    {
        private byte[] movieImageBytes { get; set; }
        private AgeRestriction ageRestriction { get; set; }

        public RegisterMovieForm()
        {
            InitializeComponent();
            //TODO: Add AgeRestriction Service Method //this.ageRestrictionComboBox.Items.AddRange("X", "A", "B", "C", "D");
            this.ratingUpDown.Minimum = 0.0m;
            this.ratingUpDown.Maximum = 10.0m;
            this.ratingUpDown.DecimalPlaces = 1;
            this.ratingUpDown.Increment = 0.1m;
            this.yearUpDown.Minimum = 1890;
            this.yearUpDown.Maximum = DateTime.Now.Year;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ImageService.AddImage(this.movieImageBytes);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|GIF|*gif";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 var image = System.Drawing.Image.FromFile(ofd.FileName);
                 var scaledImage = ImageService.ScaleImage(image, 215, 258);
                 this.pictureBoxPhoto.Size = new Size(scaledImage.Size.Width, scaledImage.Size.Height);
                
                 var path = ofd.FileName;
                 this.pictureBoxPhoto.Image = scaledImage;  
                
                 this.movieImageBytes = ImageService.imageToByteArray(scaledImage);
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

        private void ratingUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.ratingUpDown.Text = this.ratingUpDown.Value.ToString().Replace(".0", string.Empty);
        }

        private void RegisterMovieForm_Load(object sender, EventArgs e)
        {

        }

        private void yearUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}