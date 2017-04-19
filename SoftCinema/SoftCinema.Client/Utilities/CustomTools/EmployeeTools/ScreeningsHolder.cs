using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Models;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ScreeningsHolder : Panel
    {
        private List<Screening> _screenings { get; set; }

        public ScreeningsHolder() : base()
        {
            this._screenings = new List<Screening>();
        }

        public ScreeningsHolder(Point startingPoint,Size size, List<Screening> screenings)
        {
            this.Location = startingPoint;
            this._screenings = screenings;
            this.Size = size;
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

            var rowCoordinates = new Point(0,0);
            int id = 0;
            foreach (var screening in _screenings)
            {
                var row = new ScreeningRow(screening,this.Size.Width,++id);
                row.Location = rowCoordinates;
                this.Controls.Add(row);

                rowCoordinates.Y += row.Height;
            }
        }
    }
}