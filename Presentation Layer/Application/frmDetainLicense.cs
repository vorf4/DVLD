using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmDetainLicense : Form
    {
        private int _selectedLicenseID = -1;
        private clsLicense license;
        private clsUser _User;

        public frmDetainLicense(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.ResetDefaultValues();
            ctrlDetainInfo1.ResetDefaultValues();

            btnDetain.Enabled = false;
            llShowLicensesHistory.Enabled = false;
        }

        private void _VerificationIfContinuouslyDetainedLicense(int LicenseID)
        {
            if (clsDetainLicense.CheckIfLicenseIsDetained(LicenseID))
            {
                MessageBox.Show($"License ID {LicenseID} is already detained and cannot be detained again.",
                    "Detain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;
            }
            if(!clsLicense.IsLicenseActive(LicenseID))
            {
                
                MessageBox.Show($"License ID {LicenseID} is not active and cannot be detained.",
                    "Detain Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDetain.Enabled = false;

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

            license = clsLicense.Find(licenseID);
            _selectedLicenseID = licenseID;

            // Load license information into the existing ctrlDriverLicenseInfo control
            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);

            llShowLicensesHistory.Enabled = true;
            btnDetain.Enabled = true;

            _VerificationIfContinuouslyDetainedLicense(licenseID);
        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and control characters (backspace, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Trigger Find on Enter key
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }

        private void _CreateNewDetained(decimal fineFees) 
        {

            clsDetainLicense detainedLicense = new clsDetainLicense();
           
            detainedLicense.LicenseID = _selectedLicenseID;
            detainedLicense.DetainDate = DateTime.Now;
            detainedLicense.FineFees = fineFees;
            detainedLicense.CreatedByUserID = _User.UserID;
            detainedLicense.IsReleased = false;

            clsDetainLicense.enSave result = detainedLicense.Save();

            switch (result)
            {
                case clsDetainLicense.enSave.enDetained:
                    MessageBox.Show($"License ID {_selectedLicenseID} has been detained successfully. DetainID : " + detainedLicense.DetainID,
                        "Detain Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDetain.Enabled = false;
                    gbFilter.Enabled = false;
                    ctrlDetainInfo1.LoadData(detainedLicense.DetainID, detainedLicense.DetainDate, detainedLicense.LicenseID, detainedLicense.CreatedByUserID);
                    break;
                case clsDetainLicense.enSave.enFailed:
                    MessageBox.Show($"Failed to detain License ID {_selectedLicenseID}. Please try again.",
                        "Detain Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("An unexpected error occurred. Please contact support.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                MessageBox.Show("Please search for a valid License first.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate Fine Fees
            if (!ctrlDetainInfo1.ValidateFineFees())
            {
                MessageBox.Show("Please enter a valid Fine Fees amount (must be a non-negative numeric value).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fineFees = ctrlDetainInfo1.FineFees;

            if (MessageBox.Show(
                $"Are you sure you want to detain License ID: {_selectedLicenseID}?\nFine Fees: {fineFees:C}",
                "Confirm Detain",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
              
                _CreateNewDetained(fineFees);

            }
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Showing license history for License ID: {_selectedLicenseID}",
                "License History", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
