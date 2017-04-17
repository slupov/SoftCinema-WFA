using System;
using System.Drawing;
using System.Windows.Forms;
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

            var mainForm = (SoftCinemaForm) ((Button) sender).Parent.Parent.Parent;

            mainForm.RenderSideBar();
        }

        //Utilities
        public static void ShowGreetings()
        {
            GreetingLabel.Show();
            GreetingLabel.ForeColor = Color.Black;
            GreetingLabel.Text = string.Format(Constants.GreetingsMessage,
                AuthenticationManager.GetCurrentUser().Username);

            LogoutButton.Show();
        }

        public static void HideGreetings()
        {
            GreetingLabel.Hide();
            GreetingLabel.Text = string.Empty;

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