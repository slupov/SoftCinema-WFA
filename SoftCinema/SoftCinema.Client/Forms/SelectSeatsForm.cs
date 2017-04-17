using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;

namespace SoftCinema.Client.Forms
{
    public partial class SelectSeatsForm : Form
    {
        private Screening _screening { get; set; }
        private AuditoriumSeatsSchema _seatsSchema { get; set; }

        public SelectSeatsForm(Screening screening)
        {
            this._screening = screening;
            InitializeComponent();
        }

        private void SelectSeatsForm_Load(object sender, EventArgs e)
        {
            InitializeSeatsSchema();
            this.Controls.Add(this._seatsSchema);
        }

        private void InitializeSeatsSchema()
        {
            var startingPoint = new Point(this.freeSeatsLabel.Location.X, this.freeSeatsLabel.Location.Y + 100);
            this._seatsSchema = new AuditoriumSeatsSchema(this._screening.Auditorium, startingPoint);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
        }
    }
}