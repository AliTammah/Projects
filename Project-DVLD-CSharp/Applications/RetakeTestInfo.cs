using DataBusnissLayer;
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
    public partial class RetakeTestInfo : UserControl
    {
        public RetakeTestInfo()
        {
            InitializeComponent();
        }
        public void LoadDataToUserRetakeInfo(decimal RetakeFees,decimal totalFees)
        {
            lbRAppFees.Text=RetakeFees.ToString();
            lbtotal.Text=(RetakeFees+totalFees).ToString();
            
        }
    }
}
