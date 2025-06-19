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

namespace project19.Applications
{
    public partial class ctrReplaceOrLostLicenseApp : UserControl
    {
        public ctrReplaceOrLostLicenseApp()
        {
            InitializeComponent();
        }
        public void FillReplacementAppInfo(bool IsDamahedORLost)
        {
            if (IsDamahedORLost)
            {
                lbAppDate.Text = DateTime.Now.ToString("dd-MM-yyy");
                lbAppFees.Text = clsApplictionsTypeTitle.Find(Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForDamagedDrivingLicense"))).fees.ToString();
                lbUserID.Text = clsUserSettings.UserName;
                return;
            }
                lbAppDate.Text = DateTime.Now.ToString("dd-MM-yyy");
                lbAppFees.Text = clsApplictionsTypeTitle.Find(Convert.ToInt32(clsApplictionsTypeTitle.GetIdByName("ReplacementForLostDrivingLicense"))).fees.ToString();
                lbUserID.Text = clsUserSettings.UserName;
        }
        public void SetReplacementAppAndLicenseID(int ReplaceAppID,int ReplaceLicenseID,int oldLicenseID)
        {
            lbReplacementID.Text = ReplaceAppID.ToString();
            lbReplacedID.Text = ReplaceLicenseID.ToString();
            lbOldLicenseID.Text=oldLicenseID.ToString();
        }
    }
}
