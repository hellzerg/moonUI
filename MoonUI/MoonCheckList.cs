using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonCheckList : CheckedListBox
    {
        public MoonCheckList()
        {
            this.BackColor = MoonManager.BackAccentColor;
            this.ForeColor = MoonManager.TextColor;
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Color c = MoonManager.TextColor;

            if (this.Items.Count > 0)
            {
                if (e.Index >= 0)
                {
                    c = GetItemChecked(e.Index) ? MoonManager.AccentColor : MoonManager.TextColor;
                }
                else
                {
                    c = MoonManager.TextColor;
                }
            }

            var tweakedEventArgs = new DrawItemEventArgs(
                e.Graphics,
                e.Font,
                e.Bounds,
                e.Index,
                e.State,
                c,
                e.BackColor);

            base.OnDrawItem(tweakedEventArgs);
        }
    }
}
