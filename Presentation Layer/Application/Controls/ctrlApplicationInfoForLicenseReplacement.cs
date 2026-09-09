using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlApplicationInfoForLicenseReplacement : UserControl
    {
        public ctrlApplicationInfoForLicenseReplacement()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string ReplacementApplicationID
        {
            get => lblReplacementApplicationID.Text;
            set => lblReplacementApplicationID.Text = value;
        }

        public string ApplicationDate
        {
            get => lblApplicationDate.Text;
            set => lblApplicationDate.Text = value;
        }

        public string ApplicationFees
        {
            get => lblApplicationFees.Text;
            set => lblApplicationFees.Text = value;
        }

        public string ReplacedLicenseID
        {
            get => lblReplacedLicenseID.Text;
            set => lblReplacedLicenseID.Text = value;
        }

        public string OldLicenseID
        {
            get => lblOldLicenseID.Text;
            set => lblOldLicenseID.Text = value;
        }

        public string CreatedBy
        {
            get => lblCreatedBy.Text;
            set => lblCreatedBy.Text = value;
        }

        #endregion

        #region Helper Methods

        public void ResetDefaultValues()
        {
            lblReplacementApplicationID.Text = "[???]";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = "5.00";
            lblReplacedLicenseID.Text = "[???]";
            lblOldLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
        }

        public void LoadApplicationInfo(int replacementApplicationID, DateTime applicationDate, double applicationFees,
            int replacedLicenseID, int oldLicenseID, int createdBy)
        {
            lblReplacementApplicationID.Text = replacementApplicationID.ToString();
            lblApplicationDate.Text = applicationDate.ToShortDateString();
            lblApplicationFees.Text = applicationFees.ToString("F2");
            lblReplacedLicenseID.Text = replacedLicenseID.ToString();
            lblOldLicenseID.Text = oldLicenseID.ToString();
            lblCreatedBy.Text = createdBy.ToString();
        }

        #endregion
    }
}
