using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        private int _selectedLicenseID = -1;
        private int _createdInternationalLicenseID = -1;
        private clsUser _User;

        public frmNewInternationalLicenseApplication(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private bool CheckIfYouCanIssueLicense(int LicenseID) 
        {
        
            if(clsLicense.HaveInternationalLicense(LicenseID))
            {
                MessageBox.Show("This driver already has an International License. You cannot issue another one.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!clsLicense.IsLicenseActive(LicenseID))
            {
                MessageBox.Show("This license is not active. You cannot issue an international license for it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!clsLicense.IsLicenseClass3(LicenseID))
            {
                MessageBox.Show("This license isn't of class 3. You cannot issue an international license for it.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.ResetDefaultValues();
            btnIssue.Enabled = false;
            llShowLicenseInfo.Enabled = false;
            llShowLicenseHistory.Enabled = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("Please enter a valid Driver License ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseID.Focus();
                return;
            }

            if (!int.TryParse(txtLicenseID.Text.Trim(), out int licenseID))
            {
                MessageBox.Show("Driver License ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _selectedLicenseID = licenseID;
            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);

            // Populate local license ID in application info control
            ctrlApplicationInfo1.LocalLicenseID = licenseID.ToString();
            llShowLicenseHistory.Enabled = true;

            // Enable Issue button if license is valid
            btnIssue.Enabled = true;
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (e.g., backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Perform find action when user presses Enter key
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
           
            if(CheckIfYouCanIssueLicense(_selectedLicenseID))
            {
                clsLicense oldLicense = clsLicense.Find(_selectedLicenseID);
                clsApplication oldApplication = clsApplication.Find(oldLicense.ApplicationID);

                clsApplication newApplication = new clsApplication();

                newApplication.PersonID = oldApplication.PersonID;
                newApplication.ApplicationDate1 = DateTime.Now;
                newApplication.TypeID1 = 6; // Assuming 6 is the type ID for International License Application
                newApplication.Status = 1; // Assuming 1 is the status for New
                newApplication.LastStatusDate = DateTime.Now;
                newApplication.PaidFees = (decimal)clsApplicationType.GetApplicationFees(clsApplicationType.GetApplicationTypeTitle(6)); // Assuming no fees for the application itself
                newApplication.UserID = _User.UserID;

                clsApplication.enSave saveResult = newApplication.Save();

                switch(saveResult)
                {
                    case clsApplication.enSave.enAddScc:
                        MessageBox.Show("International License Application saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case clsApplication.enSave.enLostScc:
                        MessageBox.Show("Failed to save International License Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                clsLicense newLicense = new clsLicense();

                newLicense.ApplicationID = newApplication.ApplicationID;
                newLicense.DriverID = oldLicense.DriverID;
                newLicense.LicenseClassID = 3; // Assuming 3 is the class ID for International License
                newLicense.IssueDate = DateTime.Now;
                newLicense.ExpiryDate = DateTime.Now.AddYears(5); // Assuming 5 years validity
                newLicense.Note = "Issued as International License";
                newLicense.PaidFees = 51.00; // Assuming a fixed fee for International License
                newLicense.IsActive = true;
                newLicense.IssueReason = clsLicense.enIssueReason.NewLicense;
                newLicense.IssuedByUserID = _User.UserID;

                clsLicense.enSave saveResult1 = newLicense.Save();

                switch(saveResult1)
                {
                    case clsLicense.enSave.enAddScc:
                        MessageBox.Show("International License issued successfully. licenseId : "+ newLicense.LicenseID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case clsLicense.enSave.enFailed:
                        MessageBox.Show("Failed to issue International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                ctrlApplicationInfo1.LoadApplicationInfo(newApplication.ApplicationID, newApplication.ApplicationDate1, newLicense.IssueDate, newApplication.PaidFees, newLicense.LicenseID,
                    oldLicense.LicenseID, newLicense.ExpiryDate, newLicense.IssuedByUserID);

            }

            

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Showing license history for License ID: {_selectedLicenseID}", "License History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Showing International License info for License ID: {_createdInternationalLicenseID}", "International License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}
