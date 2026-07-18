using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class frmAddOrUpdateUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;

        public frmAddOrUpdateUser(enMode Mode = enMode.AddNew)
        {
            InitializeComponent();
            _Mode = Mode;

            if (_Mode == enMode.Update)
            {
                lblTitle.Text = "Update User";
            }
            else
            {
                lblTitle.Text = "Add New User";
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {

            clsPerson Person=clsPerson.Find(cbFilterBy.SelectedItem.ToString());
            


            }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
