using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void UserEditButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.TopLevel = false;
            usersForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(usersForm);
            usersForm.Show();
        }

        private void EditCategoriesButton_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.TopLevel = false;
            categoriesForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(categoriesForm);
            categoriesForm.Show();
        }

        private void EditCinemasButton_Click(object sender, EventArgs e)
        {
            CinemasForm cinemasForm = new CinemasForm();
            cinemasForm.TopLevel = false;
            cinemasForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(cinemasForm);
            cinemasForm.Show();
        }
    }
}
