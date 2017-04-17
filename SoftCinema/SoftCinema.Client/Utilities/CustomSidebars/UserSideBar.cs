using System.Collections.Generic;
using SoftCinema.Client.Utilities.CustomTools;
using SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons;

namespace SoftCinema.Client.Utilities.CustomSidebars
{
    class UserSideBar : SideBar
    {
        public UserSideBar() : base()
        {
            this.Buttons.AddRange(new List<TeamButton>()
            {
                new BuyTicketsTeamButton(),
                new MoviesTeamButton(),
            });

            this.VisualizeButtons();
        }
    }
}