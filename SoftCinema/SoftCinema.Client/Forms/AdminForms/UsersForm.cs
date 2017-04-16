using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
         
        }

        private void UserList_Load(object sender, System.EventArgs e)
        {
            string[] usernames = UserService.GetUsernames();            
            UserList.Items.AddRange(usernames);
            
            
        }

        private void UserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox) sender;
            string username = lb.SelectedItem.ToString();
            User user = UserService.GetUser(username);
            UserDetailsForm userForm = new UserDetailsForm(user);
            userForm.TopLevel = false;
            userForm.AutoScroll = true;
            this.Hide();
            ((ListBox)sender).Parent.Parent.Controls.Add(userForm);
            userForm.Show();
        }
    }
}
