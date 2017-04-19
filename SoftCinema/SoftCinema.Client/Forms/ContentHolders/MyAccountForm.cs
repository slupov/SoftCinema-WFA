using SoftCinema.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class MyAccountForm : ContentHolderForm
    {
        public static string _currentUser { get; set; }
        private byte[] movieImageBytes { get; set; }

        public MyAccountForm()
        {
            InitializeComponent();
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
        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();
            SoftCinemaForm.SetContentHolderForm(new EditUserForm());
        }

    }
}
