using System.Windows.Forms;

namespace MoonUI
{
    public class MoonLink : LinkLabel
    {
        public MoonLink()
        {
            this.LinkColor = MoonManager.AccentColor;
            this.VisitedLinkColor = MoonManager.SecondaryColor;
            this.ActiveLinkColor = MoonManager.SecondaryColor;
        }
    }
}
