using System;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Models;

namespace SoftCinema.Client.Forms.ContentHolders
{
    public partial class SelectSeatsForm : ContentHolderForm
    {
        private Screening _screening { get; set; }
        private int _seatCount { get; set; }
        private AuditoriumSeatsSchema _seatsSchema { get; set; }

        public SelectSeatsForm(Screening screening, int seatCount)
        {
            this._screening = screening;
            this._seatCount = seatCount;
            InitializeComponent();
        }

        private void SelectSeatsForm_Load(object sender, EventArgs e)
        {
            InitializeSeatsSchema();
            this.Controls.Add(this._seatsSchema);
        }

        private void InitializeSeatsSchema()
        {
            var startingPoint = new Point(this.freeSeatsLegendLabel.Location.X,
                this.freeSeatsLegendLabel.Location.Y + 30);
            int width = this.purchaseButton.Location.X + this.purchaseButton.Size.Width - startingPoint.X;

            this._seatsSchema = new AuditoriumSeatsSchema(this._screening.Auditorium, startingPoint, width, this._seatCount);
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
        }

     
        private void back_Click(object sender, EventArgs e)
        {
            var second = ((Button)sender).Parent.Parent.Controls[1];
            second.Show();
            this.Hide();
        }
    }
}