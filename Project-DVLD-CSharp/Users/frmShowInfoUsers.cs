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
    public partial class frmShowInfoUsers : Form
    {
        int _UserID;
        public frmShowInfoUsers(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }
        clsUsers _User;
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LoadData()
        {
            _User=clsUsers.Find(_UserID);
            ctrInfoPerson1.PersonInfo(_User.PersonID);
            ctrLoginInfromation1.LoadDataUser(_User);
        }
        private void frmShowInfoUsers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
