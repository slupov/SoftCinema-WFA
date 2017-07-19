using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
using System.Collections.Generic;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    internal class AdminSideBar : SideBar
    {
        public AdminSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new RegisterMovieTeamButton(),
                new AdminMenuTeamButton(),
                new MyAccountButton()
            });

            this.VisualizeButtons();
        }
    }
}