using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class CreateCategoryForm : Form
    {
        public CreateCategoryForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All your unsaved changes will be deleted.", "Go back?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                CategoriesForm categoriesForm = new CategoriesForm();
                categoriesForm.TopLevel = false;
                categoriesForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(categoriesForm);
                categoriesForm.Show();
            }
        }

        private void CreateCategoryForm_Load(object sender, EventArgs e)
        {
            this.CategoryExistsLabel.Hide();
            string[] movies = MovieService.GetMoviesNameAndYear();
         
          
            this.MoviesCheckedListBox.Items.AddRange(movies);
            
        }

        private void CreateCategoryButton_Click(object sender, EventArgs e)
        {
            string categoryName = CategoryNameTextBox.Text;
            List<Tuple<string, int>> movies = GetAddedMovies();
            try
            {
                CategoryService.AddCategoryWithMovies(categoryName,movies);
                MessageBox.Show(Constants.SuccessMessages.CategoryCreatedSuccessfully);
                CategoriesForm categoriesForm = new CategoriesForm();
                categoriesForm.TopLevel = false;
                categoriesForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(categoriesForm);
                categoriesForm.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.ErrorMessages.CategoryCreateErrorMessage);
            }
        }

        private List<Tuple<string, int>> GetAddedMovies()
        {
            List<Tuple<string, int>> movies = new List<Tuple<string, int>>();
            foreach (var m in MoviesCheckedListBox.SelectedItems)
            {
                int yearIndex = m.ToString().LastIndexOf(",");
                string movieYearString = m.ToString().Substring(yearIndex + 1).Split(new char[] { '\"' }).First();
                int movieYear = int.Parse(movieYearString);
                string movieName = m.ToString().Substring(1, m.ToString().Length - movieYearString.Length - 3);
                Tuple<string, int> movie = new Tuple<string, int>(movieName, movieYear);
                movies.Add(movie);
            }
            return movies;
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {

            if (CategoryService.IsCategoryExisting(this.CategoryNameTextBox.Text) )
            {
                this.CategoryExistsLabel.Show();
                this.CategoryExistsLabel.Text = "Category already exists!";
            }



            else
            {
                this.CategoryExistsLabel.Hide();
            }
        }
    }
}
