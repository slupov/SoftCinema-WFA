using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class UsersForm : Form
    {
        private readonly UserService userService;

        public UsersForm()
        {
            this.userService = new UserService();
            InitializeComponent();
            SearchTextBox.ForeColor = SystemColors.GrayText;
            SearchTextBox.Text = Constants.SearchPlaceholder;
            this.SearchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
        }

        private void SearchTextBox_Leave(object sender, EventArgs e)
        {
            if (SearchTextBox.Text.Length == 0)
            {
                SearchTextBox.Text = Constants.SearchPlaceholder;
                SearchTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == Constants.SearchPlaceholder)
            {
                SearchTextBox.Text = "";
                SearchTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void UserList_Search(object sender, System.EventArgs e)
        {
            if ((SearchTextBox.Text != null || SearchTextBox.Text != "") && (SearchTextBox.Text != Constants.SearchPlaceholder && SearchTextBox.ForeColor != SystemColors.GrayText))
            {
                string[] usernames = userService.GetUsernames().Where(s => s.ToLower().Contains(SearchTextBox.Text.ToLower())).ToArray();
                UserList.Items.Clear();
                UserList.Items.AddRange(usernames);
            }
            else
            {
                string[] usernames = userService.GetUsernames();
                UserList.Items.Clear();
                UserList.Items.AddRange(usernames);
            }
        }

        private void UserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (UserList.SelectedItem == null)
            {
                return;
            }
            ListBox lb = (ListBox)sender;
            string username = lb.SelectedItem.ToString();
            User user = userService.GetUser(username);
            UserDetailsForm userForm = new UserDetailsForm(user);
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            this.Hide();
            ((ListBox)sender).Parent.Parent.Controls.Add(userForm);
            userForm.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminMenuForm adminMenuForm = new AdminMenuForm();
            adminMenuForm.TopLevel = false;
            adminMenuForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(adminMenuForm);
            adminMenuForm.Show();
        }
    }
}