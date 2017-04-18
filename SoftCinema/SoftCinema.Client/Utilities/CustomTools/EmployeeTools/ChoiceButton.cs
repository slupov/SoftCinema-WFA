using System.Drawing;
using System.Windows.Forms;
using SoftCinema.Services.Utilities;

namespace SoftCinema.Client.Utilities.CustomTools.EmployeeTools
{
    class ChoiceButton : SeatButton
    {
        private static Font _normalFont = new Font("Arial", 10F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte) (0)));

        private static Color _approveColor = System.Drawing.Color.FromArgb(200, 53, 172, 73);
        private static Color _rejectColor = System.Drawing.Color.FromArgb(200, 255, 0, 0);
        private static Color _fore = System.Drawing.Color.White;

        private static Padding _margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        private static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

        private static Size _minSize = new System.Drawing.Size(10, 10);
        private bool _active;
        private bool _selected;

        public ChoiceButton(bool isApproval)
        {
            base.Font = _normalFont;
            base.ForeColor = _fore;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
            base.MinimumSize = _minSize;
            base.Size = new Size(20, 20);

            this._selected = false;

            if (isApproval)
            {
                this.Text = Constants.TickMark.ToString();
                base.BackColor = _approveColor;
            }
            else
            {
                this.Text = "X";
                base.BackColor = _rejectColor;
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        public new void SetStateActive()
        {
            _active = true;
        }

        public new void SetStateNormal()
        {
            _active = false;
        }

        public new bool isSelected()
        {
            return this._selected;
        }
    }
}