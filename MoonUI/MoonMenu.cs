using System.Windows.Forms;

namespace MoonUI
{
    public class MoonMenu : MenuStrip
    {
        public MoonMenu()
        {
            this.BackColor = MoonManager.BackAccentColor;
            this.ForeColor = MoonManager.TextColor;
            this.Renderer = new MoonMenuRenderer();
        }
    }
}
