using System.Drawing;
using System.Windows.Forms;

namespace MoonUI
{
    public class MoonGrid : DataGridView
    {
        public MoonGrid()
        {
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.EnableHeadersVisualStyles = false;

            FixColors();
        }

        public void FixColors()
        {
            this.GridColor = MoonManager.BackAccentColor;
            this.BackgroundColor = MoonManager.BackAccentColor;
            this.ForeColor = MoonManager.TextColor;

            if (MoonManager.THEME_PREFERENCE == THEME.DARK)
            {
                this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(200, 200, 200);
            }

            this.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.ColumnHeadersDefaultCellStyle.BackColor = MoonManager.AccentColor;
            this.ColumnHeadersDefaultCellStyle.SelectionBackColor = MoonManager.BackColor;
            this.ColumnHeadersDefaultCellStyle.SelectionForeColor = MoonManager.TextColor;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            this.DefaultCellStyle.BackColor = MoonManager.BackAccentColor;
            this.DefaultCellStyle.ForeColor = MoonManager.TextColor;
            this.DefaultCellStyle.SelectionBackColor = MoonManager.BackColor;
            this.DefaultCellStyle.SelectionForeColor = MoonManager.TextColor;

            this.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.RowHeadersDefaultCellStyle.BackColor = MoonManager.BackAccentColor;
            this.RowHeadersDefaultCellStyle.ForeColor = MoonManager.TextColor;
            this.RowHeadersDefaultCellStyle.SelectionBackColor = MoonManager.BackColor;
            this.RowHeadersDefaultCellStyle.SelectionForeColor = MoonManager.TextColor;
        }
    }
}
