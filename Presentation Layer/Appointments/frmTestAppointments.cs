using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer;
using PresentationLayer;

namespace DVLD.Presentation_Layer
{
    public partial class frmTestAppointments : Form
    {

        private clsLocalDrivingLicenseApplication Application;
        private int PassedTests;
        private double Fees;
        private string FullName;


        public frmTestAppointments(int LocalDrivingLicenseID,int passedTests,string fullName,double Fees)
        {
            InitializeComponent();

            Application = clsLocalDrivingLicenseApplication.Find(LocalDrivingLicenseID);
            PassedTests = passedTests;
            this.Fees = Fees;
            this.FullName = fullName;

            _LoadDataOfControls();
        }

        private void _LoadDataOfControls() 
        {
        
            ctrlDrivingLicenseApplicationInfo.LoadDrivingLicenseApplicationInfo(Application, PassedTests);
            ctrlApplicationBasicInfo.LoadApplicationInfo(Application.ApplicationID);

        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            frmTakeAppointment frm = new frmTakeAppointment(Application, FullName, Fees);
            frm.ShowDialog();

        }

        private void dgvAppointments_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAppointments.ClearSelection();
                dgvAppointments.Rows[e.RowIndex].Selected = true;
            }
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement Edit logic
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement Take Test logic
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
