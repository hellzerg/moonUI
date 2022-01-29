using System.Windows.Forms;

namespace MoonUI
{
    public class MoonInfoButton : Button
    {
        public MoonInfoButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = MoonManager.TextColor;
            this.BackColor = MoonManager.InfoColor;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = MoonManager.InfoPressedColor;
            this.FlatAppearance.MouseOverBackColor = MoonManager.InfoPressedColor;
        }
    }
}
