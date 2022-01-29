using System.Windows.Forms;

namespace MoonUI
{
    public class MoonSuccessButton : Button
    {
        public MoonSuccessButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = MoonManager.TextColor;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = MoonManager.SuccessPressedColor;
            this.FlatAppearance.MouseOverBackColor = MoonManager.SuccessPressedColor;
            this.BackColor = MoonManager.SuccessColor;
        }
    }
}
