using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlApplicationInfo : UserControl
    {
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string InternationalApplicationID
        {
            get => lblILApplicationIDValue.Text;
            set => lblILApplicationIDValue.Text = value;
        }

        public string ApplicationDate
        {
            get => lblApplicationDateValue.Text;
            set => lblApplicationDateValue.Text = value;
        }

        public string IssueDate
        {
            get => lblIssueDateValue.Text;
            set => lblIssueDateValue.Text = value;
        }

        public string Fees
        {
            get => lblFeesValue.Text;
            set => lblFeesValue.Text = value;
        }

        public string InternationalLicenseID
        {
            get => lblILLicenseIDValue.Text;
            set => lblILLicenseIDValue.Text = value;
        }

        public string LocalLicenseID
        {
            get => lblLocalLicenseIDValue.Text;
            set => lblLocalLicenseIDValue.Text = value;
        }

        public string ExpirationDate
        {
            get => lblExpirationDateValue.Text;
            set => lblExpirationDateValue.Text = value;
        }

        public string CreatedBy
        {
            get => lblCreatedByValue.Text;
            set => lblCreatedByValue.Text = value;
        }

        #endregion

        #region Public Methods

        public void ResetDefaultValues()
        {
            lblILApplicationIDValue.Text = "[???]";
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            lblIssueDateValue.Text = DateTime.Now.ToShortDateString();
            lblFeesValue.Text = "50";
            lblILLicenseIDValue.Text = "[???]";
            lblLocalLicenseIDValue.Text = "[???]";
            lblExpirationDateValue.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedByValue.Text = "[???]";
        }

        public void LoadApplicationInfo(int ApplicationID,DateTime ApplicationDate,DateTime IssueDate,decimal Fees
            ,int InternationalLicenseID,int LocalLicenseID,DateTime ExpirationDate,int CreatedBy)
        {

            lblILApplicationIDValue.Text = ApplicationID.ToString();
            lblApplicationDateValue.Text = ApplicationDate.ToShortDateString();
            lblIssueDateValue.Text = IssueDate.ToShortDateString();
            lblFeesValue.Text = Fees.ToString("F2");
            lblILLicenseIDValue.Text = InternationalLicenseID.ToString();
            lblLocalLicenseIDValue.Text = LocalLicenseID.ToString();
            lblExpirationDateValue.Text = ExpirationDate.ToShortDateString();
            lblCreatedByValue.Text = CreatedBy.ToString();

        }

        #endregion
    }
}
