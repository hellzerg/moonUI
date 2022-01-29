using System.Windows.Forms;

namespace MoonUI
{
    public class MoonDangerButton : Button
    {
        public MoonDangerButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = System.Drawing.Color.Black;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = MoonManager.DangerPressedColor;
            this.FlatAppearance.MouseOverBackColor = MoonManager.DangerPressedColor;
            this.BackColor = MoonManager.DangerColor;
        }
    }
}
