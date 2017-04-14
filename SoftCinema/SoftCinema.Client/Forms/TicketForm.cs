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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'softCinemaDataSet2.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.softCinemaDataSet2.Movies);
            // TODO: This line of code loads data into the 'softCinemaDataSet1.Cinemas' table. You can move, or remove it, as needed.
            this.cinemasTableAdapter.Fill(this.softCinemaDataSet1.Cinemas);
            // TODO: This line of code loads data into the 'softCinemaDataSet.Towns' table. You can move, or remove it, as needed.
            this.townsTableAdapter.Fill(this.softCinemaDataSet.Towns);

        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectSeats_Click(object sender, EventArgs e)
        {
            TicketTypeForm ticketTypeForm = new TicketTypeForm();
            ticketTypeForm.TopLevel = false;
            ticketTypeForm.AutoScroll = true;
           
            this.Owner.Controls.Add(ticketTypeForm);
            ticketTypeForm.Show();
        }
    }
}
