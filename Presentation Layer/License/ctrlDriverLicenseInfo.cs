using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string ClassValue
        {
            get => lblClassValue.Text;
            set => lblClassValue.Text = value;
        }

        public string DriverNameValue
        {
            get => lblNameValue.Text;
            set => lblNameValue.Text = value;
        }

        public string LicenseIDValue
        {
            get => lblLicenseIDValue.Text;
            set => lblLicenseIDValue.Text = value;
        }

        public string NationalNoValue
        {
            get => lblNationalNoValue.Text;
            set => lblNationalNoValue.Text = value;
        }

        public string GenderValue
        {
            get => lblGenderValue.Text;
            set => lblGenderValue.Text = value;
        }

        public string IssueDateValue
        {
            get => lblIssueDateValue.Text;
            set => lblIssueDateValue.Text = value;
        }

        public string IssueReasonValue
        {
            get => lblIssueReasonValue.Text;
            set => lblIssueReasonValue.Text = value;
        }

        public string NotesValue
        {
            get => lblNotesValue.Text;
            set => lblNotesValue.Text = value;
        }

        public string IsActiveValue
        {
            get => lblIsActiveValue.Text;
            set => lblIsActiveValue.Text = value;
        }

        public string DateOfBirthValue
        {
            get => lblDateOfBirthValue.Text;
            set => lblDateOfBirthValue.Text = value;
        }

        public string DriverIDValue
        {
            get => lblDriverIDValue.Text;
            set => lblDriverIDValue.Text = value;
        }

        public string ExpirationDateValue
        {
            get => lblExpirationDateValue.Text;
            set => lblExpirationDateValue.Text = value;
        }

        public string IsDetainedValue
        {
            get => lblIsDetainedValue.Text;
            set => lblIsDetainedValue.Text = value;
        }

        #endregion

        #region Helper Methods

        public void ResetDefaultValues()
        {
            lblClassValue.Text = "[???]";
            lblNameValue.Text = "[???]";
            lblLicenseIDValue.Text = "[???]";
            lblNationalNoValue.Text = "[???]";
            lblGenderValue.Text = "[???]";
            lblIssueDateValue.Text = "[???]";
            lblIssueReasonValue.Text = "[???]";
            lblNotesValue.Text = "[???]";

            lblIsActiveValue.Text = "[???]";
            lblDateOfBirthValue.Text = "[???]";
            lblDriverIDValue.Text = "[???]";
            lblExpirationDateValue.Text = "[???]";
            lblIsDetainedValue.Text = "[???]";
        }

        public void LoadDriverLicenseInfo(int licenseID)
        {

            clsLicense license = clsLicense.Find(licenseID);
            clsPerson Driver = clsPerson.Find(clsApplication.Find(license.ApplicationID).PersonID);

            if(Driver != null && license != null)
            {

                lblClassValue.Text = clsLicenseClass.GetClassName(license.LicenseClassID);
                lblNameValue.Text = clsPerson.GetFullName(Driver.PersonID);
                lblLicenseIDValue.Text = license.LicenseID.ToString();
                lblNationalNoValue.Text = Driver.NationalNo.ToString();
                lblGenderValue.Text = Driver.Gender.ToString();
                lblIssueDateValue.Text = license.IssueDate.ToString("yyyy-MM-dd");
                lblIssueReasonValue.Text = license.IssueReason.ToString();
                lblNotesValue.Text = license.Note.ToString();

                lblIsActiveValue.Text = license.IsActive ? "Yes" : "No";
                lblDateOfBirthValue.Text = Driver.DateOfBirth.ToString("yyyy-MM-dd");
                lblDriverIDValue.Text = license.DriverID.ToString();
                lblExpirationDateValue.Text = license.ExpiryDate.ToString("yyyy-MM-dd");
                lblIsDetainedValue.Text = "No";

            }

        }

        #endregion
    }
}
