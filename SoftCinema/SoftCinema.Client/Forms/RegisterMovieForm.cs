using System;
using System.Drawing;
using System.Web;
using System.Windows.Forms;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterMovieForm : Form
    {
        private byte[] movieImage { get; set; }

        public RegisterMovieForm()
        {
            InitializeComponent();

            //5 mb limit
            movieImage = new byte[5120];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ImageService.AddImage(movieImage);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select a photo";
            ofd.Filter = "PNG|*.png|JPG|*.jpg|GIF|*gif";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPhoto.ImageLocation = ofd.FileName;
                //TODO: FIX NULL REFERENCE ?
                this.movieImage = System.IO.File.ReadAllBytes(HttpContext.Current.Server.MapPath(ofd.FileName));
            }
        }
    }
}