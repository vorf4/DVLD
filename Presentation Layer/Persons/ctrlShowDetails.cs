using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Business_Layer;
using Presentation_Layer;
using System.IO;

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

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                pbPersonImage.Image = Image.FromFile(_Person.ImagePath);

        }

        private void gbPersonInformation_Enter(object sender, EventArgs e)
        {

            

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            
            
        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

           frmAddOrEditPersonInfo personInfoForm = new frmAddOrEditPersonInfo("Update Person", _Person.PersonID);
            personInfoForm.DataSentPersonInfo += ctrlShowDetails_Load;
            personInfoForm.ShowDialog();

            LoadPersonInfo();

        }

        private void ctrlShowDetails_Load(clsPerson Person)
        {
            _Person = Person;
            
        }
    }
}
