using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class LoginForm : ContentHolderForm
    {
        private readonly UserService userService;

        public LoginForm()
        {
            this.userService = new UserService();
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

            try
            {
                if (userService.isUsernamePasswordMatching(username, password) && !userService.IsUserDeleted(username))
                {
                    AuthenticationManager.Login(userService.GetUser(username));
                    MessageBox.Show(Constants.SuccessMessages.SuccessfulLogin);

                    var mainForm = (SoftCinemaForm)((Button)sender).Parent.Parent.Parent;
                    mainForm.RenderTopPanelForm();
                    mainForm.RenderSideBar();
                    SoftCinemaForm.SetContentHolderForm(new HomeForm());
                }
                else
                {
                    MessageBox.Show(Constants.ErrorMessages.InvalidLogin);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.ErrorMessages.InvalidLogin);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!userService.isUsernameExisting(this.usernameTextBox.Text))
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = Constants.ErrorMessages.NoSuchUserExisting;
            }
            else if (userService.isUsernameExisting(this.usernameTextBox.Text) && userService.IsUserDeleted(this.usernameTextBox.Text))
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = Constants.ErrorMessages.UserIsInactive;
            }
            else
            {
                this.usernameInfoLabel.Hide();
            }
        }
    }
}