using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmIssueDriverLicenseForTheFirstTime : Form
    {

        public delegate void IsCompleted(bool isCompleted);
        public event IsCompleted OnCompleted;

        private clsLocalDrivingLicenseApplication LocalApplication;
        private int PersonID;
        private int PassedTests;
        private clsUser User;

        public frmIssueDriverLicenseForTheFirstTime(clsLocalDrivingLicenseApplication localApplication, int passedTests,clsUser User)
        {
            InitializeComponent();

            LocalApplication = localApplication;
            PassedTests = passedTests;
            this.User = User;
            PersonID = clsApplication.Find(LocalApplication.ApplicationID).PersonID;
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
           
           clsLicense License = new clsLicense();
          
            License.ApplicationID = LocalApplication.ApplicationID;
            License.IssueDate = DateTime.Now;
            License.ExpiryDate= DateTime.Now.AddYears(5); // Assuming a 5-year validity for the license
            License.LicenseClassID = LocalApplication.LicenseClassID1;
            License.Note = txtNotes.Text;
            License.IssueReason = clsLicense.enIssueReason.NewLicense;
            License.IssuedByUserID = User.UserID;
            License.PaidFees = 0;
            License.IsActive = true;
            License.DriverID = clsDriver.AddNewDriver(PersonID, User.UserID);

            clsLicense.enSave result = License.Save();

            switch (result) 
            {
            
            case clsLicense.enSave.enAddScc:
                    MessageBox.Show("Driver's license issued successfully, Driver ID: " + License.DriverID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    if(OnCompleted != null)
                    OnCompleted(true);
                    break;
                    default:
                    MessageBox.Show("Failed to issue driver's license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (OnCompleted != null)
                        OnCompleted(false);
                    break;
            }


        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
            // TODO: Implement notes changed logic
        }

        private void frmIssueDriverLicenseForTheFirstTime_Load(object sender, EventArgs e)
        {

        }
    }
}
