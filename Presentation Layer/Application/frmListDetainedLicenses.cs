using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmListDetainedLicenses : Form
    {
        private clsUser _User;
        private DataTable _dtDetainedLicenses;

        public frmListDetainedLicenses(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private void LoadDataToDgv() 
        {

            DataTable dt = clsDetainLicense.GetAllDetainedLicensesList();

            dgvDetainedLicenses.AutoGenerateColumns = true;
            dgvDetainedLicenses.DataSource = dt;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                // 1. Rename Column Headers
                dgvDetainedLicenses.Columns["DetainID"].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns["LicenseID"].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns["DetainDate"].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns["IsReleased"].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns["FineFees"].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns["ReleaseDate"].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns["NationalNo"].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns["FullName"].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "Release App.ID";
            }

            _dtDetainedLicenses = dt; // Store the original data for filtering

            UpdateRecordCount();

        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {

          LoadDataToDgv();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            _dtDetainedLicenses.DefaultView.RowFilter = "";

            if (cbFilterBy.Text == "Is Released")
            {
                txtFilterValue.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.SelectedIndex = 0;
                cbIsReleased.Focus();
            }
            else if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                cbIsReleased.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;
                cbIsReleased.Visible = false;
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtDetainedLicenses == null) return;

            string filterColumn = "";

            // Map the ComboBox display text to actual Database/DataTable column names
            switch (cbFilterBy.Text)
            {
                case "Detain ID":
                    txtFilterValue.KeyPress += txtFilterValue_KeyPress;
                    filterColumn = "DetainID";
                    break;

                case "National No.":
                    txtFilterValue.KeyPress -= txtFilterValue_KeyPress;
                    filterColumn = "NationalNo";
                    break;

                case "Full Name":
                    txtFilterValue.KeyPress -= txtFilterValue_KeyPress;
                    filterColumn = "FullName";
                    break;

                case "Release Application ID":
                    txtFilterValue.KeyPress += txtFilterValue_KeyPress;
                    filterColumn = "ReleaseApplicationID";
                    break;

                default:
                    filterColumn = "None";
                    break;
            }

            // Reset filter if input is cleared or "None" selected
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtDetainedLicenses.DefaultView.RowFilter = "";
                return;
            }

            // Numeric filtering for IDs
            if (filterColumn == "DetainID" || filterColumn == "ReleaseApplicationID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int idVal))
                {
                    _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, idVal);
                }
                else
                {
                    _dtDetainedLicenses.DefaultView.RowFilter = "";
                }
            }
            // String filtering (wildcard match)
            else
            {
                _dtDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterValue.Text.Trim().Replace("'", "''"));
            }

            UpdateRecordCount();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Detain ID" || cbFilterBy.Text == "Release Application ID")
            {
                // Accept only digits and control keys (like Backspace)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void dgvDetainedLicenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvDetainedLicenses.ClearSelection();
                dgvDetainedLicenses.Rows[e.RowIndex].Selected = true;

                // Enable / disable "Release Detained License" based on whether
                // the row is already released.  Reads the checkbox column value.
                bool isReleased = false;

                DataGridViewRow row = dgvDetainedLicenses.Rows[e.RowIndex];
                object cellValue = row.Cells["IsReleased"].Value;

                if (cellValue is bool boolVal)
                    isReleased = boolVal;
                else if (cellValue != null && cellValue != DBNull.Value)
                    bool.TryParse(cellValue.ToString(), out isReleased);

                tsmiReleaseDetainedLicense.Enabled = !isReleased;
            }
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {

            frmDetainLicense frmDetainLicense = new frmDetainLicense(_User);
            frmDetainLicense.ShowDialog();

            LoadDataToDgv(); // Refresh the grid after detaining a license
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {

            frmReleaseDetainedLicense frmReleaseDetainedLicense = new frmReleaseDetainedLicense(_User);
            frmReleaseDetainedLicense.ShowDialog();

            LoadDataToDgv(); // Refresh the grid after releasing a license

        }

        private void tsmiShowPersonDetails_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;
            // TODO: Open Person Details form for the selected row.
        }

        private void tsmiShowLicenseDetails_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;
            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value);
            frmLicenseInfo frm = new frmLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;
            // TODO: Open Person License History form for the selected row.
        }

        private void tsmiReleaseDetainedLicense_Click(object sender, EventArgs e)
        {

            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(_User, LicenseID);
            frm.ShowDialog();
            LoadDataToDgv(); // Refresh the grid after releasing a license

        }

        private void UpdateRecordCount()
        {
            lblRecord.Text = $"# Records: {dgvDetainedLicenses.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsDetainedLicenses_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtDetainedLicenses == null) return;

            string filterValue = cbIsReleased.Text;

            switch (filterValue)
            {
                case "All":
                    _dtDetainedLicenses.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 1";
                    break;

                case "No":
                    _dtDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 0";
                    break;
            }
            UpdateRecordCount();
        }
    }
}
