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
using System.IO;
using project19.Applications;

namespace project19
{
    public partial class frmMain : Form
    {
        clsUsers _CurrentUser;
        bool _IsRemeberMe;
        public frmMain(clsUsers CurrentUser,bool ISRememberMe)
        {
            InitializeComponent();
            _CurrentUser = CurrentUser;
            _IsRemeberMe = ISRememberMe;
        }

        private void btPeople_Click(object sender, EventArgs e)
        {
            frmManagePeople frm=new frmManagePeople();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmManageUsers frm=new frmManageUsers();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btAccountSetting_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Visible = true;
        }

            string username;
            string password;
        private void signOut_Click(object sender, EventArgs e)
        {
            //this.Close();
            if (_IsRemeberMe)
            {
                string pathfile = @"C:\Users\LENOVO\source\repos\project19\users.txt";
                if (File.Exists(pathfile))
                {
                    //using (StreamReader reader = new StreamReader(pathfile))
                    //{
                    //string line;
                    string line = File.ReadLines(pathfile).First();

                    // تقسيم السطر باستخدام الفراغ كفاصل
                    string[] parts = line.Split(' ');

                    if (parts.Length >= 2)
                    {
                        //isRemember = parts[0];
                        username = parts[0];
                        password = parts[1];

                    }
                    try
                    {
                        File.WriteAllText("file.txt", "");
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Faild remove data from file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    frmLoginScreen frm = new frmLoginScreen();
                    this.Hide();
                    frm.LoadDataUser(username, password);
                   
                    
                    frm.Show();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Failed Load User Data Because not found File","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                frmLoginScreen frm = new frmLoginScreen();
                frm.Show();
            }
        }

        private void Currentuserinfo_Click(object sender, EventArgs e)
        {
            frmShowInfoUsers frm=new frmShowInfoUsers(_CurrentUser.UserID);
            frm.ShowDialog();

        }

        private void changePass_Click(object sender, EventArgs e)
        {
            frmChangePassword frm =new frmChangePassword(_CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           frmManageApplicationsType frm=new frmManageApplicationsType();
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmManageTestsTypes frm=new frmManageTestsTypes();
            frm.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmManageApplications frm = new frmManageApplications(_CurrentUser);
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void btDrivers_Click(object sender, EventArgs e)
        {
            frmManageDrivers frm=new frmManageDrivers();
            frm.ShowDialog();
        }

        private void localLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateInternational frm=new frmAddUpdateInternational();
            frm.ShowDialog();
        }

        private void internationalDrinvingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageInternationalLicense frm=new frmManageInternationalLicense();
            frm.ShowDialog();
        }

        private void RenewLicensApplication_Click(object sender, EventArgs e)
        {
            frmRenewLicense frm =new frmRenewLicense();
            frm.ShowDialog();
        }

        private void Repalcement_Click(object sender, EventArgs e)
        {
            frmReplacementDamagedLostLicense frm=new frmReplacementDamagedLostLicense();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm=new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainLicense frm= new frmReleaseDetainLicense();
            frm.ShowDialog();
        }

        private void release_Click(object sender, EventArgs e)
        {

        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMmanageDetainLicense frm = new frmMmanageDetainLicense();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateApplications frm=new frmAddUpdateApplications(-1);
            frm.ShowDialog();
        }
    }
}
