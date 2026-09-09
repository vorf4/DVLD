using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Presentation_Layer
{
    public partial class ctrlDetainInfo : UserControl
    {
        public ctrlDetainInfo()
        {
            InitializeComponent();
        }

        #region Public Properties

        public string DetainID
        {
            get => lblDetainID.Text;
            set => lblDetainID.Text = value;
        }

        public string DetainDate
        {
            get => lblDetainDate.Text;
            set => lblDetainDate.Text = value;
        }

        public string LicenseID
        {
            get => lblLicenseID.Text;
            set => lblLicenseID.Text = value;
        }

        public string CreatedBy
        {
            get => lblCreatedBy.Text;
            set => lblCreatedBy.Text = value;
        }

        public decimal FineFees
        {
            get
            {
                if (decimal.TryParse(txtFineFees.Text.Trim(), out decimal result))
                {
                    return result >= 0 ? result : 0m;
                }
                return 0m;
            }
            set
            {
                txtFineFees.Text = value.ToString("0.00");
            }
        }

        public string FineFeesText
        {
            get => txtFineFees.Text;
            set => txtFineFees.Text = value;
        }

        public bool FineFeesEnabled
        {
            get => txtFineFees.Enabled;
            set => txtFineFees.Enabled = value;
        }

        #endregion

        #region Public Helper Methods

        public void ResetDefaultValues()
        {
            lblDetainID.Text = "[???]";
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblLicenseID.Text = "[???]";
            lblCreatedBy.Text = "[???]";
            txtFineFees.Text = "";
            errorProvider1.SetError(txtFineFees, null);
        }

        public bool ValidateFineFees()
        {
            string text = txtFineFees.Text.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                errorProvider1.SetError(txtFineFees, "Fine Fees is required.");
                return false;
            }

            if (!decimal.TryParse(text, out decimal val))
            {
                errorProvider1.SetError(txtFineFees, "Only valid numeric input is allowed.");
                return false;
            }

            if (val < 0)
            {
                errorProvider1.SetError(txtFineFees, "Fine Fees cannot be negative.");
                return false;
            }

            errorProvider1.SetError(txtFineFees, null);
            return true;
        }

        #endregion

        #region Event Handlers

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys, digits, and a single decimal point
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            // Allow decimal point if not already present
            if (e.KeyChar == '.' && !txtFineFees.Text.Contains("."))
            {
                return;
            }

            e.Handled = true;
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            ValidateFineFees();
        }

        #endregion
    }
}
