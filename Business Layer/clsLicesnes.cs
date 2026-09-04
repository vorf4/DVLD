using System;
using System.Data;
using System.Security.Cryptography;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsLicesnes
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

        private clsLicesnes(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate
            , DateTime ExpiryDate, string Note, double PaidFees, bool IsActive, enIssueReason IssueReason, int IssuedByUserID)
        { 
        
            _Mode= enMode.enUpdate;
            this._LicenseID = LicenseID;
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

        public clsLicesnes()
        {
            _Mode = enMode.enAddNew;
            _LicenseID = 0;
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
                            this._LicenseID = NewLicenseID;
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

    }
}
