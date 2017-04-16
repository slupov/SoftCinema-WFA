using SoftCinema.Client.Forms;
using SoftCinema.Models;
using SoftCinema.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCinema.Client.Utilities.CustomTools
{
    public class MoviePosterLink : GroupBox
    {
        private static Font _normalFont = new Font("Arial", 10F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        private static Color _back = System.Drawing.Color.Gray;
        private static Color _border = System.Drawing.Color.Black;
        private static Color _activeBorder = System.Drawing.Color.Red;
        private static Color _fore = System.Drawing.Color.White;

        private static Padding _margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        private static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

        private static Size _minSize = new System.Drawing.Size(100, 30);
        private PictureBox _pictureBox = new PictureBox();
        private Button _showDetailsButton = new Button() { Text = "Details"};

        private Movie _movie { get; set; }

        private bool _active;

        public MoviePosterLink(string movieName) : base()
        {
            base.Font = _normalFont;
            base.BackColor = _back;
            base.ForeColor = _fore;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
            base.MinimumSize = _minSize;

            var currentMovie = MovieService.GetMovie(movieName);
            this._movie = currentMovie;

            this._pictureBox.Image = ImageService.byteArrayToImage(currentMovie.Image.Content);

            this._pictureBox.Size = new Size(141, 190);
            //this._pictureBox.Location = new Point(50, 50);
            this._showDetailsButton.Location = new Point(this._pictureBox.Location.X, this._pictureBox.Location.Y + 10);
            setDetailsButtonClickEvent();

            this.Controls.Add(this._showDetailsButton);
            this.Controls.Add(this._pictureBox);


        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        public void SetStateActive()
        {
            _active = true;
        }

        public void SetStateNormal()
        {
            _active = false;
        }

        private void setDetailsButtonClickEvent()
        {
            _showDetailsButton.Click += new EventHandler(_showDetailsButton_Click);
        }

        private void _showDetailsButton_Click(object sender, System.EventArgs e)
        {
            MovieForm movieForm = new MovieForm(this._movie);
            movieForm.Show();
        }
    }
}
