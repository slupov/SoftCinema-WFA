namespace SoftCinema.Client.Utilities.CustomSidebars
{
using System.Collections.Generic;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;
    class UserSideBar : SideBar
    {
        public UserSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new HomeTeamButton(),
                new MoviesTeamButton(),
                new BuyTicketsTeamButton()        
            });

            this.VisualizeButtons();
        }
    }
}