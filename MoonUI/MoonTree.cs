using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonTree : TreeView
    {
        public MoonTree()
        {
            this.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            this.BackColor = MoonManager.BackAccentColor;
            this.ForeColor = MoonManager.TextColor;
            this.BorderStyle = BorderStyle.None;
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            Rectangle r = new Rectangle();
            r.X = 0;
            r.Y = e.Bounds.Y;
            r.Height = e.Bounds.Height;
            r.Width = 100000;
            if (e.Node.IsSelected)
            {
                e.Graphics.FillRectangle(new SolidBrush(MoonManager.BackColor), r); //e.Bounds
            }
            else
                e.Graphics.FillRectangle(new SolidBrush(MoonManager.BackAccentColor), r); //e.Bounds

            TextRenderer.DrawText(e.Graphics, e.Node.Text, this.Font, e.Node.Bounds, MoonManager.TextColor);

            if (this.ImageList != null && this.ImageList.Images.Count > 0 && e.Node.SelectedImageIndex > -1)
            {
                e.Graphics.DrawImage(this.ImageList.Images[e.Node.SelectedImageIndex], e.Bounds.Left + 15 * e.Node.Level + 5, e.Bounds.Top);
            }
        }
    }
}
