using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using Image = System.Drawing.Image;

namespace SoftCinema.Client.Forms
{
    public partial class TopPanelForm : Form
    {
        public TopPanelForm()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            AuthenticationManager.Logout();
            HideGreetings();

            MessageBox.Show(Constants.SuccessMessages.SuccessfulLogout);

            //Update sidebar
            var mainForm = (SoftCinemaForm) ((Button) sender).Parent.Parent.Parent;
            mainForm.RenderSideBar();

            //Redirect to home page view
            SoftCinemaForm.SetContentHolderForm(new HomeForm());
        }

        //Utilities
        public static void ShowGreetings()
        {
            GreetingLabel.Show();
            GreetingLabel.ForeColor = Color.White;
            GreetingLabel.Text = string.Format(Constants.GreetingsMessage,
                AuthenticationManager.GetCurrentUser().Username);

            //Show Image
            User currentUser = AuthenticationManager.GetCurrentUser();

            byte[] imageBytes = ImageService.GetProfilePicture(currentUser.Username);
            if (imageBytes != null)
            {
                System.Drawing.Image image = ImageService.byteArrayToImage(imageBytes);
                profilePicPictureBox.Image = ImageService.ScaleImage(image, 55, 54);
                profilePicPictureBox.Size = new Size(profilePicPictureBox.Image.Width,
                    profilePicPictureBox.Image.Height);
            }
            else
            {
                Image image = Image.FromFile(@"../../Utilities/Images/default.jpg");
                byte[] imageToBytes = ImageService.imageToByteArray(image);
                Models.Image newImage = new Models.Image() {Content = imageToBytes};
                currentUser.ProfilePicture = newImage;
                profilePicPictureBox.Image = ImageService.ScaleImage(image, 55, 54);
            }
            profilePicPictureBox.Location = new Point(590, profilePicPictureBox.Location.Y);
            profilePicPictureBox.Show();
            LogoutButton.Show();
        }

        public void HideGreetings()
        {
            GreetingLabel.Hide();
            GreetingLabel.Text = string.Empty;
            profilePicPictureBox.Hide();
            LogoutButton.Hide();
        }

        
        
        private void TopPanelForm_Load(object sender, EventArgs e)
        {
            if (AuthenticationManager.IsAuthenticated())
            {
                ShowGreetings();
            }
            else
            {
                HideGreetings();
            }
        }
    }
}