using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MoonUI
{
    public enum THEME
    {
        LIGHT,
        DARK
    }

    public enum THEME_ACCENT
    {
        ZERG,
        AETHER,
        MROBOT,
        PASSION
    }

    public static class MoonManager
    {
        public static Color SuccessColor = ColorFromHex("#5CB85C");
        public static Color SuccessPressedColor = ColorFromHex("#449D44");

        public static Color InfoColor = ColorFromHex("#5BC0DE");
        public static Color InfoPressedColor = ColorFromHex("#31B0D5");

        public static Color WarningColor = ColorFromHex("#F0AD4E");
        public static Color WarningPressedColor = ColorFromHex("#EC971F");

        public static Color DangerColor = ColorFromHex("#D9534F");
        public static Color DangerPressedColor = ColorFromHex("#C9302C");

        // defaults
        public static Color TextColor = Color.White;
        //public static Font TextFont = new Font("Segoe UI Semibold", 10f);

        public static Color AccentColor = Color.MediumOrchid;
        public static Color SecondaryColor = Color.DarkOrchid;

        public static Color BackColor = Color.FromArgb(10, 10, 10);
        public static Color BackAccentColor = Color.FromArgb(40, 40, 40);

        public static THEME THEME_PREFERENCE = THEME.DARK;
        public static THEME_ACCENT ACCENT_PREFERENCE = THEME_ACCENT.ZERG;

        static ColorController _colorController = new ColorController();

        public static void SET_THEME(THEME t, THEME_ACCENT a, Form f)
        {
            THEME_PREFERENCE = t;
            ACCENT_PREFERENCE = a;

            switch (t)
            {
                case THEME.DARK:
                    TextColor = Color.White;
                    BackColor = Color.FromArgb(10, 10, 10);
                    BackAccentColor = Color.FromArgb(40, 40, 40);
                    break;

                case THEME.LIGHT:
                    TextColor = Color.Black;
                    BackColor = Color.FromArgb(250, 250, 250);
                    BackAccentColor = Color.FromArgb(220, 220, 220);
                    break;
            }

            switch (a)
            {
                case THEME_ACCENT.ZERG:
                    AccentColor = Color.MediumOrchid;
                    SecondaryColor = Color.DarkOrchid;
                    break;

                case THEME_ACCENT.AETHER:
                    AccentColor = Color.DodgerBlue;
                    SecondaryColor = Color.RoyalBlue;
                    break;

                case THEME_ACCENT.MROBOT:
                    AccentColor = Color.LimeGreen;
                    SecondaryColor = Color.ForestGreen;
                    break;

                case THEME_ACCENT.PASSION:
                    AccentColor = ColorFromHex("#E04556");
                    SecondaryColor = ColorFromHex("#8D1725");
                    break;
            }

            SetTheme(f);
        }

        private static void SetTheme(Form f)
        {
            f.ForeColor = MoonManager.TextColor;
            f.BackColor = MoonManager.BackColor;
            //f.Font = MoonManager.TextFont;

            _colorController.SetColor(KnownColor.Highlight, MoonManager.BackColor.ToArgb());
            _colorController.SetColor(KnownColor.HighlightText, MoonManager.TextColor.ToArgb());

            List<Control> controls = GetSelfAndChildrenRecursive(f).OfType<Control>().ToList();

            dynamic tmp;

            foreach (Control x in controls)
            {
                tmp = x;

                if (x is MoonLink)
                {
                    tmp.LinkColor = MoonManager.AccentColor;
                    tmp.VisitedLinkColor = MoonManager.SecondaryColor;
                    tmp.ActiveLinkColor = MoonManager.SecondaryColor;
                }

                if (x is MoonMenu || x is ContextMenuStrip || x is MoonSelect || x is MoonTextField || x is MoonList)
                {
                    tmp.BackColor = MoonManager.BackAccentColor;
                    tmp.ForeColor = MoonManager.TextColor;
                }

                if (x is MoonGrid)
                {
                    tmp.FixColors();
                }

                if (x is MoonTree)
                {
                    tmp.ForeColor = MoonManager.TextColor;
                    tmp.BackColor = MoonManager.BackAccentColor;
                }

                if (x is TabPage)
                {
                    tmp.BackColor = MoonManager.BackColor;
                    tmp.ForeColor = MoonManager.TextColor;
                }

                if (x is MoonLinearBar)
                {
                    tmp.PaintedBack = false;
                    tmp.StopPainting = false;
                }

                if (x is MoonLabel)
                {
                    tmp.ForeColor = MoonManager.AccentColor;
                }

                if (x is MoonCheckList)
                {
                    tmp.ForeColor = MoonManager.TextColor;
                    tmp.BackColor = MoonManager.BackAccentColor;
                }

                if (x is MoonCheck || x is MoonRadio)
                {
                    if (tmp.Checked)
                    {
                        tmp.Font = new Font(tmp.Font, FontStyle.Underline);
                        tmp.ForeColor = MoonManager.AccentColor;
                    }
                    else
                    {
                        tmp.Font = new Font(tmp.Font, FontStyle.Regular);
                        tmp.ForeColor = MoonManager.TextColor;
                    }
                }

                if (x is MoonButton)
                {
                    tmp.BackColor = AccentColor;
                    tmp.FlatAppearance.BorderSize = 0;
                    tmp.FlatAppearance.MouseOverBackColor = SecondaryColor;
                    tmp.FlatAppearance.MouseDownBackColor = SecondaryColor;
                }

                tmp.Invalidate();
            }
        }

        public static Color ColorFromHex(string hex)
        {
            if (hex.IndexOf('#') != -1)
                hex = hex.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(hex.Substring(0, 2), NumberStyles.AllowHexSpecifier);
            g = int.Parse(hex.Substring(2, 2), NumberStyles.AllowHexSpecifier);
            b = int.Parse(hex.Substring(4, 2), NumberStyles.AllowHexSpecifier);

            return Color.FromArgb(r, g, b);
        }

        private static IEnumerable<Control> GetSelfAndChildrenRecursive(Control parent)
        {
            List<Control> controls = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                controls.AddRange(GetSelfAndChildrenRecursive(child));
            }

            controls.Add(parent);
            return controls;
        }
    }
}
