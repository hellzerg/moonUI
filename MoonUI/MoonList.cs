using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonList : ListBox
    {
        public MoonList()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.BorderStyle = BorderStyle.None;

            this.BackColor = MoonManager.BackAccentColor;
            this.ForeColor = MoonManager.TextColor;

            this.MeasureItem += MoonListBox_MeasureItem;
            this.DrawItem += MoonListBox_DrawItem;
        }

        private void MoonListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if (this.Items.Count <= 0) return;

            e.DrawBackground();

            Brush myBrush = new SolidBrush(MoonManager.TextColor);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(MoonManager.BackColor), e.Bounds);
            }

            else
            {
                e.Graphics.FillRectangle(new SolidBrush(MoonManager.BackAccentColor), e.Bounds);

            }

            e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void MoonListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Font.Height;
        }
    }
}
