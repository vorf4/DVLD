using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmInternationalLicenseApplications : Form
    {

        private DataTable _dtInternationalLicenses;
        public frmInternationalLicenseApplications()
        {
            InitializeComponent();

            LoadDgvInfo();
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
        }

        private void LoadDgvInfo() 
        {
        
            _dtInternationalLicenses = clsLicense.GetAllInternationalLicensesInfo();

            // 1. Prevent creating duplicate/extra columns
            dgvInternationalLicenseApplications.AutoGenerateColumns = false;

            // 2. Map existing DGV columns to the DataTable column names
            // (Replace the dgv column names below with your actual designer names)
            dgvInternationalLicenseApplications.Columns["colIntLicenseID"].DataPropertyName = "int license ID";
            dgvInternationalLicenseApplications.Columns["colApplicationID"].DataPropertyName = "ApplicationID";
            dgvInternationalLicenseApplications.Columns["colDriverID"].DataPropertyName = "DriverID";
            dgvInternationalLicenseApplications.Columns["colLLicenseID"].DataPropertyName = "Loacl License";
            dgvInternationalLicenseApplications.Columns["colIssueDate"].DataPropertyName = "IssueDate";
            dgvInternationalLicenseApplications.Columns["colExpirationDate"].DataPropertyName = "ExpirationDate";
            dgvInternationalLicenseApplications.Columns["colIsActive"].DataPropertyName = "IsActive";

            // 3. Bind the DataTable to the DataGridView

            dgvInternationalLicenseApplications.DataSource = _dtInternationalLicenses;


        }

        private void frmInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            UpdateRecordCount();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Text = "";
            _dtInternationalLicenses.DefaultView.RowFilter = "";

            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbFilterValue.Visible = true;
                cbFilterValue.SelectedIndex = 0;
                cbFilterValue.Focus();
            }
            else if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                cbFilterValue.Visible = false;
            }
            else
            {
                txtFilterValue.Visible = true;
                cbFilterValue.Visible = false;
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtInternationalLicenses == null) return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Int License ID":
                    // Enclose column name in brackets due to spaces
                    filterColumn = "[int license ID]";
                    break;

                case "Application ID":
                    filterColumn = "ApplicationID";
                    break;

                default:
                    filterColumn = "None";
                    break;
            }

            // Reset filter if input is empty or "None" is chosen
            if (string.IsNullOrWhiteSpace(txtFilterValue.Text) || filterColumn == "None")
            {
                _dtInternationalLicenses.DefaultView.RowFilter = "";
                return;
            }

            // Since these IDs are integer numbers, filter with numeric equality or string conversion:
            if (int.TryParse(txtFilterValue.Text.Trim(), out int idValue))
            {
                _dtInternationalLicenses.DefaultView.RowFilter = string.Format("{0} = {1}", filterColumn, idValue);
            }
            else
            {
                // Prevent crashes if non-numeric values are typed
                _dtInternationalLicenses.DefaultView.RowFilter = "";
            }
        }

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtInternationalLicenses == null) return;

            string filterValue = cbFilterValue.Text;

            switch (filterValue)
            {
                case "All":
                    _dtInternationalLicenses.DefaultView.RowFilter = "";
                    break;

                case "Yes":
                    _dtInternationalLicenses.DefaultView.RowFilter = "IsActive = 1";
                    break;

                case "No":
                    _dtInternationalLicenses.DefaultView.RowFilter = "IsActive = 0";
                    break;
            }
        }

        private void dgvInternationalLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvInternationalLicenseApplications.ClearSelection();
                dgvInternationalLicenseApplications.Rows[e.RowIndex].Selected = true;
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenseApplications.CurrentRow == null) return;
            // TODO: Open Person Details Form
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenseApplications.CurrentRow == null) return;
            // TODO: Open License Details Form
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenseApplications.CurrentRow == null) return;
            // TODO: Open Person License History Form
        }

        private void UpdateRecordCount()
        {
            lblRecord.Text = $"# Records: {dgvInternationalLicenseApplications.Rows.Count}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Int License ID" || cbFilterBy.Text == "Application ID")
            {
                // Allow only digits and the backspace key
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
