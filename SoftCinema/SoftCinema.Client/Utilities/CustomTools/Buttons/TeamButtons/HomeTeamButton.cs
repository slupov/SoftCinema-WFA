using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms;
using SoftCinema.Client.Forms.ContentHolders;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class HomeTeamButton : TeamButton
    {
        public HomeTeamButton() : base()
        {
            this.Text = "Home";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new HomeForm());
            base.OnClick(e);
        }
    }
}
