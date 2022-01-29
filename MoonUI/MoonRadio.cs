using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonRadio : RadioButton
    {
        public MoonRadio()
        {

        }

        protected override void OnCheckedChanged(EventArgs e)
        {
            base.OnCheckedChanged(e);

            if (this.Checked)
            {
                this.Font = new Font(this.Font, FontStyle.Underline);
                this.ForeColor = MoonManager.AccentColor;
            }
            else
            {
                this.ForeColor = MoonManager.TextColor;
                this.Font = new Font(this.Font, FontStyle.Regular);
            }
        }
    }
}
