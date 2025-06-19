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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project19
{
    public partial class ctrApplicationInfo : UserControl
    {
        public ctrApplicationInfo()
        {
            InitializeComponent();
        }
        public void _FillCombobox()
        {
            cbLicenseClass.DataSource =clsLicenseClasses.GetAll();
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";

        }
        public int GetClassID()
        {
            return Convert.ToInt16( cbLicenseClass.SelectedValue);
        }
        public bool GetAllLocalDriving(string nationalNumber)
        {
            DataTable dt = clsApplications.GetAllLocalDriving();

            foreach (DataRow row in dt.Rows)
            {
                string licenseClass = row["ClassName"]?.ToString();
                string national = row["NationalNo"]?.ToString();
                string status = row["Status"]?.ToString(); // تأكد من الاسم الصحيح

                if (cbLicenseClass.Text == licenseClass &&
                    nationalNumber == national &&
                    status == "New")
                {
                    return false; // طلب موجود مسبقاً
                }
            }

            return true; // لا يوجد طلب مطابق
        }

        public void GetAppFeesAndDate()
        {
            //cbLicenseClass.SelectedIndex = 0;
               decimal AppFees = clsApplictionsTypeTitle.Find(Convert.ToInt16(clsApplictionsTypeTitle.GetIdByName("NewLocalDrivingLicenseService"))).fees; ;
                lbApFees.Text = AppFees.ToString();
                lbApplDate.Text = DateTime.Now.ToString();
           
        }
        public void LoadDataToObject(clsApplications application)
        {
            int paidFees;
           
                application.PaidFees =Convert.ToDecimal( lbApFees.Text);
            
            application.AppDate=Convert.ToDateTime( lbApplDate.Text);

        }
        public void SetAppID(int AppID)
        {
            lbAppIDAdded.Text = AppID.ToString();
        }

        private void ctrApplicationInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbLicenseClass.Text != "")
            //{
            //    decimal AppFees = clsApplictionsTypeTitle.Find(1).fees;
            //    lbApFees.Text = AppFees.ToString();
            //    lbApplDate.Text = DateTime.Now.ToString();
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
