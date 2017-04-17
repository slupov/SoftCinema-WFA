using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class RegisterMovieTeamButton : TeamButton
    {
        public RegisterMovieTeamButton() : base()
        {
            this.Text = "Register movie";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new RegisterMovieForm());
            base.OnClick(e);
        }
    }
}
