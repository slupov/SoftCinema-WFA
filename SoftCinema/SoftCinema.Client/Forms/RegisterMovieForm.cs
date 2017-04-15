using System;
using System.Drawing;
using System.Web;
using System.Windows.Forms;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterMovieForm : Form
    {
        private byte[] movieImageBytes { get; set; }
        private string imageName { get; set; }

        public RegisterMovieForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ImageService.AddImage(movieImageBytes, imageName);
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

                this.imageName = ofd.SafeFileName;
                this.movieImageBytes = System.IO.File.ReadAllBytes(path);
            }
        }
    }
}