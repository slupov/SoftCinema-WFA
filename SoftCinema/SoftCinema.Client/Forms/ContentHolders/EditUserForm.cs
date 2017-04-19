using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class EditUserForm : ContentHolderForm
    {
        private byte[] movieImageBytes { get; set; }

        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender,EventArgs e)
        {
          
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();
            SoftCinemaForm.SetContentHolderForm(new MyAccountForm());
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

        private void saveChanges_Click(object sender, EventArgs e)
        {
            var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();
            SoftCinemaForm.SetContentHolderForm(new MyAccountForm());


        }

       private void usernameTextBox_TextChanged(object sender, EventArgs e)
       {
            UserService.GetUser(MyAccountForm._currentUser).Username = this.usernameTextBox.SelectedText;
       }

        private void EditUserForm_Load_1(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
