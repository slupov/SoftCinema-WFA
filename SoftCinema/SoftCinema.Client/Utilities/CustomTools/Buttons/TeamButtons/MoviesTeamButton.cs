using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftCinema.Client.Forms;

namespace SoftCinema.Client.Utilities.CustomTools.Buttons.TeamButtons
{
    class MoviesTeamButton : TeamButton
    {
        public MoviesTeamButton() : base()
        {
            this.Text = "Movies";
        }

        protected override void OnClick(EventArgs e)
        {
            SoftCinemaForm.SetContentHolderForm(new MoviesForm());
            base.OnClick(e);
        }
    }
}