using System;
using System.Data;
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
                lblApplicationDateValue.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblCreatedByValue.Text = _User.UserName;
                
                cbLicenseClass.DataSource = clsLicenseClass.GetClassName();
                cbLicenseClass.DisplayMember = "ClassName";
                cbLicenseClass.ValueMember = "ClassName";
                lblApplicationFeesValue.Text = clsApplicationType.GetApplicationFees("New Local Driving License Service").ToString("C");
            }
        }

        private bool CheckIfComboBoxRight() 
        { 
        
            if (cbLicenseClass.SelectedItem == null)
            {
                MessageBox.Show("Please select a license class.");
                return false;
            }else if (clsLocalDrivingLicenseApplication.CheckIfPersonHasThisLicense(_Person.PersonID, clsLicenseClass.GetClassID(cbLicenseClass.SelectedItem.ToString())))
            {
                MessageBox.Show("This person already has this license class.");
                return false;
            }

            return true;

        }

        private int AddNewApplication() 
        {
            int applicationID = -1;

            clsApplication newApplication = new clsApplication();
            newApplication.PersonID = _Person.PersonID;
            newApplication.ApplicationDate1 = DateTime.Now;
            newApplication.TypeID1 = clsApplicationType.GetApplicationTypeID("New Local Driving License Service");
            newApplication.UpdateStatus(1);
            newApplication.PaidFees = 0;
            newApplication.LastStatusDate = DateTime.Now;
            newApplication.UserID = _User.UserId;

            newApplication.Save();

            applicationID = newApplication.ApplicationID;

            return applicationID;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           if(CheckIfComboBoxRight())
           {

                int applicationID = AddNewApplication();

                if (applicationID != -1) 
                {

                    clsLocalDrivingLicenseApplication newLocalLicenseApplication = new clsLocalDrivingLicenseApplication();

                    newLocalLicenseApplication.ApplicationID = applicationID;
                    newLocalLicenseApplication.LicenseClassID1 = clsLicenseClass.GetClassID(cbLicenseClass.SelectedItem.ToString());
                    clsLocalDrivingLicenseApplication.enSave saveResult = newLocalLicenseApplication.Save();

                    if (saveResult == clsLocalDrivingLicenseApplication.enSave.enAddScc)
                    {
                        MessageBox.Show("New local driving license application added successfully.");
                        lblTitle.Text ="Update Local Driving License Application";
                        lblApplicationIDValue.Text = newLocalLicenseApplication.ApplicationID.ToString();
                    }
                    else if (saveResult == clsLocalDrivingLicenseApplication.enSave.enAddFail)
                    {
                        MessageBox.Show("Failed to add new local driving license application.");
                    }

                }

            }

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
