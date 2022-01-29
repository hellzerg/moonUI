using MoonUI;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class DemoForm : MoonForm
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moonTip1.SetToolTip(moonWarnButton1, "This is a test help tip in the box");
        }

        private void moonGrid1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message);
        }

        private void moonButton1_Click(object sender, EventArgs e)
        {
            if (MoonManager.THEME_PREFERENCE == THEME.DARK)
            {
                MoonManager.SET_THEME(THEME.LIGHT, THEME_ACCENT.ZERG, this);
            }
            else
            {
                MoonManager.SET_THEME(THEME.DARK, THEME_ACCENT.ZERG, this);
            }
        }

        private void moonToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (moonToggle1.Checked)
            {
                MessageBox.Show("okkk");
            }
            else
            {
                MessageBox.Show("kfeopng");
            }
        }
    }
}
