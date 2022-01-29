using System.Windows.Forms;

namespace MoonUI
{
    public class MoonWarnButton : Button
    {
        public MoonWarnButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Black;
            this.BackColor = MoonManager.WarningColor;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = MoonManager.WarningPressedColor;
            this.FlatAppearance.MouseOverBackColor = MoonManager.WarningPressedColor;
        }
    }
}
