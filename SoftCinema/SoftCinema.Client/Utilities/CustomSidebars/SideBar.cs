using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftCinema.Client.Utilities.CustomTools;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    public class SideBar : GroupBox
    {
        protected List<TeamButton> Buttons { get; set; }

        public SideBar() : base()
        {
            base.Size = new Size(195, 418);
            base.BackColor = Color.FromArgb(255, 26, 32, 40);
            base.Location = new Point(0, 0);
            this.Buttons = new List<TeamButton>();
        }

        protected void VisualizeButtons()
        {
            var buttonLocation = this.Location;

            foreach (var teamButton in this.Buttons)
            {
                teamButton.Location = buttonLocation;
                this.Controls.Add(teamButton);

                buttonLocation.Y += teamButton.Height;
            }
        }
    }
}