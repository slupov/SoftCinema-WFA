using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Forms.EmployeeForms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningRow : Panel
    {
        private Screening _screening { get; set; }
        private int _id { get; set; }
        private Color _back { get; set; }

        public ScreeningRow(Screening screening, int id)
        {
            this._back = Color.FromArgb(255, 240, 240, 240);
            this.ForeColor = Color.Black;

            this._screening = screening;
            this._id = id;

            Label rowText = new Label();
            rowText.Text = $"{id}." +
                           string.Join(" ", 5) +
                           $"Auditorium: {_screening.Auditorium.Number}" +
                           string.Join(" ", 5) + $"DateTime: {this._screening.Start.ToString("f")}";

            this.Controls.Add(rowText);
        }

        protected override void OnClick(EventArgs e)
        {
            var details = new ShowScreeningReservationsForm(_screening);
            details.Show();

            base.OnClick(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackColor = this._back;
            base.OnMouseLeave(e);
        }
    }
}