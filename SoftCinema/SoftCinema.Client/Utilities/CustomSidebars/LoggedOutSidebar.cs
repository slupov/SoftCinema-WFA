
namespace SoftCinema.Client.Utilities.CustomSidebars
{
    using System.Collections.Generic;
    using SoftCinema.Client.Utilities.CustomTools;
    using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
    class LoggedOutSidebar : SideBar
    {
        public LoggedOutSidebar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new RegisterTeamButton(),
                new LoginTeamButton()              
            });

            this.VisualizeButtons();

        }
    }
}
