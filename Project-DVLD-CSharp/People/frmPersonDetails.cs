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
    public partial class frmPersonDetails : Form
    {
        int _personID;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _personID = PersonID;
        }
        //public clspeople person=new clspeople();
        
       
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctrInfoPerson1.PersonInfo(_personID);
        }
    }
}
