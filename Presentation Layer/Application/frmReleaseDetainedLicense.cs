using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _selectedLicenseID = -1;
        private clsUser _currentUser;
        private clsLicense _license;
        private clsApplication _NewApplication;

        public frmReleaseDetainedLicense(clsUser User)
        {
            InitializeComponent();
            _currentUser = User;
        }

        public frmReleaseDetainedLicense(clsUser User, int LicenseID)
        {
            InitializeComponent();
            _currentUser = User;
            txtLicenseID.Text = LicenseID.ToString();
            gbFilter.Enabled = false;
            FindLicenseByID();
        }

        private void FindLicenseByID() 
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("Please enter a valid License ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseID.Focus();
                return;
            }

            if (!int.TryParse(txtLicenseID.Text.Trim(), out int licenseID))
            {
                MessageBox.Show("License ID must be a numeric value.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _selectedLicenseID = licenseID;
            _license = clsLicense.Find(licenseID);

            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);


            btnRelease.Enabled = true;

            _VerificationIfCanReleaseLicense();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                ctrlDriverLicenseInfo1.ResetDefaultValues();
                ctrlReleaseLicenseInfo1.ResetDefaultValues();

                btnRelease.Enabled = false;
            }
        }

        private void _VerificationIfCanReleaseLicense()
        {

            if (!clsDetainLicense.CheckIfLicenseIsDetained(_selectedLicenseID)) 
            {

                MessageBox.Show($"License ID {_selectedLicenseID} is not detained or has already been released.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRelease.Enabled = false;

            }
            if (!clsLicense.IsLicenseActive(_selectedLicenseID)) 
            {
            
                MessageBox.Show($"License ID {_selectedLicenseID} is not active and cannot be released.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnRelease.Enabled = false;

            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("Please enter a valid License ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseID.Focus();
                return;
            }

            if (!int.TryParse(txtLicenseID.Text.Trim(), out int licenseID))
            {
                MessageBox.Show("License ID must be a numeric value.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _selectedLicenseID = licenseID;
            _license = clsLicense.Find(licenseID);

            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);
   

  
            btnRelease.Enabled = true;

            _VerificationIfCanReleaseLicense();
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }

        private void _CreateNewApplciation() 
        {

             _NewApplication = new clsApplication();

            _NewApplication.PersonID = clsDriver.RetrievePersonID(_license.DriverID);
            _NewApplication.ApplicationDate1 = DateTime.Now;
            _NewApplication.TypeID1 = 5;
            _NewApplication.Status = 1;
            _NewApplication.LastStatusDate = DateTime.Now;
            _NewApplication.PaidFees = (decimal)clsApplicationType.GetApplicationFees(clsApplicationType.GetApplicationTypeTitle(5));
            _NewApplication.UserID = _currentUser.UserID;

            clsApplication.enSave saveResult = _NewApplication.Save();

            switch(saveResult)
            {
                case clsApplication.enSave.enAddScc:
                    MessageBox.Show("New application created successfully. Application ID : " + _NewApplication.ApplicationID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsApplication.enSave.enLostScc:
                    MessageBox.Show("An error occurred while creating the new application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void _PutLicenseIsReleasedStatusToTrue()
        {
       
            clsDetainLicense _CurrentDetainLicense = clsDetainLicense.FindDetainLicenseByDetainID(clsDetainLicense.GetDetainID(_selectedLicenseID));

            _CurrentDetainLicense.IsReleased = true;
            _CurrentDetainLicense.ReleaseDate = DateTime.Now;
            _CurrentDetainLicense.ReleasedByUserID = _currentUser.UserID;
            _CreateNewApplciation();
            _CurrentDetainLicense.ReleaseApplicationID = _NewApplication.ApplicationID;

            clsDetainLicense.enSave saveResult = _CurrentDetainLicense.Save();

            switch (saveResult) 
            {
            
                case clsDetainLicense.enSave.enReleased:
                    MessageBox.Show("License released successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbFilter.Enabled = false;
                    btnRelease.Enabled = false;
                    ctrlReleaseLicenseInfo1.LoadReleaseLicenseInfo(_CurrentDetainLicense.DetainID,_CurrentDetainLicense.DetainDate,_CurrentDetainLicense.LicenseID
                        ,_CurrentDetainLicense.ReleasedByUserID,_NewApplication.PaidFees,_CurrentDetainLicense.FineFees);
                    break;
                    case clsDetainLicense.enSave.enFailed:
                    MessageBox.Show("An error occurred while releasing the license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                MessageBox.Show("Please search for a valid License first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalFees = ctrlReleaseLicenseInfo1.TotalFees;

            if (MessageBox.Show(
                    $"Are you sure you want to release the detained License ID: {_selectedLicenseID}?\n" +
                    $"Total Fees: {totalFees:0.00}",
                    "Confirm Release",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
            {
                
                _PutLicenseIsReleasedStatusToTrue();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
