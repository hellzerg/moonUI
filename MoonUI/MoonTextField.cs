using System.Windows.Forms;

namespace MoonUI
{
    public class MoonTextField : TextBox
    {
        public MoonTextField()
        {
            this.BorderStyle = BorderStyle.None;
            this.ForeColor = MoonManager.TextColor;
            this.BackColor = MoonManager.BackAccentColor;
        }
    }
}
