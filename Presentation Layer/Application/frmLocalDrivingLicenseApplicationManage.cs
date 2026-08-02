using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using PresentationLayer;

namespace DVLD.Presentation_Layer
{
    public partial class frmLocalDrivingLicenseApplicationManage : Form
    {


        public frmLocalDrivingLicenseApplicationManage(clsUser User)
        {
            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _User = User;

            _LoadDataToDgv();
        }

        private DataTable dt;
        private clsUser _User;

        private void _LoadDataToDgv()
        {
            // 1. Get the data from the database ONLY ONCE
            dt = clsLocalDrivingLicenseApplication.GetAllInfoOfLocalLicenseApplication();

            // 2. Send it to the grid
            _RefreshGridData();
        }

        private void _RefreshGridData()
        {
            if (dt == null) return;

            dgvLocalDriving.Rows.Clear();

            // CRITICAL FIX: Loop through dt.DefaultView using DataRowView, NOT dt.Rows
            foreach (DataRowView rowView in dt.DefaultView)
            {
                dgvLocalDriving.Rows.Add(
                    rowView["LocalDrivingLicenseApplicationID"],
                    rowView["ClassName"],
                    rowView["NationalNo"],
                    rowView["FullName"],
                    rowView["ApplicationDate"],
                    rowView["PassedTestCount"],
                    rowView["Status"]
                );
            }

            lblRecord.Text = "Record Count: " + dgvLocalDriving.Rows.Count.ToString();
        }
        
        private string _GetFilterColumnName(string filterBy)
        {
            switch (filterBy)
            {
                case "L.D.L.AppID": return "LocalDrivingLicenseApplicationID";
                case "National No.": return "NationalNo";
                case "Full Name": return "FullName";
                case "Passed Tests": return "PassedTestCount";
                default: return string.Empty;
            }
        }

        private void _ApplyFilter()
        {
            if (dt == null)
                return;

            string filterBy = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (filterBy == "None" || string.IsNullOrWhiteSpace(txtFilterValue.Text))
            {
                _RemoveFilter();
                return;
            }

            string columnName = _GetFilterColumnName(filterBy);
            if (string.IsNullOrEmpty(columnName))
            {
                _RemoveFilter();
                return;
            }

            string value = txtFilterValue.Text.Trim().Replace("'", "''");

            // CRITICAL FIX: The column name string must perfectly match what _GetFilterColumnName returns
            if (columnName == "LocalDrivingLicenseApplicationID" || columnName == "PassedTestCount")
            {
                // Allow partial search on numbers by converting to string
                dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", columnName, value);
            }
            else
            {
                dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", columnName, value);
            }

            // Refresh the grid to show the filtered data
            _RefreshGridData();
        }

        private void _ApplyFilterByStatus()
        {
            if (dt == null)
                return;

            string selectedStatus = cbFilterValue.SelectedItem?.ToString() ?? "All";

            if (selectedStatus == "All" || selectedStatus == "None")
            {
                _RemoveFilter();
                return;
            }

            dt.DefaultView.RowFilter = string.Format("[Status] = '{0}'", selectedStatus);

            // Refresh the grid to show the filtered data
            _RefreshGridData();
        }

        private void _RemoveFilter()
        {
            if (dt != null)
                dt.DefaultView.RowFilter = string.Empty;

            _RefreshGridData();
        }
      
        private void txtLDLAppID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
            }
        }
        
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.KeyPress-=txtLDLAppID_KeyPress;

            if (cbFilterBy.SelectedItem != null) 
            {

                if (cbFilterBy.SelectedItem.ToString() == "Status")
                {
                    txtFilterValue.Clear();
                    txtFilterValue.Visible = false;
                    cbFilterValue.Visible = true;
                    cbFilterValue.SelectedIndex = 0;




                }
                else 
                {

                    txtFilterValue.Clear();
                    txtFilterValue.Visible = true;
                    cbFilterValue.Visible = false;

                    if (cbFilterBy.SelectedItem.ToString() == "L.D.L.AppID")
                    {
                        txtFilterValue.KeyPress+=txtLDLAppID_KeyPress;
                    } 

                }

            }

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilterByStatus();
        }

        private void btnAddLocalDrivingLicense_Click(object sender, EventArgs e)
        {

            frmNewLocalDrivingLicenseApplication frm = new frmNewLocalDrivingLicenseApplication(_User);
            frm.ShowDialog();

            _LoadDataToDgv();

        }

        private void dgvLocalDriving_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = Convert.ToInt32(dgvLocalDriving.CurrentRow.Cells[0].Value);
            int ApplicationID = clsLocalDrivingLicenseApplication.GetApplicationID(LocalDrivingLicenseApplicationID);
            if (ApplicationID != -1) {
                
                clsApplication.CancelledApplication(ApplicationID);

                _LoadDataToDgv();

            }

        }

        private void CallTestAppointmentForm(double Fees)
        {
            int LocalDrivingLicenseApplicationID = Convert.ToInt32(dgvLocalDriving.CurrentRow.Cells[0].Value);
            int PassedTests = Convert.ToInt32(dgvLocalDriving.CurrentRow.Cells[5].Value);
            string FullName = dgvLocalDriving.CurrentRow.Cells[3].Value.ToString();

            frmTestAppointments frm = new frmTestAppointments(LocalDrivingLicenseApplicationID, PassedTests, FullName, Fees);
            frm.ShowDialog();
            _LoadDataToDgv();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
              CallTestAppointmentForm(15.00);
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallTestAppointmentForm(20.00);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallTestAppointmentForm(25.00);
        }

        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
