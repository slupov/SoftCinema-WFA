using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    class LoggedOutSidebar : SideBar
    {
        public LoggedOutSidebar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new RegisterTeamButton(),
                new LoginTeamButton(),
                new MoviesTeamButton()
            });

            this.VisualizeButtons();

        }
    }
}
