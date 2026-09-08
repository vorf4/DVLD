using System;
using System.Data;
using System.Security.Cryptography;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsLicense
    {
        // enumns

        public enum enIssueReason
        {
            NewLicense = 1,
            Renewal = 2,
            ReplacementForDamage = 3,
            ReplacementForLost   = 4

        }

        private enum enMode 
        {

            enAddNew = 1,
            enUpdate=2,
            enFaild=3,
        }

        public enum enSave 
        {
        
            enAddScc = 1,
            enUpdatedScc = 2,
            enFailed=3

        }

        // constracter 

        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate
            , DateTime ExpiryDate, string Note, double PaidFees, bool IsActive, enIssueReason IssueReason, int IssuedByUserID)
        { 
        
            _Mode= enMode.enUpdate;
            this.LicenseID = LicenseID;
            this._ApplicationID = ApplicationID;
            this.IssueDate = IssueDate;
            this.Note = Note;
            this._PaidFees = PaidFees;
            this._isActive = IsActive;
            this._LicenseClassID = LicenseClassID;
            this.DriverID = DriverID;
            this._ExpiryDate = ExpiryDate;
            this.IssueReason = IssueReason;
            this.IssuedByUserID = IssuedByUserID;

        }

        public clsLicense()
        {
            _Mode = enMode.enAddNew;
            LicenseID = 0;
            _ApplicationID = 0;
            _DriverID = 0;
            _LicenseClassID = 0;
            _IssueDate = DateTime.Now;
            _ExpiryDate = DateTime.Now;
            _Note = string.Empty;
            _PaidFees = 0.0;
            _isActive = true;
            _IssueReason = enIssueReason.NewLicense;
            _IssuedByUserID = 0;
        }

        // data members

        private enMode _Mode;
        private int _LicenseID;
        private int _ApplicationID;
        private int _DriverID;
        private int _LicenseClassID;
        private DateTime _IssueDate;
        private DateTime _ExpiryDate;
        private string _Note;
        private double _PaidFees;
        private bool _isActive;
        private enIssueReason _IssueReason;
        private int _IssuedByUserID;



        // private Methods

        private int _InsertNewLicense()
        {
            return clsLicensesTB.InsertNewLicesne(_ApplicationID, _DriverID, _LicenseClassID, _IssueDate, _ExpiryDate, _Note, _PaidFees, _isActive, (int)_IssueReason, _IssuedByUserID);
        }

        private static clsLicense _LoadLicenseInfo(int LicenseID)
        {
            int ApplicationID = 0;
            int DriverID = 0;
            int LicenseClassID = 0;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpiryDate = DateTime.Now;
            string Note = string.Empty;
            double PaidFees = 0.0;
            bool IsActive = true;
            int IssueReason = 0;
            int IssuedByUserID = 0;

            bool isfound = clsLicensesTB.GetLicenseByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpiryDate, ref Note, ref PaidFees, ref IsActive, ref IssueReason, ref IssuedByUserID);

            if (!isfound)
                return null;

            return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpiryDate, Note, PaidFees, IsActive, (enIssueReason)IssueReason, IssuedByUserID);
        }

        private static bool IfHaveinternationalLicense(int LicenseID) 
        {
            return clsLicensesTB.IfhaveInternationalLicense(LicenseID);
        }

        private static bool isActive(int LicenseID)
        {
            return clsLicensesTB.IsLicenseActive(LicenseID);
        }

        private static bool IsLicense3(int licenseID) 
        {
        
            bool isLicense3 = false;

            int LicenseClassID = clsLicensesTB.GetTypeLicense(licenseID);

            if (LicenseClassID == 3)
            {
                isLicense3 = true;
            }

            return isLicense3;

        } 

        private static DataTable GetAllInfoOfDvginternationalLicenseApplications()
        {
            return clsLicensesTB.GetAllInternationalLicensesInfo();
        }

        private static bool PutLicenseNotActive(int LicenseID)
        {
            return clsLicensesTB.PutLicenseNotActiveByID(LicenseID);
        }

        //public Methods

        public enSave Save() 
        {

            switch (this._Mode)
            {

                case enMode.enAddNew:
                    {
                        int NewLicenseID = _InsertNewLicense();
                        if (NewLicenseID > 0)
                        {
                            this.LicenseID = NewLicenseID;
                            this._Mode = enMode.enUpdate;
                            return enSave.enAddScc;
                        }
                        else
                        {
                            return enSave.enFailed;
                        }
                    }
                default:
                    {
                        return enSave.enFailed;

                    }
            }
        }

        public static clsLicense Find(int LicenseID)
        {

            return _LoadLicenseInfo(LicenseID);
        }

        public static bool HaveInternationalLicense(int LicenseID)
        {
            return IfHaveinternationalLicense(LicenseID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return isActive(LicenseID);
        }

        public static bool IsLicenseClass3(int LicenseID)
        {
            return IsLicense3(LicenseID);
        }

        public static DataTable GetAllInternationalLicensesInfo()
        {
            return GetAllInfoOfDvginternationalLicenseApplications();
        }

        public static bool PutLicenseNotActiveByID(int LicenseID)
        {
            return PutLicenseNotActive(LicenseID);
        }


        // set and get methods
        public int ApplicationID { get => _ApplicationID; set => _ApplicationID = value; }
        public int DriverID { get => _DriverID; set => _DriverID = value; }
        public int LicenseClassID { get => _LicenseClassID; set => _LicenseClassID = value; }
        public DateTime IssueDate { get => _IssueDate; set => _IssueDate = value; }
        public DateTime ExpiryDate { get => _ExpiryDate; set => _ExpiryDate = value; }
        public string Note { get => _Note; set => _Note = value; }
        public double PaidFees { get => _PaidFees; set => _PaidFees = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
        public enIssueReason IssueReason { get => _IssueReason; set => _IssueReason = value; }
        public int IssuedByUserID { get => _IssuedByUserID; set => _IssuedByUserID = value; }
        public int LicenseID { get => _LicenseID; set => _LicenseID = value; }
    }
}
