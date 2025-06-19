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
    public partial class ctrChangeProperties : UserControl
    {
        public ctrChangeProperties()
        {
            InitializeComponent();
        }
        public void LoadImageIndTitle(int TestTypeID)
        {
            switch (TestTypeID)
            {
                case 2:
                    pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\Written Test 512.png");
                    lbTitle.Text = "Written Test Appointments";

                    break;
                case 3:
                    pbHeader.Load("F:\\علوم حاسوب\\عمي ابو هدهود\\Icons\\driving-test 512.png");
                    lbTitle.Text = "Written Test Appointments";
                    break;
                default:
                    break;


            }
        }
    }
}
