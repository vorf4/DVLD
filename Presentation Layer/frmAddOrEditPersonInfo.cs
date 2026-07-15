using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class frmAddOrEditPersonInfo : Form
    {

        clsPerson person = new clsPerson();

        private bool _CheckFormIsCorrect() {
        
            bool isFilled = true;

           //check is fill first name

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                isFilled = false;
                epTxtFirstName.SetError(txtFirstName, "First Name is required.");
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                isFilled = false;
                epTxtLastName.SetError(txtLastName, "Last Name is required.");
            }
            if (string.IsNullOrEmpty(txtSecondName.Text))
            {
                isFilled = false;
                epTxtSecoundName.SetError(txtSecondName, "Second Name is required.");
            }

            if(string.IsNullOrEmpty(txtNationalNo.Text))
            {
                isFilled = false;
                epNationalNo.SetError(txtNationalNo, "National Number is required.");
            } 
            else if (clsPerson.IsNationalNoExists(txtNationalNo.Text))
            {
                isFilled = false;
                epNationalNo.SetError(txtNationalNo, "National Number already exists.");
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                isFilled = false;
                epPhone.SetError(txtPhone, "Phone Number is required.");
            }

            if(string.IsNullOrEmpty(txtAddress.Text))
            {
                isFilled = false;
                epAddress.SetError(txtAddress, "Address is required.");
            }

            if(!rbMale.Checked && !rbFemale.Checked)
            {
                isFilled = false;
                epRdButton.SetError(rbMale, "Gender is required.");
            }

            return isFilled;
        }

        private void _LoadPersonInfo() {


            person.FirstName = txtFirstName.Text;
            person.SecondName = txtSecondName.Text;
            person.ThirdName = txtThirdName.Text;
            person.LastName = txtLastName.Text;

            person.Email = txtEmail.Text;
            person.Phone = txtPhone.Text;
            person.Address = txtAddress.Text;
            person.NationalNo = txtNationalNo.Text;

            person.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
                person.Gender = clsPerson.enGenderType.Male;
            else
                person.Gender = clsPerson.enGenderType.Female;

            person.NationalityCountryID = clsPerson.GetCountryByName(cbCountry.SelectedItem.ToString());
            person.ImagePath = pbPersonImage.ImageLocation;

        }

        private void _LoadPersonInfoToForm()
        {
            if (person != null)
            {
                txtFirstName.Text = person.FirstName;
                txtSecondName.Text = person.SecondName;
                txtThirdName.Text = person.ThirdName;
                txtLastName.Text = person.LastName;
                txtEmail.Text = person.Email;
                txtPhone.Text = person.Phone;
                txtAddress.Text = person.Address;
                txtNationalNo.Text = person.NationalNo;
                dtpDateOfBirth.Value = person.DateOfBirth;
                if (person.Gender == clsPerson.enGenderType.Male)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;

                cbCountry.SelectedItem = clsPerson.GetCountryNameByID(person.NationalityCountryID);
                pbPersonImage.ImageLocation = person.ImagePath;
            }
        }

        public frmAddOrEditPersonInfo(string Title)
        {
            InitializeComponent();

            lblTitle.Text = Title;
            LoadCountries();
        }

        public frmAddOrEditPersonInfo(string Title, int PersonID)
        {
            InitializeComponent();

            lblTitle.Text = Title;
            LoadCountries();

            person =clsPerson.Find(PersonID);

            _LoadPersonInfoToForm();
            lblPersonID.Text = "Person ID: " + person.PersonID.ToString();
        }

        private void LoadCountries()
        {
            List<string> countries = new List<string>
            {
                "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda",
                "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas",
                "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize",
                "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil",
                "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia",
                "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China",
                "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus",
                "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic",
                "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia",
                "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia",
                "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea",
                "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India",
                "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan",
                "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South",
                "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho",
                "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar",
                "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands",
                "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco",
                "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia",
                "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger",
                "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau",
                "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines",
                "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis",
                "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino",
                "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles",
                "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia",
                "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname",
                "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand",
                "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey",
                "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates",
                "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu",
                "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe"
            };

            countries.Sort();

            cbCountry.DataSource = countries;
            cbCountry.DropDownStyle = ComboBoxStyle.DropDownList;

            int selectedIndex = cbCountry.Items.IndexOf("Jordan");
            if (selectedIndex >= 0)
                cbCountry.SelectedIndex = selectedIndex;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_CheckFormIsCorrect())
            {

                _LoadPersonInfo();

                clsPerson.enSave result = person.Save();

                switch (result)
                {
                    case clsPerson.enSave.enAddNew:
                        MessageBox.Show("Person info saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case clsPerson.enSave.enFaild:
                        MessageBox.Show("Failed to save person info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case clsPerson.enSave.enUpdated:
                        MessageBox.Show("Person info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }

                lblPersonID.Text = "Person ID: " + person.PersonID.ToString();
                lblTitle.Text = "Update Person Info";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAddOrEditPersonInfo_Load(object sender, EventArgs e)
        {
            txtPhone.KeyPress += (s, ev) =>
            {
                // Allow only digits and control characters (like backspace)
                if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar))
                {
                    ev.Handled = true; // Ignore the input
                }
            };

            txtEmail.KeyPress += (s, ev) => {
                // Allow only valid email characters
                if (!char.IsControl(ev.KeyChar) && !char.IsLetterOrDigit(ev.KeyChar) && ev.KeyChar != '@' && ev.KeyChar != '.' && ev.KeyChar != '-' && ev.KeyChar != '_')
                {
                    ev.Handled = true; // Ignore the input
                }
            };

        }
    }
}
