using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

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
                profilePicPictureBox.Size = new Size(profilePicPictureBox.Image.Width, profilePicPictureBox.Image.Height);
                profilePicPictureBox.Show();
            }

            LogoutButton.Show();
        }

        public static void HideGreetings()
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