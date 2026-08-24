using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmTakeTest : Form
    {

        public event Action<bool> isPassed;

        private clsApplication Application;
        private clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication;
        private int TryNumber; 
        private DateTime AppointmentDate;
        private double Fees;
        private int AppointmentID;
        private int CreateByUserID;

        public frmTakeTest(clsApplication Application, clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication
            , int TryNumber, DateTime AppointmentDate, double Fees, int AppointmentID,int CreateByUserID)
        {
            InitializeComponent();

            this.Application = Application;
            this.TryNumber = TryNumber;
            this.AppointmentDate = AppointmentDate;
            this.Fees = Fees;
            this.LocalDrivingLicenseApplication = LocalDrivingLicenseApplication;
            this.AppointmentID = AppointmentID;
            this.CreateByUserID = CreateByUserID;

            LoadDataToForm();

        }

        private void LoadDataToForm() 
        {
        
            lblApplicantNameValue.Text = clsApplicationType.GetApplicationTypeTitle(Application.TypeID1);
            lblAppointmentDateValue.Text = AppointmentDate.ToString("dd/MM/yyyy");
            lblDrivingClassValue.Text = clsLicenseClass.GetClassName(LocalDrivingLicenseApplication.LicenseClassID1);
            lblLocalDrivingLicenseApplicationIDValue.Text = LocalDrivingLicenseApplication.ApplicationID.ToString();
            lblPaidFeesValue.Text = Fees.ToString("C2");
            lblTrialValue.Text = TryNumber.ToString();

        }

        // -------------------------------------------------------
        //  Result radio buttons
        // -------------------------------------------------------

        private void rbPass_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFail_CheckedChanged(object sender, EventArgs e)
        {
        }

        // -------------------------------------------------------
        //  Notes text box
        // -------------------------------------------------------

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {
        }

        // -------------------------------------------------------
        //  Bottom buttons
        // -------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {

            clsTests test = new clsTests();

            test.TestAppointmentID= AppointmentID;
            test.TestResult = rbPass.Checked;
            test.Notes = txtNotes.Text;
            test.CreatedByUserID = CreateByUserID;
            isPassed?.Invoke(test.TestResult);

            if(test.SaveTest())
            {
                MessageBox.Show("Test result saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsAppointment.UpdateDataOfIsLocked(AppointmentID, true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save test result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbTakeTest_Enter(object sender, EventArgs e)
        {

        }
    }
}
