using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;
using SoftCinema.Services;
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
    public partial class MoviesForm : Form
    {
        private ICollection<Movie> Movies { get; set; }
        private ICollection<MoviePosterLink> MoviePosterLinks { get; set; }
        private GroupBox MoviePostersSlider { get; set; }

        public MoviesForm()
        {
            InitializeComponent();
            this.MoviePostersSlider = new GroupBox();

            Movies = MovieService.GetAllMovies();
            this.MoviePosterLinks = new List<MoviePosterLink>();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {

            //implement slider logic
            foreach (var movie in Movies)
            {
                //populate MoviePosterLinks
                var currentPosterLink = new MoviePosterLink(movie.Name);
                this.MoviePosterLinks.Add(currentPosterLink);
            }

            VisualizePosters();
        }
        
        //populates Slider GroupBox
        private void VisualizePosters()
        {
            foreach (var item in MoviePosterLinks)
            {
                MoviePostersSlider.Controls.Add(item);
            }
        }
    }
}
