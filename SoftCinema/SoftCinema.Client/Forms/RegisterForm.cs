using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Service;

namespace SoftCinema.Client.Forms
{
    public partial class RegisterForm : Form
    {
        private static RegisterForm instance;

        public static RegisterForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegisterForm();
                }
                return instance;
            }
        }

        public RegisterForm()
        {
            if (instance == null)
            {
                InitializeComponent();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }


        private void registerButton_Click(object sender, EventArgs e)
        {
            var username = this.usernameTextBox.Text;
            var password = this.passwordTextBox.Text;
            var repeatPassword = this.repeatPasswordTextBox.Text;
            var email = this.emailTextBox.Text;
            var phone = this.phoneNumberTextBox.Text;

            bool isDataValid = UserService.isUserValid(username, password, repeatPassword, email, phone);

            if (isDataValid)
            {
                UserService.AddUser(username, password, repeatPassword, email, phone);
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text.Length > 25  || this.usernameTextBox.Text.Length < 3)
            {
                this.usernameInfoLabel.Show();
                this.usernameInfoLabel.Text = "Username must be in range 3-25 characters";
            }
            else
            {
                if (UserService.isUsernameExisting(this.usernameTextBox.Text))
                {
                    this.usernameInfoLabel.Show();
                    this.usernameInfoLabel.Text = "Username already taken";
                }
                else
                {
                    this.usernameInfoLabel.Hide();
                }
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.isPasswordValid(this.passwordTextBox.Text))
            {
                this.passwordInfoLabel.Show();
                this.passwordInfoLabel.Text = "Password length must be in range 3-25 characters!";
            }
            else
            {
                this.passwordInfoLabel.Hide();
            }
        }

        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.repeatPasswordTextBox.Text != this.passwordTextBox.Text)
            {
                this.rptpasswordInfoLabel.Show();
                this.rptpasswordInfoLabel.Text = "Passwords do no match";
            }
            else
            {
                this.rptpasswordInfoLabel.Hide();
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.isEmailValid(this.emailTextBox.Text))
            {
                this.emailInfoLabel.Show();
                this.emailInfoLabel.Text = "Email is invalid";
            }
            else
            {
                this.emailInfoLabel.Hide();
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.isPhoneValid(this.phoneNumberTextBox.Text))
            {
                this.phoneInfoLabel.Show();
                this.phoneInfoLabel.Text = "Phone must be in 08[789]... format!";
            }
            else
            {
                this.phoneInfoLabel.Hide();
            }
        }


        private void emailInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void rptpasswordInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneInfoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}