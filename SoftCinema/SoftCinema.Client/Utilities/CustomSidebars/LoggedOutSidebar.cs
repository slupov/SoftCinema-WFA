namespace SoftCinema.Client.Utilities.CustomSidebars
{
    using SoftCinema.Client.Utilities.CustomTools;
    using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
    using System.Collections.Generic;

    internal class LoggedOutSidebar : SideBar
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