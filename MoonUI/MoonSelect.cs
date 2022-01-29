using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonSelect : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

        public MoonSelect()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = MoonManager.TextColor;
            this.BackColor = MoonManager.BackAccentColor;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    var adjustMent = 0;
                    if (FlatStyle == FlatStyle.Popup ||
                       (FlatStyle == FlatStyle.Flat &&
                       DropDownStyle == ComboBoxStyle.DropDownList))
                        adjustMent = 1;
                    var innerBorderWidth = 0;
                    var innerBorderColor = MoonManager.BackAccentColor;
                    if (DropDownStyle == ComboBoxStyle.DropDownList &&
                        (FlatStyle == FlatStyle.System || FlatStyle == FlatStyle.Standard))
                        innerBorderColor = MoonManager.BackAccentColor;
                    if (DropDownStyle == ComboBoxStyle.DropDownList && !Enabled)
                        innerBorderColor = MoonManager.BackAccentColor;

                    if (DropDownStyle == ComboBoxStyle.DropDownList || Enabled == false)
                    {
                        using (var p = new Pen(innerBorderColor, innerBorderWidth))
                        {
                            p.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                            g.DrawRectangle(p, 1, 1,
                                Width - buttonWidth - adjustMent - 1, Height - 1);
                        }
                    }
                    using (var p = new Pen(MoonManager.BackAccentColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        g.DrawLine(p, Width - buttonWidth - adjustMent,
                            0, Width - buttonWidth - adjustMent, Height);
                    }
                }
            }
        }
    }
}
