using System;
using System.Windows.Forms;
using SoftCinema.Service;

namespace SoftCinema.Client.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            if (instance == null)
                InitializeComponent();
        }

        private static LoginForm instance;


        public static LoginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;

            //TODO
            if (UserService.Validations.isUsernamePasswordMatching(username, password))
            {
                MessageBox.Show("YES");
            }
            else
            {
                MessageBox.Show("NO");
            }
            
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.Validations.isUsernameExisting(this.usernameTextBox.Text))
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = "No such user!";
            }
            else
            {
                this.usernameInfoLabel.Hide();
            }
        }
    }
}