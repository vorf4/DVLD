using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer;
using PresentationLayer;

namespace DVLD.Presentation_Layer
{
    public partial class frmTestAppointments : Form
    {

        private clsLocalDrivingLicenseApplication LocalApplication;
        private int PassedTests;
        private double Fees;
        private string FullName;
        private clsUser User;
        private int TestTypeID;


        private void LoadAppointmentData()
        {

            DataTable dt = clsAppointment.GetAppointmentsByLocalID(LocalApplication.LocalDrivingLicenseApplicationID, TestTypeID);
            if (dt.Rows.Count > 0)
            {

                dgvAppointments.Columns[0].DataPropertyName = "TestAppointmentID";
                dgvAppointments.Columns[1].DataPropertyName = "AppointmentDate";
                dgvAppointments.Columns[2].DataPropertyName = "PaidFees";
                dgvAppointments.Columns[3].DataPropertyName = "IsLocked";

                dgvAppointments.DataSource = dt;
                
                lblRecords.Text = dt.Rows.Count.ToString() + " Record(s) Found";
            }
            else
            {
                dgvAppointments.DataSource = null;
            }
        }

        private void LoadAppointmentTitle(int PassedTests) 
        {

            if(PassedTests == 0)
            {
                this.Text = "Schedule Vision Test";
                lblTitle.Text = "Schedule Vision Test";
            }
           else if (PassedTests == 1)
            {
                this.Text = "Schedule Written Test";
                lblTitle.Text = "Schedule Written Test";
            }
            else if (PassedTests == 2)
            {
                this.Text = "Schedule Street Test";
                lblTitle.Text = "Schedule Street Test";
            }

        }

        public frmTestAppointments(int LocalDrivingLicenseID,int passedTests,string fullName,double Fees,clsUser User,int TestTypeID)
        {
            InitializeComponent();

            LocalApplication = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseID);
            PassedTests = passedTests;
            this.TestTypeID = TestTypeID;
            this.Fees = Fees;
            this.FullName = fullName;
            this.User = User;

            _LoadDataOfControls();
            LoadAppointmentData();
            LoadAppointmentTitle(PassedTests);
        }

        private void _LoadDataOfControls() 
        {
        
            ctrlDrivingLicenseApplicationInfo1.LoadDrivingLicenseApplicationInfo(LocalApplication, PassedTests);
            ctrlApplicationBasicInfo1.LoadApplicationInfo(LocalApplication.ApplicationID);

        }

        private int GetLastIndexOfAppointmentDataGridView()
        {
            if (dgvAppointments.Rows.Count > 0)
            {
                return dgvAppointments.Rows.Count - 1;
            }
            else
            {
                return -1;
            }
        }

        private bool IsAppointmentLocked()
        {

            bool isFound = false;

            int LastIndex = GetLastIndexOfAppointmentDataGridView();

            if (LastIndex != -1)
            {
                int AppointmentID1 = dgvAppointments.Rows[LastIndex].Cells["colAppointmentID"].Value != null ? Convert.ToInt32(dgvAppointments.Rows[LastIndex].Cells["colAppointmentID"].Value) : -1;

                if (!clsAppointment.IsAppointmentLockedPublic(AppointmentID1))
                {
                    isFound = true;
                }
            }
            else 
            {
                isFound = false; // No appointments found, so we can add a new appointment
            }

            return isFound;

        }

        private bool IsRetakeAppointment() 
        {
        
            bool isRetake = false;

            if (dgvAppointments.SelectedRows.Count > 0) 
            {

                isRetake = true;

            }

            return isRetake;

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            if (IsAppointmentLocked())
            {
                MessageBox.Show("The last appointment is locked. You cannot add a new appointment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (IsRetakeAppointment())
            {
                frmTakeAppointment frm = new frmTakeAppointment(LocalApplication, FullName, Fees, User, TestTypeID, LocalApplication.ApplicationID);
                frm.ShowDialog();
            }
            else 
            {
            frmTakeAppointment frm = new frmTakeAppointment(LocalApplication, FullName, Fees, User, TestTypeID);
            frm.ShowDialog();
            }

            
            LoadAppointmentData();

        }

        private void dgvAppointments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppointments.ClearSelection();
                dgvAppointments.Rows[e.RowIndex].Selected = true;
            }
        }

        private bool VerificationIfAppointmentIsLocked(int AppointmentID)
        {
            return clsAppointment.IsAppointmentLockedPublic(AppointmentID);
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement Edit logic
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Safety check: Ensure at least one row is selected to prevent crashes
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Store the single selected row in a variable for cleaner code
            DataGridViewRow selectedRow = dgvAppointments.SelectedRows[0];

            // 3. Extract data from the same selected row (index 0)
            int AppointmentID = selectedRow.Cells["colAppointmentID"].Value != null
                ? Convert.ToInt32(selectedRow.Cells["colAppointmentID"].Value)
                : -1;

            DateTime AppointmentDate = selectedRow.Cells["colAppointmentDate"].Value != null
                ? Convert.ToDateTime(selectedRow.Cells["colAppointmentDate"].Value)
                : DateTime.MinValue;

            double PaidFees = selectedRow.Cells["colPaidFees"].Value != null
                ? Convert.ToDouble(selectedRow.Cells["colPaidFees"].Value)
                : 0.0;

            int TryNumber = dgvAppointments.Rows.Count - 1;

            if (VerificationIfAppointmentIsLocked(AppointmentID))
            {
                MessageBox.Show("The selected appointment is locked. You cannot take the test.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 4. Open the form
            frmTakeTest frm = new frmTakeTest(clsApplication.Find(LocalApplication.ApplicationID), LocalApplication, TryNumber, AppointmentDate, PaidFees, AppointmentID,User.UserID);
            frm.isPassed += FrmIsPassed; // Subscribe to the event
            frm.ShowDialog();

            LoadAppointmentData(); // Refresh the data after the test is taken

        }

        private void FrmIsPassed(bool isPassed)
        {
            
            if(isPassed)
            {
                this.Close();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTestAppointments_Load(object sender, EventArgs e)
        {

        }

        private void ctrlApplicationBasicInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
