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
            UsernameTextBox.Text = user.Username;
            EmailTextBox.Text = user.Email;
            PhoneNumberTextBox.Text = user.PhoneNumber;
            RoleTextBox.Text = user.Role.ToString();

        }
    }
}
