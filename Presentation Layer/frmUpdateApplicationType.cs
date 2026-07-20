using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmUpdateApplicationType : Form
    {
        private int _applicationTypeID;

        public frmUpdateApplicationType(int applicationTypeID)
        {
            InitializeComponent();
            _applicationTypeID = applicationTypeID;
            lblIDValue.Text = applicationTypeID.ToString();

        }

        private bool _CheckIfFieldsAreEmpty()
        {
            if (string.IsNullOrWhiteSpace(txtApplicationTitle.Text) || string.IsNullOrWhiteSpace(txtApplicationFees.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (!double.TryParse(txtApplicationFees.Text, out _))
            {
                MessageBox.Show("Please enter a valid fee amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_CheckIfFieldsAreEmpty())
                return;

            clsApplicationType.UpdateApplicationType(_applicationTypeID, txtApplicationTitle.Text, double.Parse(txtApplicationFees.Text));
            MessageBox.Show("Application type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtApplicationTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApplicationFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtApplicationFees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
