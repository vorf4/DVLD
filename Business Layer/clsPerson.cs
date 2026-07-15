using System;
using System.Data;
using Data_Access_Layer;


namespace Business_Layer
{
    public class clsPerson
    {

        public enum enGenderType
        {
            Male = 0,
            Female = 1
        }

        private enum enMode
        { 
            enAddNew=0,
            enUpdate=1 
        }

        private enMode _Mode;
        private int _PersonID;
        private string _NationalNo;
        private string _FirstName;
        private string _secondName;
        private string _ThirdName;
        private string _LastName;
        private DateTime _DateOfBirth;
        private enGenderType _Gender;
        private string _Address;
        private string _Phone;
        private string _Email;
        private int _NationalityCountryID;
        private string _ImagePath;

        private DataTable _GetAllPersons()
        {
            return clsPersonsTB.GetAllPersons();
        }

        private static int _GetCountryByName(string Name)
        {
            return clsPersonsTB.GetCountryByName(Name);
        }

        private int _AddNewPerson()
        {

            return clsPersonsTB.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth,
                (int)this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        private void _UpdatePerson()
        {
            clsPersonsTB.UpdatePersonInfo(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth,
            (int)this.Gender, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        private static clsPerson _FindPersonByID(int PersonID)
        {
            bool found ;

            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = 0;
            int NationalityCountryID = -1;

          found= clsPersonsTB.GetPersonByID(PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref NationalNo, ref DateOfBirth,
                ref Gender, ref Address, ref Phone, ref Email,
                ref NationalityCountryID, ref ImagePath);

            if (found)
            {

                return new clsPerson(enMode.enUpdate, PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    DateOfBirth, (enGenderType)Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else { 
            return null;
            }
           
        }

        private static string _GetCountryNameByID(int CountryID)
        { 
        return clsPersonsTB.GetCountryNameByID(CountryID);
        }

        private static bool _IsNationalNoExists(string NationalNo)
        {
            return clsPersonsTB.IsNationalNoExists(NationalNo);
        }

        private static bool _DeletePerson(int PersonID)
        {
            return clsPersonsTB.DeletePerson(PersonID);
        }

        //public methods to get and set the properties of the class

        public clsPerson()
        {
            _Mode = enMode.enAddNew;
            _PersonID = -1;
            _NationalNo = "";
            _FirstName = "";
            _secondName = "";
            _ThirdName = "";
            _LastName = "";
            _DateOfBirth = DateTime.Now;
            _Gender = enGenderType.Male;
            _Address = "";
            _Phone = "";
            _Email = "";
            _NationalityCountryID = -1;
            _ImagePath = "";
        }

        private clsPerson(enMode mode, int personID, string nationalNo, string firstName, string secondName, string thirdName, 
            string lastName, DateTime dateOfBirth, enGenderType gender, string address, string phone, string email, int nationalityCountryID, 
            string imagePath)
        {
            _Mode = mode;
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
        }

        public int PersonID { get => _PersonID; set => _PersonID = value; }
        public string NationalNo { get => _NationalNo; set => _NationalNo = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public string ThirdName { get => _ThirdName; set => _ThirdName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public DateTime DateOfBirth { get => _DateOfBirth; set => _DateOfBirth = value; }
        public enGenderType Gender { get => _Gender; set => _Gender = value; }
        public string Address { get => _Address; set => _Address = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int NationalityCountryID { get => _NationalityCountryID; set => _NationalityCountryID = value; }
        public string ImagePath { get => _ImagePath; set => _ImagePath = value; }

        //public method to get all persons from the database
        public DataTable GetAllPersons()
        {
            return _GetAllPersons();
        }

        public static int GetCountryByName(string Name)
        {
            return _GetCountryByName(Name);
        }

        public static string GetCountryNameByID(int CountryID)
        {
            return _GetCountryNameByID(CountryID);
        }

        public enum enSave {

            enAddNew = 0,
            enUpdated=1,
            enFaild=2

        }

        public enSave Save()
        {
         
            switch(_Mode)
            {
                case enMode.enAddNew:
                    int newPersonID = _AddNewPerson();
                    if (newPersonID > 0)
                    {
                        _PersonID = newPersonID;
                        _Mode = enMode.enUpdate;
                        return enSave.enAddNew;
                    }
                    else
                    {
                        return enSave.enFaild;
                    }
                case enMode.enUpdate:
                    _UpdatePerson();
                    return enSave.enUpdated;
                default:
                    return enSave.enFaild;
            }

        }

        public static clsPerson Find(int PersonID)
        {
            return _FindPersonByID(PersonID);
        }

        public static bool IsNationalNoExists(string NationalNo)
        {
            return _IsNationalNoExists(NationalNo);
        }

        public static bool DeletePerson(int PersonID)
        {
            return _DeletePerson(PersonID);
        }

    }
}
