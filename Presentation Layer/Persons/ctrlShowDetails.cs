using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Business_Layer;

namespace PresentationLayer
{
    public partial class ctrlShowDetails : UserControl
    {

        clsPerson _Person= null;
     
        public ctrlShowDetails( int PersonID)
        {
            InitializeComponent();

        
            _Person = clsPerson.Find(PersonID);
            LoadPersonInfo();
        }

        public ctrlShowDetails(clsPerson Person)
        {
            InitializeComponent();


            _Person = Person;
            LoadPersonInfo();
        }

        public void LoadPersonInfo()
        {
         
            lblPersonIDValue.Text = _Person.PersonID.ToString();
            lblFullNameValue.Text = _Person.FirstName + " " + _Person.LastName;
            lblNationalNoValue.Text = _Person.NationalNo;
            lblGenderValue.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmailValue.Text = _Person.Email;
            lblAddressValue.Text = _Person.Address;
            lblDateOfBirthValue.Text = _Person.DateOfBirth.ToShortDateString();
            lblPhoneValue.Text = _Person.Phone;
            lblCountryValue.Text = clsPerson.GetCountryNameByID(_Person.NationalityCountryID);

            if (_Person.ImagePath != "")
            {
                pbPersonImage.Load(_Person.ImagePath);
            }

        }

        private void gbPersonInformation_Enter(object sender, EventArgs e)
        {

            

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            
            
        }
    }
}
