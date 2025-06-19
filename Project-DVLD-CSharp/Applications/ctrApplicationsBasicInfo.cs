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
    public partial class ctrApplicationsBasicInfo : UserControl
    {
        public ctrApplicationsBasicInfo()
        {
            InitializeComponent();
        }
        public void FillAppInfo(clsApplicationInfo AppInfo,clsApplications application,clsLicenseClasses classes)
        {
            lbtype.Text=clsApplictionsTypeTitle.Find(application.AppTypeID).AppName;
            lbstatus.Text = AppInfo.status;
            lbID.Text=AppInfo.ID.ToString();
            lbApplicant.Text=AppInfo.ApplicantName;
            lbApFees.Text=application.PaidFees.ToString();
            lbDate.Text=application.AppDate.ToString("dd-MM--yyy");
            lbStatusDate.Text=application.LastStatusDate.ToString("dd-MM-yyy");
            lbUser.Text=application.UserID.ToString();
            

        }
    }

}
