using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SoftCinema.Client.Forms;
using SoftCinema.Client.Forms.AdminForms.MovieForms;
using SoftCinema.Client.Forms.ContentHolders;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.AdminForms.MovieForms
{
    public partial class MovieForm : ContentHolderForm
    {
        private string _townName { get; set; }
        private string _cinemaName { get; set; }
        private string _movieName { get; set; }
        //        private ICollection<Screening> _screenings { get; set; }
        private ICollection<Movie> _movies { get; set; }

        private readonly ImageService imageService;
        private readonly TownService townService;
        private readonly CinemaService cinemaService;
        private readonly ScreeningService screeningService;
       

        public Movie _movie { get; set; }

        public MovieForm(Movie movie)
        {
            this.imageService = new ImageService();
            this.townService = new TownService();
            this.cinemaService = new CinemaService();
            this.screeningService = new ScreeningService();
            InitializeComponent();

            
            System.Drawing.Image image = imageService.byteArrayToImage(movie.Image.Content);
            this._movie = movie;
            this.pictureBox.Image = imageService.ScaleImage(image,142,224);
            this.titleBox.Text = _movie.Name;
            this.genreBox.Text = string.Join(", ", this._movie.Categories.Select(c => c.Name));
            this.lengthBox.Text = _movie.Length.ToString() + " minutes";
            this.yearBox.Text = _movie.ReleaseYear.ToString();
            this.ratingBox.Text = _movie.Rating.ToString() + " / 10";
            this.directorBox.Text = _movie.DirectorName;
            this.ageRestrictionBox.Text = _movie.AgeRestriction.ToString();
            this.castBox.Text = string.Join(",", this._movie.Cast.Select(c => c.Name));
            this.synopsisBox.Text = _movie.Synopsis;
            this.townBox.Text = "Select town";
            this.townBox.Items.AddRange(townService.GetTownsNames());
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void actorsLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoriesLabel_Click(object sender, EventArgs e)
        {

        }

        private void townBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cinemaComboBox.Text = "Select cinema";
            this.cinemaComboBox.Items.Clear();
            this.dateBox.Text = "";
            this.dateBox.Items.Clear();
            this.hourBox.Text = "";
            this.hourBox.Items.Clear();
            this._townName = this.townBox.SelectedItem.ToString();
            this._movieName = this._movie.Name;
            var cinemaNames = cinemaService.GetCinemasByMovieAndTown(this._movieName,this._townName);

            this.cinemaComboBox.Items.AddRange(cinemaNames);

            if (this.cinemaComboBox.Items.Count == 0)
            {
                this.cinemaComboBox.Text = "(no cinemas)";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            this.ticketsButton.Enabled = false;

        }

        private void ticketsButton_Click(object sender, EventArgs e)
        {

            string selectedDate = this.dateBox.SelectedItem.ToString();
            string selectedTime = this.hourBox.SelectedItem.ToString();

            DateTime screeningDate = screeningService.GetDateTimeFromDateAndTime(selectedDate, selectedTime);
            //var screeningDate = new DateTime(2017, 4, 21, 16, 0, 0); //hardcode
            
            TicketForm.Screening= screeningService.GetScreening(this._townName, this._cinemaName, this._movieName, screeningDate);

            TicketTypeForm ticketTypeForm = new TicketTypeForm();
            ticketTypeForm.TopLevel = false;
            ticketTypeForm.AutoScroll = true;
            this.Parent.Controls.Add(ticketTypeForm);
            ticketTypeForm.Show();
            this.Hide();
        }

        private void cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateBox.Text = "Select date";
            this.dateBox.Items.Clear();
            this._cinemaName = this.cinemaComboBox.SelectedItem.ToString();
            var dates = screeningService.GetAllDatesForMovieInCinema(this._townName,
                this._cinemaName, this._movieName);
            this.dateBox.Items.AddRange(dates);
        }

        private void dateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hourBox.Text = "Select time";
            this.hourBox.Items.Clear();
            var date = this.dateBox.SelectedItem.ToString();

            var hours = screeningService.GetHoursForMoviesByDate(this._townName,
                this._cinemaName, this._movieName, date);
            ;
            this.hourBox.Items.AddRange(hours);
        }

     
        private void hourBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.ticketsButton.Enabled = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            MovieListForm movieForm = new MovieListForm();
            movieForm.TopLevel = false;
            movieForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(movieForm);
            movieForm.Show();
        }
    }
}
