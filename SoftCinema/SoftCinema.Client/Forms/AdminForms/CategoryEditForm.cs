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
    public partial class CategoryEditForm : Form
    {
        private Category category;

        public CategoryEditForm(Category category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void CategoryEditForm_Load(object sender, EventArgs e)
        {
            string[] addedMovies = CategoryService.GetMoviesNameAndYear(category.Name);
            string[] notAddedMovies = CategoryService.GetMoviesNotInCategory(category.Name);
            this.CategoryAddedMovies.Items.AddRange(addedMovies);
            this.CategoryNotAddedMovies.Items.AddRange(notAddedMovies);
            this.CategoryNameTextBox.Text = category.Name;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.TopLevel = false;
            categoriesForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(categoriesForm);
            categoriesForm.Show();
        }
    }
}
