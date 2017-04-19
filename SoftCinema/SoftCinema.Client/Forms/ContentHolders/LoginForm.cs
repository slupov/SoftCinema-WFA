using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class LoginForm : ContentHolderForm
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

            if (UserService.Validations.isUsernamePasswordMatching(username, password) && !UserService.Validations.IsUserDeleted(username))
            {
                AuthenticationManager.Login(UserService.GetUser(username));
                MessageBox.Show(Constants.SuccessMessages.SuccessfulLogin);

                TopPanelForm.ShowGreetings();
                //Refresh main form's sidebar
                var mainForm = (SoftCinemaForm)((Button) sender).Parent.Parent.Parent;
                mainForm.RenderSideBar();
                //Redirect to home page view
                SoftCinemaForm.SetContentHolderForm(new HomeForm());
            }
            else
            {
                MessageBox.Show(Constants.ErrorMessages.InvalidLogin);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (!UserService.Validations.isUsernameExisting(this.usernameTextBox.Text))
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = Constants.ErrorMessages.NoSuchUserExisting;
            }

            else if (UserService.Validations.isUsernameExisting(this.usernameTextBox.Text) && UserService.Validations.IsUserDeleted(this.usernameTextBox.Text))
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = Constants.ErrorMessages.UserIsInactive;
            }

            else
            {
                this.usernameInfoLabel.Hide();
            }
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}