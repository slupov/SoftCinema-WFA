using SoftCinema.Models;
using SoftCinema.Services;
using System;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoryService categoryService;

        public CategoriesForm()
        {
            this.categoryService = new CategoryService();
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            string[] categories = categoryService.GetCategoriesNames();
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
            Category category = categoryService.GetCategory(this.CategoriesList.Text.ToString());
            CategoryEditForm categoryEditForm = new CategoryEditForm(category);
            categoryEditForm.TopLevel = false;
            categoryEditForm.AutoScroll = true;
            this.Hide();
            ((ComboBox)sender).Parent.Parent.Controls.Add(categoryEditForm);
            categoryEditForm.Show();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            CreateCategoryForm createCategoryForm = new CreateCategoryForm();
            createCategoryForm.TopLevel = false;
            createCategoryForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(createCategoryForm);
            createCategoryForm.Show();
        }
    }
}