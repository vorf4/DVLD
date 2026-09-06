using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class frmInternationalLicenseApplications : Form
    {
        public frmInternationalLicenseApplications()
        {
            InitializeComponent();
        }

        private void frmInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            UpdateRecordCount();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = cbFilterBy.Text;

            if (selectedFilter == "None")
            {
                txtFilterValue.Visible = false;
                cbFilterValue.Visible = false;
            }
            else if (selectedFilter == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbFilterValue.Visible = true;
                cbFilterValue.SelectedIndex = 0;
            }
            else
            {
                txtFilterValue.Visible = true;
                cbFilterValue.Visible = false;
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            // Optional: Implement filtering logic when bound to DataTable or DataView
            UpdateRecordCount();
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
    }
}
