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
    public partial class ctrLoginInfromation : UserControl
    {
        public ctrLoginInfromation()
        {
            InitializeComponent();
        }
        public void LoadDataUser(clsUsers User)
        {
            if (User == null)
            {
                return;
            }
            lbIDUser.Text=User.UserID.ToString();
            lbisAct.Text=User.IsActive.ToString();
            lbUserN.Text=User.UserName.ToString();

        }

        private void ctrLoginInfromation_Load(object sender, EventArgs e)
        {

        }
    }
}
