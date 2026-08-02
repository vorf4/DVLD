using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace PresentationLayer
{
    public partial class frmTakeAppointment : Form
    {

        private clsLocalDrivingLicenseApplication _Application;
        private string _FullName;
        private double _Fees;

        public frmTakeAppointment(clsLocalDrivingLicenseApplication Application,string FullName, double fees)
        {
            InitializeComponent();

            _Application = Application;
            _FullName = FullName;
            _Fees = fees;


            LoadDataToForm();

        }

        private void LoadDataToForm() 
        {
        
            lblLocalDrivingLicenseApplicationIDValue.Text = _Application.LocalDrivingLicenseApplicationID.ToString();
            lblDrivingClassValue.Text = clsLicenseClass.GetClassName(_Application.LicenseClassID1);
            lblApplicantNameValue.Text = _FullName;
            lblFeesValue.Text = _Fees.ToString("F2");
            dtpAppointmentDate.MinDate = DateTime.Now.AddDays(1);


        }

        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void gbScheduleTest_Enter(object sender, EventArgs e)
        {

        }
    }
}
