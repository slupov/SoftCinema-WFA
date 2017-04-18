using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    class AdminSideBar : SideBar
    {
        public AdminSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new AdminMenuTeamButton(),
                new RegisterMovieTeamButton()
            });

            this.VisualizeButtons();

        }
    }
}