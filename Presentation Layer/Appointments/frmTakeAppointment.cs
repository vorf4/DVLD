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
        private int TestTypeID;
        private int RetakeApplicationID;

        public frmTakeAppointment(clsLocalDrivingLicenseApplication Application,string FullName, double fees 
            , clsUser user,int TestTypeID,int RetakeApplicationID = -1)
        {
            InitializeComponent();

            _Application = Application;
            _FullName = FullName;
            _Fees = fees;
            _User = user;
            this.TestTypeID = TestTypeID;
            this.RetakeApplicationID = RetakeApplicationID;

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
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            clsAppointment appointment = new clsAppointment();
            appointment.LocalDrivingLicenseApplicationID1 = _Application.LocalDrivingLicenseApplicationID;
            appointment.TestTypeID1 = TestTypeID;
            appointment.AppointmentDate1 = dtpAppointmentDate.Value;
            appointment.PaidFees1 = _Fees;
            appointment.UserID1 = _User.UserId;
            appointment.IsLocked1 = false;
            appointment.RetakeTestAppointmentID1 = RetakeApplicationID;

            clsAppointment.enSave result = appointment.save();

            switch (result) 
            {
            
                case clsAppointment.enSave.enAddScc:
                    MessageBox.Show("Appointment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case clsAppointment.enSave.enEditScc:
                    MessageBox.Show("Appointment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
                case clsAppointment.enSave.enFailedScc:
                    MessageBox.Show("Failed to save appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbScheduleTest_Enter(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
