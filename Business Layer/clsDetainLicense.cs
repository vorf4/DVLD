using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsDetainLicense
    {

        public clsDetainLicense()
        {
            _Mode = enMode.enAdd;
            _DetainID = -1;
            _LicenseID = -1;
            _DetainDate = DateTime.Now;
            _FineFees = 0.00M;
            _CreatedByUserID = -1;
            _IsReleased = false;
            _ReleaseDate = DateTime.MinValue;
            _ReleasedByUserID = -1;
            _ReleaseApplicationID = -1;
        }

        private clsDetainLicense(int DetainID, int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)

        {
            _Mode = enMode.enEdit;
            _DetainID = DetainID;
            _LicenseID = LicenseID;
            _DetainDate = DetainDate;
            _FineFees = FineFees;
            _CreatedByUserID = CreatedByUserID;
            _IsReleased = IsReleased;
            _ReleaseDate = ReleaseDate;
            _ReleasedByUserID = ReleasedByUserID;
            _ReleaseApplicationID = ReleaseApplicationID;
        }

        private enum enMode
        { 
        
            enAdd = 1,
            enEdit = 2,

        }

        public enum enSave 
        {
        
            enDetained = 1,
            enReleased = 2,
            enFailed = 3

        }

        // member variables

        private enMode _Mode;
        private int _DetainID;
        private int _LicenseID;
        private DateTime _DetainDate;
        private decimal _FineFees;
        private int _CreatedByUserID;
        private bool _IsReleased;
        private DateTime _ReleaseDate;
        private int _ReleasedByUserID;
        private int _ReleaseApplicationID;

        // private methods

        private static bool IsDetainedLicense(int LicenseID)
        {
            return clsDetainLicenseTB.IsDetainedLicense(LicenseID);
        }

        private int InsertDetainLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased)
        {
            return clsDetainLicenseTB.InsertDetainLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased);
        }

        private bool ReleaseDetainedLicense(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            return clsDetainLicenseTB.ReleaseDetainedLicense(DetainID, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }

        private static int GetDetainIDByLicenseID(int LicenseID)
        {
            return clsDetainLicenseTB.GetDetainIDByLicenseID(LicenseID);
        }

        private static clsDetainLicense GetDetainLicenseByDetainID(int DetainID)
        {
       
            int LiceseID = 0;
            DateTime dateTime = DateTime.MinValue;
            decimal fineFees = 0.00M;
            int CreatedByUserID = 0;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainLicenseTB.GetDetainedLicenseInfoByDetainID(DetainID, ref LiceseID, ref dateTime, ref fineFees, ref CreatedByUserID,
                ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {

                return new clsDetainLicense(DetainID, LiceseID, dateTime, fineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            }
            else 
            {
            return null;
            }

        }

        private static DataTable GetAllDetainedLicenses()
        {
            return clsDetainLicenseTB.GetAllDetainedLicenses();
        }

        //public methods

        public static clsDetainLicense FindDetainLicenseByDetainID(int DetainID)
        {
            return GetDetainLicenseByDetainID(DetainID);
        }

        public static bool CheckIfLicenseIsDetained(int LicenseID)
        {
            return IsDetainedLicense(LicenseID);
        }

        public static int GetDetainID(int LicenseID)
        {
            return GetDetainIDByLicenseID(LicenseID);
        }

        public static DataTable GetAllDetainedLicensesList()
        {
            return GetAllDetainedLicenses();
        }

        public enSave Save()
        {
            
        switch (_Mode)
            {
                case enMode.enAdd:
                    this._DetainID = InsertDetainLicense(this._LicenseID, this._DetainDate, this._FineFees, this._CreatedByUserID, this._IsReleased);
                    if (_DetainID > 0)
                    {
                        return enSave.enDetained;
                    }
                    else
                    {
                        return enSave.enFailed;
                    }
                case enMode.enEdit:

                    if (ReleaseDetainedLicense(this._DetainID, this._ReleaseDate, this._ReleasedByUserID, this._ReleaseApplicationID))
                    {
                        return enSave.enReleased;
                    }
                    else
                    {
                        return enSave.enFailed;
                    }
                default:
                    return enSave.enFailed;
            }

        }

        // set and get methods
        public int DetainID { get => _DetainID; set => _DetainID = value; }
        public int LicenseID { get => _LicenseID; set => _LicenseID = value; }
        public DateTime DetainDate { get => _DetainDate; set => _DetainDate = value; }
        public decimal FineFees { get => _FineFees; set => _FineFees = value; }
        public int CreatedByUserID { get => _CreatedByUserID; set => _CreatedByUserID = value; }
        public bool IsReleased { get => _IsReleased; set => _IsReleased = value; }
        public DateTime ReleaseDate { get => _ReleaseDate; set => _ReleaseDate = value; }
        public int ReleasedByUserID { get => _ReleasedByUserID; set => _ReleasedByUserID = value; }
        public int ReleaseApplicationID { get => _ReleaseApplicationID; set => _ReleaseApplicationID = value; }

    }
}
