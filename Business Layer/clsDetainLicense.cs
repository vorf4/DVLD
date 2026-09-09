using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsDetainLicense
    {

        // member variables

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



        //public methods

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
