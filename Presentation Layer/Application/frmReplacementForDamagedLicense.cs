using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmReplacementForDamagedLicense : Form
    {
        private int _selectedLicenseID = -1;
        private int _replacedLicenseID = -1;
        private int _replacementApplicationID = -1;
        private clsLicense _License;
        private clsUser _User;

        public frmReplacementForDamagedLicense(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private void frmReplacementForDamagedLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfo1.ResetDefaultValues();
            ctrlApplicationInfoForLicenseReplacement1.ResetDefaultValues();

            btnIssueReplacement.Enabled = false;

            UpdateReplacementTypeInfo();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamagedLicense.Checked)
            {
                UpdateReplacementTypeInfo();
            }
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLostLicense.Checked)
            {
                UpdateReplacementTypeInfo();
            }
        }

        private void UpdateReplacementTypeInfo()
        {
            if (rbDamagedLicense.Checked)
            {
                this.Text = "Replacement for Damaged License";
                lblHeaderTitle.Text = "Replacement for Damaged License";
                ctrlApplicationInfoForLicenseReplacement1.ApplicationFees = clsApplicationType.GetApplicationFeesByID(4).ToString();
            }
            else
            {
                this.Text = "Replacement for Lost License";
                lblHeaderTitle.Text = "Replacement for Lost License";
                ctrlApplicationInfoForLicenseReplacement1.ApplicationFees = clsApplicationType.GetApplicationFeesByID(3).ToString();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtLicenseID.Text))
            {
                MessageBox.Show("Please enter a valid License ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseID.Focus();
                return;
            }

            if (!int.TryParse(txtLicenseID.Text.Trim(), out int licenseID))
            {
                MessageBox.Show("License ID must be a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;
            }

            _selectedLicenseID = licenseID;
            ctrlDriverLicenseInfo1.LoadDriverLicenseInfo(licenseID);

            _License = clsLicense.Find(licenseID);

            if (_License.IsActive == false)
            {
                MessageBox.Show("The selected license is not active.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnIssueReplacement.Enabled = false;
                return;
            }
            else 
            {
            btnIssueReplacement.Enabled = true;
            }

            ctrlApplicationInfoForLicenseReplacement1.OldLicenseID = licenseID.ToString();
            ctrlApplicationInfoForLicenseReplacement1.ApplicationDate = DateTime.Now.ToShortDateString();

            btnIssueReplacement.Enabled = true;
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

        private void _CreateNewApplicationForReplacement()
        {
            clsApplication oldApplication = clsApplication.Find(_License.ApplicationID);
            clsApplication newApplication = new clsApplication();
            newApplication.PersonID = oldApplication.PersonID;
            newApplication.ApplicationDate1 = DateTime.Now;
            newApplication.TypeID1 = rbDamagedLicense.Checked ? 4 : 3;
            newApplication.Status = 1;
            newApplication.LastStatusDate = DateTime.Now;
            newApplication.PaidFees = (decimal)clsApplicationType.GetApplicationFeesByID(newApplication.TypeID1);
            newApplication.UserID = _User.UserID;

            clsApplication.enSave saveResult = newApplication.Save();

            switch (saveResult)
            {
                case clsApplication.enSave.enAddScc:
                    MessageBox.Show("Replacement application created successfully. Application ID : " + newApplication.ApplicationID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _replacementApplicationID = newApplication.ApplicationID;
                    break;
                case clsApplication.enSave.enUpdateScc:
                    MessageBox.Show("Application updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsApplication.enSave.enLostScc:
                    MessageBox.Show("Failed to save the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            _replacementApplicationID = newApplication.ApplicationID;

        }

        private void _CreateNewLicenseForReplacement()
        {
            clsLicense newLicense = new clsLicense();
            newLicense.ApplicationID = _replacementApplicationID;
            newLicense.DriverID = _License.DriverID;
            newLicense.LicenseClassID = _License.LicenseClassID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpiryDate = DateTime.Now.AddYears(5);
            newLicense.Note = "Replacement for License ID: " + _selectedLicenseID;
            newLicense.PaidFees = 20.00;
            newLicense.IsActive = true;
            newLicense.IssueReason = rbDamagedLicense.Checked ? clsLicense.enIssueReason.ReplacementForDamage : clsLicense.enIssueReason.ReplacementForLost;
            newLicense.IssuedByUserID = _User.UserID;
            clsLicense.enSave saveResult = newLicense.Save();
            switch (saveResult)
            {
                case clsLicense.enSave.enAddScc:
                    MessageBox.Show("Replacement license issued successfully. License ID : " + newLicense.LicenseID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _replacedLicenseID = newLicense.LicenseID;
                    break;
                case clsLicense.enSave.enFailed:
                    MessageBox.Show("Failed to issue the replacement license.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            _replacedLicenseID = newLicense.LicenseID;

        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                MessageBox.Show("Please select or search for a valid License first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string replacementType = rbDamagedLicense.Checked ? "Damaged" : "Lost";

            if (MessageBox.Show($"Are you sure you want to issue a replacement for this {replacementType} License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                _CreateNewApplicationForReplacement();
                _CreateNewLicenseForReplacement();

                clsLicense.PutLicenseNotActiveByID(_selectedLicenseID);

                ctrlApplicationInfoForLicenseReplacement1.LoadApplicationInfo(_replacementApplicationID, DateTime.Now, 20.00,
                    _replacedLicenseID, _selectedLicenseID, _User.UserID);

                MessageBox.Show($"Replacement License Issued Successfully with ID = {_replacedLicenseID}", "License Replaced", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnIssueReplacement.Enabled = false;
                gbFilter.Enabled = false;
                gbReplacementFor.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
