using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmRenewLocalDrivingLicense : Form
    {
        private clsLicense _SelectedLicense;
        private clsLicense _NewLicense;
        private clsApplication _NewApplication;
        private clsUser _User;
        public frmRenewLocalDrivingLicense(clsUser User)
        {
            InitializeComponent();
            _User = User;
        }

        private bool _Verification() 
        {
        
            if(_SelectedLicense.ExpiryDate > DateTime.Now)
            { 
                MessageBox.Show("The Selected License isn't expired ,he needs to be renewed after : [" + _SelectedLicense.ExpiryDate+ "]", "License Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }if(_SelectedLicense.IsActive == false)
            {
                MessageBox.Show("The Selected License isn't active", "License Not Active", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; 
        
        }

        private void frmRenewLocalDrivingLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLocalLicenseInfo1.ResetDefaultValues();
            ctrlApplicationNewLicenseInfo1.ResetDefaultValues();

            btnRenew.Enabled = false;
            llShowNewLicenseInfo.Enabled = false;
            llShowLicensesHistory.Enabled = false;
        }

        private void btnAddNewLicense_Click(object sender, EventArgs e)
        {

            _SelectedLicense = clsLicense.Find(Convert.ToInt32(txtLicenseID.Text));

            ctrlDriverLocalLicenseInfo1.LoadDriverLicenseInfo(_SelectedLicense.LicenseID);

            if (!_Verification())
            {

                btnRenew.Enabled = false;
                llShowNewLicenseInfo.Enabled = false;
                llShowLicensesHistory.Enabled = false;

            }
            else 
            {
                btnRenew.Enabled = true;
                llShowNewLicenseInfo.Enabled = true;
                llShowLicensesHistory.Enabled = true;
            }

        }

        private void txtLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAddNewLicense_Click(sender, e);
            }
        }

        private void _CreateNewApplication() 
        {

            clsApplication oldApplciation = clsApplication.Find(_SelectedLicense.ApplicationID);
            _NewApplication = new clsApplication();

            _NewApplication.PersonID = oldApplciation.PersonID;
            _NewApplication.ApplicationDate1 = DateTime.Now;
            _NewApplication.TypeID1 = 2;
            _NewApplication.Status = 1;
            _NewApplication.LastStatusDate = DateTime.Now;
            _NewApplication.PaidFees = (decimal)clsApplicationType.GetApplicationFeesByID(2);
            _NewApplication.UserID = _User.UserID;
            clsApplication.enSave result = _NewApplication.Save();

            switch (result) 
            {
            
                case clsApplication.enSave.enAddScc:
                    MessageBox.Show("New Application Created Successfully", "New Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsApplication.enSave.enLostScc:
                    MessageBox.Show("New Application Creation Failed", "New Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }

        }

        private void _CreateNewLicense()
        {
            _NewLicense = new clsLicense();
            _NewLicense.ApplicationID = _NewApplication.ApplicationID;
            _NewLicense.DriverID = _SelectedLicense.DriverID;
            _NewLicense.LicenseClassID = _SelectedLicense.LicenseClassID;
            _NewLicense.IssueDate = DateTime.Now;
            _NewLicense.ExpiryDate = DateTime.Now.AddYears(5);
            _NewLicense.Note = _SelectedLicense.Note;
            _NewLicense.PaidFees = 20.00;
            _NewLicense.IsActive = true;
            _NewLicense.IssueReason = clsLicense.enIssueReason.Renewal;
            _NewLicense.IssuedByUserID = _User.UserID;

            clsLicense.enSave result = _NewLicense.Save();
            switch (result)
            {
                case clsLicense.enSave.enAddScc:
                    MessageBox.Show("New License Created Successfully, License ID : " + _NewLicense.LicenseID, "New License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case clsLicense.enSave.enFailed:
                    MessageBox.Show("New License Creation Failed", "New License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

            _CreateNewApplication();
            _CreateNewLicense();
            clsLicense.PutLicenseNotActiveByID(_SelectedLicense.LicenseID);
            ctrlApplicationNewLicenseInfo1.LoadApplicationInfo(_NewLicense,_NewApplication,_SelectedLicense.LicenseID);
            btnRenew.Enabled = false;


        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
     
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
