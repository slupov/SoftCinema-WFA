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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

            string[] categories = CategoryService.GetCategoriesNames();
            this.CategoriesList.Items.AddRange(categories);
            
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

        private void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = CategoryService.GetCategory(this.CategoriesList.Text.ToString());
            CategoryEditForm categoryEditForm = new CategoryEditForm(category);
            categoryEditForm.TopLevel = false;
            categoryEditForm.AutoScroll = true;
            this.Hide();
            ((ComboBox)sender).Parent.Parent.Controls.Add(categoryEditForm);
            categoryEditForm.Show();
        }
    }
}
