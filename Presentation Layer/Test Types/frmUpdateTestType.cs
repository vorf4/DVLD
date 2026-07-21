using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace DVLD.Presentation_Layer
{
    public partial class frmUpdateTestType : Form
    {

        int _TestTypeID;
        public frmUpdateTestType(int id)
        {
            InitializeComponent();
            _TestTypeID = id;
            lblIDValue.Text = id.ToString();
        }

        private bool CheckIfFilltext() 
        {
        
            if(string.IsNullOrWhiteSpace(txtTestTitle.Text))
            {

                MessageBox.Show("Please fill in the Test Title field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please fill in the Description field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!double.TryParse(txtFees.Text, out _))
            {
                MessageBox.Show("Please enter a valid number for the Fees field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(CheckIfFilltext())
            {

                if(clsTestType.UpdateTestType(_TestTypeID, txtTestTitle.Text, txtDescription.Text, double.Parse(txtFees.Text)))
                {
                    MessageBox.Show("Test type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update test type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void txtTestTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFees_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
