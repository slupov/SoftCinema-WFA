using SoftCinema.Client.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client
{
    public partial class SoftCinemaForm : Form
    {
        public SoftCinemaForm()
        {
            InitializeComponent();
        }

        private void SoftCinemaForm_Load(object sender, EventArgs e)
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

        //Sidebar buttons
        private void registerTeamButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.TopLevel = false;
            registerForm.AutoScroll = true;
            this.ContentHolder.Controls.Clear();
            this.ContentHolder.Controls.Add(registerForm);
            registerForm.Show();
        }

        private void loginTeamButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.TopLevel = false;
            loginForm.AutoScroll = true;
            this.ContentHolder.Controls.Clear();
            this.ContentHolder.Controls.Add(loginForm);
            loginForm.Show();
        }

        //Other buttons
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            AuthenticationManager.Logout();
            HideGreetings();

            MessageBox.Show(Constants.SuccessfulLogout);
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

        private void teamButton3_Click(object sender, EventArgs e)
        {
        }

        private void teamButton4_Click(object sender, EventArgs e)
        {
            RegisterMovieForm registerMovieForm = new RegisterMovieForm();
            registerMovieForm.TopLevel = false;
            registerMovieForm.AutoScroll = true;
            this.ContentHolder.Controls.Clear();
            this.ContentHolder.Controls.Add(registerMovieForm);
            registerMovieForm.Show();
        }
    }
}