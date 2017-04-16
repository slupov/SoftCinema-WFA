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
        private MoviePostersSlider _moviePostersSlider { get; set; }

        public MoviesForm()
        {
            InitializeComponent();
            this._moviePostersSlider = new MoviePostersSlider();

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
                _moviePostersSlider.Controls.Add(item);
            }

            this.Controls.Add(_moviePostersSlider);
        }
    }
}
