using SoftCinema.Client.Utilities.CustomTools;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    public class SideBar : Panel
    {
        protected List<TeamButton> Buttons { get; set; }

        public SideBar() : base()
        {
            base.Size = new Size(195, 418);
            base.Dock = DockStyle.Left;
            base.BackColor = Color.FromArgb(255, 26, 32, 40);
            base.Location = new Point(0, 73);
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