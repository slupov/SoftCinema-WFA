using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SoftCinema.Models;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.AdminForms;
using Image = System.Drawing.Image;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class EditUserForm : ContentHolderForm
    {
        private User user;
        private static string password { get; set; }  
        private  byte[] imageBytes { get; set; }
        private static string email {get;set;}
        private static string phoneNumber { get; set; }  
        private static Image _image { get; set; }
            public EditUserForm()
            {
                user = MyAccountForm._currentUser;
            InitializeComponent();
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
                _image = System.Drawing.Image.FromFile(ofd.FileName);
               
                var scaledImage = ImageService.ScaleImage(_image, 215, 258);
                this.pictureBoxPhoto.Size = new Size(scaledImage.Size.Width, scaledImage.Size.Height);

                var path = ofd.FileName;
                this.pictureBoxPhoto.Image = scaledImage;

                imageBytes = ImageService.imageToByteArray(scaledImage);
            }
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {

        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();
            

            try
            {
                string email = this.emailTextBox.Text;
                string phoneNumber = this.phoneNumberTextBox.Text;
                string password = this.passwordTextBox.Text;
                Models.Image profilePic = new Models.Image() {Content = imageBytes};
                ImageService.AddImage(profilePic.Content);
                bool isDeleted = false;
                UserService.AddOrUpdateUser(user.Username,password,email,phoneNumber,(Role)user.Role, profilePic);
                user.ProfilePicture = profilePic;
                UserService.AddImageToUser(user,profilePic);

                UserService.AddImageToUser(MyAccountForm._currentUser, profilePic);
                MyAccountForm._currentUser = user;

                TopPanelForm.ShowGreetings();

            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.ErrorMessages.UserUpdateErrorMesage);
            }
            SoftCinemaForm.SetContentHolderForm(new MyAccountForm());
            
           
        }

      

        private void EditUserForm_Load_1(object sender, EventArgs e)
        {
            this.emailTextBox.Text = user.Email;
            this.phoneNumberTextBox.Text = user.PhoneNumber;
            
            if (user.ProfilePicture != null)
            {
                var _image = ImageService.byteArrayToImage(user.ProfilePicture.Content);
                this.pictureBoxPhoto.Image = ImageService.ScaleImage(_image, 215, 258);
            }
            else
            {
                var _image = Image.FromFile(@"../../Utilities/Images/default.jpg");
                this.pictureBoxPhoto.Image = ImageService.ScaleImage(_image, 215, 258);
            }
            this.pictureBoxPhoto.Size = new Size(this.pictureBoxPhoto.Image.Width, this.pictureBoxPhoto.Image.Height);
        }

        

        private void emailTextBox_TextChanged_1(object sender, EventArgs e)
        {
            
            email = this.emailTextBox.SelectedText;
           
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = this.passwordTextBox.SelectedText;
      
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
           
            phoneNumber = this.phoneNumberTextBox.SelectedText;
            
        }
    }
}
