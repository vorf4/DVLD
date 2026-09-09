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
                // TODO: Call business layer to process the detain operation
                // Example: clsDetainedLicense.DetainLicense(_selectedLicenseID, fineFees, createdByUserID);

                MessageBox.Show($"License ID {_selectedLicenseID} has been detained successfully.",
                    "Detain Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnDetain.Enabled = false;
                gbFilter.Enabled = false;
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
