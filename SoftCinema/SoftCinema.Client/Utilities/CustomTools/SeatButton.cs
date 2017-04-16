namespace SoftCinema.Client.Utilities.CustomTools
{
    using System.Drawing;
    using System.Windows.Forms;

    public class SeatButton : Button
    {
        private static Font _normalFont = new Font("Arial", 10F, System.Drawing.FontStyle.Bold,
            System.Drawing.GraphicsUnit.Point, ((byte) (0)));

        private static Color _back = System.Drawing.Color.Gray;
        private static Color _border = System.Drawing.Color.Black;
        private static Color _activeBorder = System.Drawing.Color.Red;
        private static Color _fore = System.Drawing.Color.White;

        private static Padding _margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
        private static Padding _padding = new System.Windows.Forms.Padding(3, 3, 3, 3);

        private static Size _minSize = new System.Drawing.Size(10, 10);
        public static int number { get; set; }

        private bool _active;

        public SeatButton() : base()
        {
            base.Font = _normalFont;
            base.BackColor = _border;
            base.ForeColor = _fore;
            base.FlatAppearance.BorderColor = _back;
            base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            base.Margin = _margin;
            base.Padding = _padding;
            base.MinimumSize = _minSize;
            base.Text = number.ToString();
            base.Size = new Size(20, 20);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            if (!_active)
                base.FlatAppearance.BorderColor = _activeBorder;
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!_active)
                base.FlatAppearance.BorderColor = _border;
        }

        public void SetStateActive()
        {
            _active = true;
            base.FlatAppearance.BorderColor = _activeBorder;
        }

        public void SetStateNormal()
        {
            _active = false;
            base.FlatAppearance.BorderColor = _border;
        }
    }
}