using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonCheck : CheckBox
    {
        public MoonCheck()
        {

        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            // custom theming
            if (this.Checked)
            {
                this.Font = new Font(this.Font, FontStyle.Underline);
                this.ForeColor = MoonManager.AccentColor;
            }
            else
            {
                this.Font = new Font(this.Font, FontStyle.Regular);
                this.ForeColor = MoonManager.TextColor;
            }
        }

    }
}
