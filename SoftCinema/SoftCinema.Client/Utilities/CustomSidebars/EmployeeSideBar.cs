using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
using System.Collections.Generic;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    internal class EmployeeSideBar : SideBar
    {
        public EmployeeSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new ShowScreeningsTeamButton(),
                new RegisterMovieTeamButton(),
                new MyAccountButton()
            });

            this.VisualizeButtons();
        }
    }
}