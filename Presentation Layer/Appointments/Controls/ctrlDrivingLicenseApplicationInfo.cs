using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadDrivingLicenseApplicationInfo(clsLocalDrivingLicenseApplication Application, int passedTests)
        {

            lblAppliedForLicenseValue.Text = clsLicenseClass.GetClassName(Application.LicenseClassID1);
            lblDLAppIDValue.Text = Application.LocalDrivingLicenseApplicationID.ToString();
            lblPassedTestsValue.Text = passedTests.ToString();

        }

        public void LoadDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            // TODO: Implement loading logic
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO: Implement Show License Info logic
        }

        private void gbDrivingLicenseApplicationInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
