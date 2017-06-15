using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.AdminForms.CinemaForms;
using SoftCinema.Models;
using SoftCinema.Services;

namespace SoftCinema.Client.Forms.AdminForms
{
    public partial class CinemasForm : Form
    {

        private readonly CinemaService cinemaService;
        private readonly TownService townService;

        public CinemasForm()
        {
            this.townService = new TownService();
            this.cinemaService = new CinemaService();
            InitializeComponent();
        }

        private void CinemasForm_Load(object sender, EventArgs e)
        {
            this.TownsList.Items.AddRange(townService.GetTownsNames());
        }

        private void TownsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CinemasList.Items.Clear();
            this.CinemasList.Items.AddRange(cinemaService.GetCinemasNamesBySelectedTown(TownsList.SelectedItem.ToString()));
        }

        private void CinemasList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cinema cinema = cinemaService.GetCinema(this.CinemasList.SelectedItem.ToString(),
                this.TownsList.SelectedItem.ToString());
            CinemaEditForm cinemaeditForm = new CinemaEditForm(cinema);
            cinemaeditForm.TopLevel = false;
            cinemaeditForm.AutoScroll = true;
            this.Hide();
            ((ComboBox)sender).Parent.Parent.Controls.Add(cinemaeditForm);
            cinemaeditForm.Show();
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

        private void AddCinemaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
