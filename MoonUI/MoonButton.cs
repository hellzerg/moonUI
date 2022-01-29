using System.Windows.Forms;

namespace MoonUI
{
    public class MoonButton : Button
    {
        public MoonButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = MoonManager.TextColor;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = MoonManager.SecondaryColor;
            this.FlatAppearance.MouseDownBackColor = MoonManager.SecondaryColor;
            this.BackColor = MoonManager.AccentColor;
        }
    }
}
