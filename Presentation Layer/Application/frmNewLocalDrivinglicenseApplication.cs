using System;
using System.Drawing;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer;

namespace PresentationLayer
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {

        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _User = new clsUser();

            cbFilterBy.SelectedIndex = 0; // Default to "National No."
            _LoadValidText();

        }
        public frmNewLocalDrivingLicenseApplication(clsUser User)
        {
            InitializeComponent();
            _User = User;

            cbFilterBy.SelectedIndex = 0; // Default to "National No."
            _LoadValidText();

        }
 
        private clsPerson _Person;

        private clsUser _User;

        private void _LoadValidText() 
        {

            if (cbFilterBy.SelectedItem.ToString() == "Person ID")
            {

                txtFilterValue.KeyPress += (s, e) =>
                {
                    // Allow only digits and control characters (like backspace)
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true; // Ignore the input
                    }
                }; 

            }
            else
            {

                txtFilterValue.KeyPress += (s, e) =>
                {
                    // Allow only digits and control characters (like backspace)
                   e.Handled = false; // Allow all input for National No.
                };

            }

        }

        private void LoadDataOfPerson() 
        {

            if (cbFilterBy.SelectedItem.ToString() == "National No.")
            {
                if (!string.IsNullOrEmpty(txtFilterValue.Text))
                {
                    _Person = clsPerson.Find(txtFilterValue.Text);
                }
                else
                {
                    _Person = new clsPerson(); // Reset to a new person if the text is empty
                }   
            }
            else if (cbFilterBy.SelectedItem.ToString() == "Person ID")
            {
                if (int.TryParse(txtFilterValue.Text, out int personID))
                {
                    _Person = clsPerson.Find(personID);
                }
                else
                {
                    _Person = new clsPerson(); // Reset to a new person if parsing fails
                }
            }
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {

            ctrlShowDetails.Controls.Clear();
            LoadDataOfPerson();

            if (_Person.PersonID != -1)
            {
                ctrlShowDetails personDetailsControl = new PresentationLayer.ctrlShowDetails(_Person);
                ctrlShowDetails.Controls.Add(personDetailsControl);
            }
            else { MessageBox.Show("Person not found."); }

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

        private bool _IfChoosePerson()
        {
            if (_Person == null || _Person.PersonID == -1)
            {
                MessageBox.Show("Please select a person before proceeding.");
                return false;
            }
            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_IfChoosePerson())
            {
                tcApplicationInfo.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            _LoadValidText();

        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
