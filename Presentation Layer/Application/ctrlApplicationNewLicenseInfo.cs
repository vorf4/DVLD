using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlApplicationNewLicenseInfo : UserControl
    {
        public ctrlApplicationNewLicenseInfo()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string RenewLocalApplicationID
        {
            get => lblRenewLocalApplicationID.Text;
            set => lblRenewLocalApplicationID.Text = value;
        }

        public string ApplicationDate
        {
            get => lblApplicationDate.Text;
            set => lblApplicationDate.Text = value;
        }

        public string IssueDate
        {
            get => lblIssueDate.Text;
            set => lblIssueDate.Text = value;
        }

        public string ApplicationFees
        {
            get => lblApplicationFees.Text;
            set => lblApplicationFees.Text = value;
        }

        public string LicenseFees
        {
            get => lblLicenseFees.Text;
            set => lblLicenseFees.Text = value;
        }

        public string Notes
        {
            get => txtNotes.Text;
            set => txtNotes.Text = value;
        }

        public string RenewedLicenseID
        {
            get => lblRenewedLicenseID.Text;
            set => lblRenewedLicenseID.Text = value;
        }

        public string OldLicenseID
        {
            get => lblOldLicenseID.Text;
            set => lblOldLicenseID.Text = value;
        }

        public string ExpirationDate
        {
            get => lblExpirationDate.Text;
            set => lblExpirationDate.Text = value;
        }

        public string CreatedBy
        {
            get => lblCreatedBy.Text;
            set => lblCreatedBy.Text = value;
        }

        public string TotalFees
        {
            get => lblTotalFees.Text;
            set => lblTotalFees.Text = value;
        }

        #endregion

        #region Public Methods

        public void ResetDefaultValues()
        {
            lblRenewLocalApplicationID.Text = "[???]";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = "7.00";
            lblLicenseFees.Text = "15.00";
            txtNotes.Text = string.Empty;

            lblRenewedLicenseID.Text = "[???]";
            lblOldLicenseID.Text = "[???]";
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedBy.Text = "[???]";
            lblTotalFees.Text = "22.00";
        }

        public void LoadApplicationInfo(clsLicense newLicense ,clsApplication application ,int oldLicenseID) 
        {
        
            if(newLicense != null && application != null)
            {
                lblRenewLocalApplicationID.Text = application.ApplicationID.ToString();
                lblApplicationDate.Text = application.ApplicationDate1.ToShortDateString();
                lblIssueDate.Text = newLicense.IssueDate.ToShortDateString();
                lblApplicationFees.Text = application.PaidFees.ToString("F2");
                lblLicenseFees.Text = 20.00.ToString("F2");
                txtNotes.Text = newLicense.Note.ToString();
                lblRenewedLicenseID.Text = newLicense.LicenseID.ToString();
                lblOldLicenseID.Text = oldLicenseID.ToString();
                lblExpirationDate.Text = newLicense.ExpiryDate.ToShortDateString();
                lblCreatedBy.Text = application.UserID.ToString();
                lblTotalFees.Text = (20.00 + double.Parse(lblApplicationFees.Text)).ToString("F2");
            }

        }

        #endregion
    }
}
