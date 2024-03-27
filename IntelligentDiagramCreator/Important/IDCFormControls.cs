using System.Drawing;
using System.Windows.Forms;

namespace IntelligentDiagramCreator.Important
{
    internal class IDCFormControls
    {
        //private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public void Minimize(Form f)
        {
            f.WindowState = FormWindowState.Minimized;
        }
        public void RestoreDown(Form f)
        {
            if (f.WindowState == FormWindowState.Normal)
            {
                // Set maximum size
                f.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Set minimum size
                f.WindowState = FormWindowState.Normal;
            }
        }
        public void Close(Form f)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                f.Close();
            }
        }
    }
}