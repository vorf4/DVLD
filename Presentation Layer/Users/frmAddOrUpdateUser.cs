using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using Business_Layer;
using PresentationLayer;

namespace Presentation_Layer
{
    public partial class frmAddOrUpdateUser : Form
    {

        private clsPerson _Person;

        private clsUser _User;

        private void _LoadUserDetails()
        {
            if (_User != null)
            {
                lblUserIDValue.Text ="[" + _User.UserID.ToString()+"]";
                txtUserName.Text = _User.UserName;
                txtPassword.Text = _User.Password;
                txtConfirmPassword.Text = _User.Password;
                chkIsActive.Checked = _User.IsActive;
                ctrlShowDetails.Controls.Clear();
                ctrlShowDetails personDetailsControl = new PresentationLayer.ctrlShowDetails(_Person);
                ctrlShowDetails.Controls.Add(personDetailsControl);
            }
        }

        public frmAddOrUpdateUser()
        {
            InitializeComponent();
            this.AutoScroll = true;
            _User = new clsUser();
            _Person = new clsPerson();
            lblTitle.Text = "Add New User";
            cbFilterBy.SelectedIndex = 0; // Default to "National No."

        }

        public frmAddOrUpdateUser(int UserID)
        {
            InitializeComponent();
            this.AutoScroll = true;
            _User = clsUser.Find(UserID);
            _Person = clsPerson.Find(_User.PersonId);
            lblTitle.Text = "Update User";
            gbFilter.Enabled = false; // Disable filter controls when updating
            _LoadUserDetails();
        }

        private bool _GetPersonDetails()
        {

            if (cbFilterBy.SelectedItem.ToString() == "National No.")
            {
                if(clsUser.IsNationalNumberExists(txtFilterValue.Text))
                {
                    MessageBox.Show("A user with this national number already exists. Please select a different national number.");
                    return false;
                }
                _Person = clsPerson.Find(txtFilterValue.Text);
                return true;
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Person ID")
            {
                if(clsUser.IsPersonExists(int.Parse(txtFilterValue.Text.ToString())))
                {
                    MessageBox.Show("A user with this person ID already exists. Please select a different person ID.");
                    return false;
                }
                _Person = clsPerson.Find(Convert.ToInt32(txtFilterValue.Text));
                return true;
            }
            else {
                MessageBox.Show("Please select a valid filter option.");
                return false;
            }

        }

        private void _LoadPersonDetailsIntoControl(int PersonID)
        {
            if (PersonID != -1)
            {
                _Person = clsPerson.Find(PersonID);
                ctrlShowDetails personDetailsControl = new PresentationLayer.ctrlShowDetails(_Person);
                ctrlShowDetails.Controls.Clear();
                ctrlShowDetails.Controls.Add(personDetailsControl);
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            ctrlShowDetails.Controls.Clear();
            bool personFound = _GetPersonDetails();

            if (!personFound)
                return;

            if (_Person.PersonID != -1)
            {
                ctrlShowDetails personDetailsControl = new PresentationLayer.ctrlShowDetails(_Person);
                ctrlShowDetails.Controls.Add(personDetailsControl);
            }
            else { MessageBox.Show("Person not found."); }


        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {

            frmAddOrEditPersonInfo FormAdd = new frmAddOrEditPersonInfo("Add New Person");
          
            FormAdd.DataSentPersonID += FormAdd_DataSent;
            
            FormAdd.ShowDialog();

           
        }

        private void FormAdd_DataSent(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            _LoadPersonDetailsIntoControl(_Person.PersonID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Person.PersonID != -1)
            {   
                tcUserInfo.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Please select a valid person before proceeding.");
            }

        }

        private bool _ValidateUserInput()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter a username.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.");
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            if(_Person.PersonID == -1)
            {
                MessageBox.Show("Please select a valid person.");
                return false;
            }
            if (clsUser.IsExists(txtUserName.Text))
            {
                MessageBox.Show("A user with this username already exists.");
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_ValidateUserInput())
            {

                _User.UserName = txtUserName.Text;
                _User.Password = txtPassword.Text;
                _User.IsActive = chkIsActive.Checked;
                _User.PersonId = _Person.PersonID;
                clsUser.enSave result=_User.Save();

                switch (result) {
                
                    case clsUser.enSave.enAddScc:
                        MessageBox.Show("User added successfully.");
                        lblTitle.Text = "Update User";
                        _LoadUserDetails();
                        break;
                    case clsUser.enSave.enUpdateScc:
                        MessageBox.Show("User updated successfully.");
                        break;
                    case clsUser.enSave.enfailed:
                        MessageBox.Show("Failed to save user.");
                        break;

                }

            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

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

        private void ctrlShowDetails_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
