using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms;
using SoftCinema.Client.Forms.ContentHolders;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class LoginTeamButton : TeamButton
    {
        public LoginTeamButton() : base()
        {
            this.Text = "Login";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new LoginForm());
            base.OnClick(e);
        }
    }
}
