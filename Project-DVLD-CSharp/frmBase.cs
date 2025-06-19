using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
            this.Load += BaseForm_Load;
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            if (this.Width > screenWidth)
                this.Width = screenWidth - 50;

            if (this.Height > screenHeight)
                this.Height = screenHeight - 50;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScroll = true;

            ApplyAutoZoom();
        }

        private void ApplyAutoZoom()
        {
            float baseWidth = 1366f; // العرض المرجعي
            float scale = Screen.PrimaryScreen.WorkingArea.Width / baseWidth;

            ScaleAllControls(this, scale);
        }

        private void ScaleAllControls(Control parent, float scale)
        {
            foreach (Control control in parent.Controls)
            {
                control.Font = new Font(control.Font.FontFamily, control.Font.Size * scale, control.Font.Style);
                if (control.HasChildren)
                    ScaleAllControls(control, scale);
            }
        }
    }
}
