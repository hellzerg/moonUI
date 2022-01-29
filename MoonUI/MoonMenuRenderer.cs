using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonMenuRenderer : ToolStripProfessionalRenderer
    {
        public MoonMenuRenderer() : base(new MoonColors())
        {

        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
            {
                e.TextColor = MoonManager.TextColor;
            }

            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
                e.ArrowColor = MoonManager.TextColor;
            base.OnRenderArrow(e);
        }
    }

    public class MoonColors : ProfessionalColorTable
    {
        public override Color MenuItemPressedGradientBegin
        {
            get { return MoonManager.BackColor; }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return MoonManager.BackColor; }
        }

        public override Color SeparatorLight
        {
            get { return MoonManager.BackAccentColor; }
        }

        public override Color SeparatorDark
        {
            get { return MoonManager.BackAccentColor; }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return MoonManager.BackColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return MoonManager.BackColor;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return MoonManager.BackColor;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return MoonManager.BackColor;
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return MoonManager.BackColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return MoonManager.BackAccentColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return MoonManager.BackAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return MoonManager.BackAccentColor;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return MoonManager.BackAccentColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return MoonManager.BackAccentColor;
            }
        }
    }
}
