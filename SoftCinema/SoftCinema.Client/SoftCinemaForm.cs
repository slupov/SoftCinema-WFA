using SoftCinema.Client.Forms;
using System;
using System.Windows.Forms;

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
        }

        private void ContentHolder_Paint(object sender, PaintEventArgs e)
        {
        }

        private void UpperPanel_Paint(object sender, PaintEventArgs e)
        {
        }
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

      
    }
}