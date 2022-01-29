using System.Windows.Forms;

namespace MoonUI
{
    public class MoonForm : Form
    {

        public MoonForm()
        {
            this.ForeColor = MoonManager.TextColor;
            this.BackColor = MoonManager.BackColor;
            this.DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MoonForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MoonForm";
            this.ResumeLayout(false);

        }
    }
}
