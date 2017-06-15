using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.AdminForms;
using SoftCinema.Client.Forms.AdminForms.UserForms;
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms
{
    public partial class UserDetailsForm : Form
    {
        private readonly User user;
        private readonly UserService userService;

        public UserDetailsForm(User user)
        {
            this.userService = new UserService();
            this.user = user;
            InitializeComponent();
            
        }

        private void UserList_Load(object sender, System.EventArgs e)
        {
            this.RoleComboBox.Items.AddRange(RoleProcessor.GetRoles().ToArray());
            if (this.RoleComboBox.Items.Count == 0)
            {
                this.RoleComboBox.Text = Constants.WarningMessages.NoRoles;

            }
            if (user.IsDeleted)
            {
                NoRadioButton.Checked = true;
            }
            else
            {
                YesRadioButton.Checked = true;
            }
            UsernameTextBox.Text = user.Username;
            EmailTextBox.Text = user.Email;
            PhoneNumberTextBox.Text = user.PhoneNumber;
            RoleComboBox.Text = user.Role.ToString();

            this.PhoneNumberInfoLabel.Visible = false;
            this.EmailInfoLabel.Visible = false;
            this.UsernameInfoLabel.Visible = false;

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!InputDataChecker.CheckStringMinMaxLength(this.UsernameTextBox.Text,Constants.MinUsernameLength,Constants.MaxUsernameLength))
            {
                this.UsernameInfoLabel.Show();
                this.UsernameInfoLabel.Text = Constants.WarningMessages.UsernameFormat;
            }
            else
            {
                if (userService.isUsernameExisting(this.UsernameTextBox.Text) && this.UsernameTextBox.Text != user.Username)
                {
                    this.UsernameInfoLabel.Show();
                    this.UsernameInfoLabel.Text = Constants.WarningMessages.UsernameTaken;
                }
                else
                {
                    this.UsernameInfoLabel.Hide();
                }
            }
        }
        
        
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!userService.isEmailValid(this.EmailTextBox.Text))
            {
                this.EmailInfoLabel.Show();
                this.EmailInfoLabel.Text = Constants.WarningMessages.InvalidEmail;
            }
            else if(userService.IsEmailTaken(this.EmailTextBox.Text) && this.EmailTextBox.Text!=user.Email)
            { 
                this.EmailInfoLabel.Show();
                this.EmailInfoLabel.Text = Constants.WarningMessages.EmailTaken;
            }
            else
            {
                this.EmailInfoLabel.Hide();
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!userService.isPhoneValid(this.PhoneNumberTextBox.Text))
            {
                this.PhoneNumberInfoLabel.Show();
                this.PhoneNumberInfoLabel.Text = Constants.WarningMessages.PhoneFormat;
            }
            else
            {
                this.PhoneNumberInfoLabel.Hide();
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string oldUsername = user.Username;
                string newUsername = UsernameTextBox.Text;
                string email = EmailTextBox.Text;
                string phoneNumber = PhoneNumberTextBox.Text;
                Role role = (Role)Enum.Parse(typeof(Role), RoleComboBox.Text);
                bool isDeleted = NoRadioButton.Checked;
                userService.UpdateUser(oldUsername, newUsername, email, phoneNumber, role,isDeleted);
                MessageBox.Show(Constants.SuccessMessages.UserUpdatedSuccessfully);
                UsersForm usersForm = new UsersForm();
                usersForm.TopLevel = false;
                usersForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(usersForm);
                usersForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.ErrorMessages.UserUpdateErrorMesage);
            }
           
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.UnsavedChanges,Constants.GoBackPrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                UsersForm usersForm = new UsersForm();
                usersForm.TopLevel = false;
                usersForm.AutoScroll = true;
                this.Hide();
                ((Button) sender).Parent.Parent.Controls.Add(usersForm);
                usersForm.Show();
            }
        }

        private void EditTickets_Click(object sender, EventArgs e)
        {
            EditUserTicketsForm ticketsForm = new EditUserTicketsForm(user);
            ticketsForm.TopLevel = false;
            ticketsForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(ticketsForm);
            ticketsForm.Show();
        }



        //private void UserDeleteButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Are you sure you wand to delete this user?", "User deletion", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            UserService.DeleteUser(user.Username);x
        //            MessageBox.Show(Constants.SuccessMessages.DeleteUserSuccess);
        //            UsersForm usersForm = new UsersForm();
        //            usersForm.TopLevel = false;
        //            usersForm.AutoScroll = true;
        //            this.Hide();
        //            ((Button)sender).Parent.Parent.Controls.Add(usersForm);
        //            usersForm.Show();
        //        }


        //    }
        //    catch (Exception exception)
        //    {
        //        MessageBox.Show(Constants.ErrorMessages.UserDeleteFail);
        //    }


        //}


    }
}
