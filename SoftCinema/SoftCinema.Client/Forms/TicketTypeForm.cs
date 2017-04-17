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

namespace SoftCinema.Client.Forms
{
    public partial class TicketTypeForm : Form
    {
        public TicketTypeForm()
        {
            InitializeComponent();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            SelectSeatsForm selectSeatsForm = new SelectSeatsForm(TicketForm.Screening, calculate_Quantity());
            selectSeatsForm.Show();
        }

        private int calculate_Quantity()
        {
            var children = (int) this.childrenQuantityComboBox.SelectedValue;
            var regular = (int) this.regularQuantityComboBox.SelectedValue;
            var seniors = (int) this.seniorsQuantityComboBox.SelectedValue;
            var students = (int) this.studentsQuantityComboBox.SelectedValue;

            return regular + children + seniors + students;
        }
    }
}