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
using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms
{
    public partial class UserDetailsForm : Form
    {
        private  User user;

        public UserDetailsForm(User user)
        {

            this.user = user;
            InitializeComponent();
            
        }

        private void UserList_Load(object sender, System.EventArgs e)
        {
            this.RoleComboBox.Items.AddRange(RoleProcessor.GetRoles().ToArray());
            if (this.RoleComboBox.Items.Count == 0)
            {
                this.RoleComboBox.Text = "(no roles)";

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

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.UsernameTextBox.Text.Length > 25 || this.UsernameTextBox.Text.Length < 3)
            {
                this.UsernameInfoLabel.Show();
                this.UsernameInfoLabel.Text = "Username must be in range 3-25 characters";
            }
            else
            {
                if (UserService.Validations.isUsernameExisting(this.UsernameTextBox.Text) && this.UsernameTextBox.Text != user.Username)
                {
                    this.UsernameInfoLabel.Show();
                    this.UsernameInfoLabel.Text = "Username already taken";
                }
                else
                {
                    this.UsernameInfoLabel.Hide();
                }
            }
        }

        
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.Validations.isEmailValid(this.EmailTextBox.Text))
            {
                this.EmailInfoLabel.Show();
                this.EmailInfoLabel.Text = "Email is invalid";
            }
            else if(UserService.Validations.IsEmailTaken(this.EmailTextBox.Text) && this.EmailTextBox.Text!=user.Email)
            { 
                this.EmailInfoLabel.Show();
                this.EmailInfoLabel.Text = "Email is already taken";
            }
            else
            {
                this.EmailInfoLabel.Hide();
            }
        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!UserService.Validations.isPhoneValid(this.PhoneNumberTextBox.Text))
            {
                this.PhoneNumberInfoLabel.Show();
                this.PhoneNumberInfoLabel.Text = "Phone must be in 08[789]... format!";
            }
            else
            {
                this.PhoneNumberInfoLabel.Hide();
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            string oldUsername = user.Username;
            string newUsername = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string phoneNumber = PhoneNumberTextBox.Text;
            Role role =(Role)Enum.Parse(typeof(Role), RoleComboBox.Text);
            bool isDeleted = NoRadioButton.Checked;
            try
            {
                UserService.UpdateUser(oldUsername, newUsername, email, phoneNumber, role,isDeleted);
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

        //private void UserDeleteButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DialogResult dialogResult = MessageBox.Show("Are you sure you wand to delete this user?", "User deletion", MessageBoxButtons.YesNo);
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            UserService.DeleteUser(user.Username);
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
