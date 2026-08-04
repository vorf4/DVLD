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
        private clsUser _User;

        public frmTakeAppointment(clsLocalDrivingLicenseApplication Application,string FullName, double fees , clsUser user)
        {
            InitializeComponent();

            _Application = Application;
            _FullName = FullName;
            _Fees = fees;
            _User = user;

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
            
            clsAppointment appointment = new clsAppointment();
            appointment.LocalDrivingLicenseApplicationID1 = _Application.LocalDrivingLicenseApplicationID;
            appointment.TestTypeID1 = 1;
            appointment.AppointmentDate1 = dtpAppointmentDate.Value;
            appointment.PaidFees1 = _Fees;
            appointment.UserID1 = _User.UserId;
            appointment.IsLocked1 = false;
            appointment.RetakeTestAppointmentID1 = -1;

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
