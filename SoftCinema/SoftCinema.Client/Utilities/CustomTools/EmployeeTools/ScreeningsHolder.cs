using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningsHolder : Panel
    {
        private List<Screening> _screenings { get; set; }

        public ScreeningsHolder(Point startingPoint, List<Screening> screenings)
        {
            this.Location = startingPoint;
            this._screenings = screenings;

            RenderScreeningRows();
        }

        private void RenderScreeningRows()
        {
            if (this._screenings.Count == 0)
            {
                this.Controls.Clear();
                MessageBox.Show("No screenings");
                return;
            }

            this.Controls.Clear();

            var rowCoordinates = this.Location;
            int id = 0;
            foreach (var screening in _screenings)
            {
                
                var row = new ScreeningRow(screening,++id);
                row.Location = rowCoordinates;
                this.Controls.Add(row);

                rowCoordinates.Y += row.Height;
            }
        }
    }
}