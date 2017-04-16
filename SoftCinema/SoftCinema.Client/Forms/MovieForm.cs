using SoftCinema.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms
{
    public partial class MovieForm : Form
    {
        public Movie _movie { get; set; }

        public MovieForm(Movie movie)
        {
            InitializeComponent();
            this._movie = movie;

            this.titleBox.Text = _movie.Name;
            //etc.
        }

        private void actorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {

        }
    }
}
