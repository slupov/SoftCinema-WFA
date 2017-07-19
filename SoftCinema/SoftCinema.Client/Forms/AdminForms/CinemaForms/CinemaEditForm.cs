using SoftCinema.Models;
using SoftCinema.Services;
using SoftCinema.Services.Utilities;
using System;
using System.Windows.Forms;

namespace SoftCinema.Client.Forms.AdminForms.CinemaForms
{
    public partial class CinemaEditForm : Form
    {
        private readonly Cinema cinema;
        private readonly CinemaService cinemaService;

        public CinemaEditForm(Cinema cinema)
        {
            this.cinemaService = new CinemaService();
            this.cinema = cinema;
            InitializeComponent();
        }

        private void CinemaEditForm_Load(object sender, EventArgs e)
        {
            this.CinemaExistsLabel.Hide();
            this.TownName.Text = cinema.Town.Name;
            this.CinemaName.Text = cinema.Name;
        }

        private void TownCinemaName_TextChanged(object sender, EventArgs e)
        {
            if (cinemaService.IsCinemaExistingByTownName(this.CinemaName.Text, this.TownName.Text) && (this.CinemaName.Text != cinema.Name || this.TownName.Text != cinema.Town.Name))
            {
                this.CinemaExistsLabel.Show();
                this.CinemaExistsLabel.Text = Constants.WarningMessages.CinemaExists;
            }
            else
            {
                this.CinemaExistsLabel.Hide();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.WarningMessages.UnsavedChanges, Constants.GoBackPrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CinemasForm cinemasForm = new CinemasForm();
                cinemasForm.TopLevel = false;
                cinemasForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(cinemasForm);
                cinemasForm.Show();
            }
        }

        private void EditCinemaButton_Click(object sender, EventArgs e)
        {
            string oldCinemaName = cinema.Name;
            string oldTownName = cinema.Town.Name;
            string newCinemaName = this.CinemaName.Text;
            string newTownName = this.TownName.Text;
            try
            {
                cinemaService.UpdateCinema(oldCinemaName, oldTownName, newCinemaName, newTownName);
                MessageBox.Show(Constants.SuccessMessages.CinemaUpdatedSuccessfully);
                CinemasForm cinemasForm = new CinemasForm();
                cinemasForm.TopLevel = false;
                cinemasForm.AutoScroll = true;
                this.Hide();
                ((Button)sender).Parent.Parent.Controls.Add(cinemasForm);
                cinemasForm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.ErrorMessages.CinemaUpdateErrorMessage);
            }
        }

        private void DeleteCinemaButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.DeleteCinemaMessage, Constants.CategoryDeletePrompt, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    cinemaService.RemoveCinema(cinema.Name, cinema.Town.Name);
                    MessageBox.Show(Constants.SuccessMessages.CinemaDeletedSuccessfully);
                    CinemasForm cinemasForm = new CinemasForm();
                    cinemasForm.TopLevel = false;
                    cinemasForm.AutoScroll = true;
                    this.Hide();
                    ((Button)sender).Parent.Parent.Controls.Add(cinemasForm);
                    cinemasForm.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show(Constants.ErrorMessages.CinemaDeleteMessage);
                }
            }
        }

        private void EditScreeningsButton_Click(object sender, EventArgs e)
        {
            Cinema cinemaWithScreenings = cinemaService.GetCinemaWithScreenings(cinema.Id);
            SelectScreeningForm screeningsForm = new SelectScreeningForm(cinemaWithScreenings);
            screeningsForm.TopLevel = false;
            screeningsForm.AutoScroll = true;
            this.Hide();
            ((Button)sender).Parent.Parent.Controls.Add(screeningsForm);
            screeningsForm.Show();
        }
    }
}