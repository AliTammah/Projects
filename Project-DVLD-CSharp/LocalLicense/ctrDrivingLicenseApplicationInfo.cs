using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusnissLayer;

namespace project19
{
    public partial class ctrDrivingLicenseApplicationInfo : UserControl
    {
        public ctrDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadDataDrivingLocalApp(int localID,string className,int PassedTest)
        {
            lbID.Text = localID.ToString();
            lbPassedTest.Text = PassedTest.ToString();
            lbClassLicense.Text = className.ToString();
        }
    }
}
