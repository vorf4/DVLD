using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlReleaseLicenseInfo : UserControl
    {
        public ctrlReleaseLicenseInfo()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string DetainIDValue
        {
            get => lblDetainID.Text;
            set => lblDetainID.Text = value;
        }

        public string DetainDateValue
        {
            get => lblDetainDate.Text;
            set => lblDetainDate.Text = value;
        }

        public string LicenseIDValue
        {
            get => lblLicenseID.Text;
            set => lblLicenseID.Text = value;
        }

        public string CreatedByValue
        {
            get => lblCreatedBy.Text;
            set => lblCreatedBy.Text = value;
        }

        public decimal ApplicationFees
        {
            get
            {
                if (decimal.TryParse(lblApplicationFees.Text, out decimal result))
                    return result >= 0 ? result : 0m;
                return 0m;
            }
            set
            {
                lblApplicationFees.Text = value.ToString("0.00");
                UpdateTotalFees();
            }
        }

        public decimal FineFees
        {
            get
            {
                if (decimal.TryParse(lblFineFees.Text, out decimal result))
                    return result >= 0 ? result : 0m;
                return 0m;
            }
            set
            {
                lblFineFees.Text = value.ToString("0.00");
                UpdateTotalFees();
            }
        }

        public decimal TotalFees
        {
            get => ApplicationFees + FineFees;
        }

        #endregion

        #region Private Helpers

        private void UpdateTotalFees()
        {
            lblTotalFees.Text = TotalFees.ToString("0.00");
        }

        #endregion

        #region Public Helper Methods

        public void ResetDefaultValues()
        {
            lblDetainID.Text = "[???]";
            lblDetainDate.Text = "[??/??/????]";
            lblLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            lblApplicationFees.Text = "[$$$]";
            lblFineFees.Text = "[$$$]";
            lblTotalFees.Text = "[???]";
        }

        /// <summary>
        /// Populates all fields of the Detain Info release control.
        /// </summary>
        /// <param name="detainID">The Detain record ID.</param>
        /// <param name="detainDate">Date the license was detained.</param>
        /// <param name="licenseID">The detained License ID.</param>
        /// <param name="createdBy">Username of the officer who created the detain record.</param>
        /// <param name="applicationFees">Application fees for the release (fixed admin fee).</param>
        /// <param name="fineFees">Fine fees accumulated for the detention period.</param>
        public void LoadReleaseLicenseInfo(int detainID, DateTime detainDate, int licenseID,
                                           int createdBy, decimal applicationFees, decimal fineFees)
        {
            lblDetainID.Text = detainID.ToString();
            lblDetainDate.Text = detainDate.ToString("dd/MM/yyyy");
            lblLicenseID.Text = licenseID.ToString();
            lblCreatedBy.Text = createdBy.ToString();

            // Setters also call UpdateTotalFees()
            ApplicationFees = applicationFees;
            FineFees = fineFees;
        }

        #endregion
    }
}
