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
    }
}
