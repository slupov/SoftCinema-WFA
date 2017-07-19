namespace SoftCinema.Client.Utilities.CustomSidebars
{
    using SoftCinema.Client.Utilities.CustomTools;
    using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
    using System.Collections.Generic;

    internal class UserSideBar : SideBar
    {
        public UserSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new BuyTicketsTeamButton(),
                new MyAccountButton()
            });

            this.VisualizeButtons();
        }
    }
}