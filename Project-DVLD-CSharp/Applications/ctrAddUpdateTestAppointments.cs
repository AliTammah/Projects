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
    public partial class ctrAddUpdateTestAppointments : UserControl
    {
        int TrialCount=0;

        public ctrAddUpdateTestAppointments()
        {
            InitializeComponent();
            //TrialCount++;
        }
        public void FillDataAppointments(clsApplications application,clsApplicationInfo applicationInfo,
            clsLicenseClasses licenseClasses,int Trail) 
        {
            lbID.Text= applicationInfo.ID.ToString();
            lbName.Text=applicationInfo.ApplicantName.ToString();
            lbClass.Text=licenseClasses.ClassName.ToString();
            lbFees.Text=clsTestsTypes.Find(application.AppTypeID).TestFees.ToString();
            lbTrial.Text=Trail.ToString();
        
        }
        public void SaveDataToObject(clsAppointments appointments)
        {
            //appointments.LocalID=Convert.ToInt32( lbID.Text);
            appointments.PaidFees=Convert.ToDecimal( lbFees.Text);
            appointments.AppointmentDate=Convert.ToDateTime( dateTimePicker1.Value.ToString());
            //appointments.TesTypeID=
            appointments.IsLocked = false;
            //appointments.UserID=Convert.ToInt32(lb.Text);
        }
        public bool LoadDataToUserControl(clsAppointments appointments)
        {
            if (appointments.IsLocked)
            {
                dateTimePicker1.Value = appointments.AppointmentDate;

                dateTimePicker1.Enabled = false;
                return true;
            }
            dateTimePicker1.Value= appointments.AppointmentDate;
            return false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
