using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Models;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Forms
{
    public partial class TicketTypeForm : Form
    {
        private double _price = 0;
        private bool areTicketsMoreThanMaxCount(int ticketsQuantity)
        {
            if (ticketsQuantity>Constants.MaxTicketCount)
            {
                return true;
            }
            return false;
        }
        public TicketTypeForm()
        {
            InitializeComponent();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            var ticketsQuantity = calculate_Quantity();
            if (areTicketsMoreThanMaxCount(ticketsQuantity) == false )
            {
                if (ticketsQuantity==0)
                {
                    this.ticketLimit.Text = Constants.WarningMessages.noTicketsSelected;
                    this.ticketLimit.Show();
                }
                else
                {
                    SelectSeatsForm selectSeatsForm = new SelectSeatsForm(TicketForm.Screening, ticketsQuantity);
                    selectSeatsForm.Show();
                }
               
            }
            else
            {
                this.ticketLimit.Text = Constants.WarningMessages.MoreThanMaxTicketCountPurchased;
                this.ticketLimit.Show();
            }
        }

        private int calculate_Quantity()
        {
            var children = int.Parse(this.childrenQuantityComboBox.SelectedItem.ToString()) ;
            var regular = int.Parse(this.regularQuantityComboBox.SelectedItem.ToString());
            var seniors = int.Parse(this.seniorsQuantityComboBox.SelectedItem.ToString());
            var students = int.Parse(this.studentsQuantityComboBox.SelectedItem.ToString());

            return regular + children + seniors + students;
        }

        private void TicketTypeForm_Load(object sender, EventArgs e)
        {
            this.regularQuantityComboBox.SelectedIndex = 0;
            this.childrenQuantityComboBox.SelectedIndex = 0;
            this.seniorsQuantityComboBox.SelectedIndex = 0;
            this.studentsQuantityComboBox.SelectedIndex = 0;
            this.ticketLimit.Hide();
        }

        private void regularQuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var regularCount = int.Parse(this.regularQuantityComboBox.SelectedItem.ToString());
           
        }
    }
}