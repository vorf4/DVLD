using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmIssueDriverLicenseForTheFirstTime : Form
    {

        private clsLocalDrivingLicenseApplication LocalApplication;
        private int PassedTests;
        private clsUser User;

        public frmIssueDriverLicenseForTheFirstTime(clsLocalDrivingLicenseApplication localApplication, int passedTests,clsUser User)
        {
            InitializeComponent();

            LocalApplication = localApplication;
            PassedTests = passedTests;
            this.User = User;
            _LoadDataOfControls();
        }

        private void _LoadDataOfControls()
        {

            ctrlDrivingLicenseApplicationInfo1.LoadDrivingLicenseApplicationInfo(LocalApplication, PassedTests);
            ctrlApplicationBasicInfo1.LoadApplicationInfo(LocalApplication.ApplicationID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
           
           clsLicesnes License = new clsLicesnes();
          
            License.ApplicationID = LocalApplication.ApplicationID;
            License.IssueDate = DateTime.Now;
            License.ExpiryDate= DateTime.Now.AddYears(5); // Assuming a 5-year validity for the license
            


        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            // TODO: Implement notes changed logic
        }
    }
}
