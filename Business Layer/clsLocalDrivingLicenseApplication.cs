using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsLocalDrivingLicenseApplication
    {

        //constants

        public clsLocalDrivingLicenseApplication()
        {

            this._Mode = enMode.enAddNew;
            this._LocalDrivingLicenseApplicationID = 0;
            this._ApplicationID = 0;
            this.LicenseClassID = 0;

        }

        private clsLocalDrivingLicenseApplication(enMode Mode, int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {

            this._Mode = Mode;
            this._LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this._ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }

        //enums 

        private enum enMode
        {

            enAddNew = 0,
            enUpdate = 1

        }

        public enum enSave
        {

            enAddScc = 0,
            enUpdateScc = 1,
            enAddFail = 2,

        }

        //private variables

        private enMode _Mode;
        private int _LocalDrivingLicenseApplicationID;
        private int _ApplicationID;
        private int LicenseClassID;

        // get and set methods
        public int LocalDrivingLicenseApplicationID { get => _LocalDrivingLicenseApplicationID; set => _LocalDrivingLicenseApplicationID = value; }
        public int ApplicationID { get => _ApplicationID; set => _ApplicationID = value; }
        public int LicenseClassID1 { get => LicenseClassID; set => LicenseClassID = value; }

        //private methods

        private int AddNewLocalLicense()
        {

            return clsLocalDrivingLicenseApplicationTB.AddNewLocalLicense(this._ApplicationID, this.LicenseClassID);

        }

        private static bool IsPersonIDHaveThisLicense(int personID, int LicenseClassID)
        {
            return clsLocalDrivingLicenseApplicationTB.IsPersonIDHaveThisLicense(personID, LicenseClassID);
        }

        private  static DataTable GetLocalLicenseByPersonID()
        {
            return clsLocalDrivingLicenseApplicationTB.GetAllInfoOfLocalLicenseApplication();
        }

        private static int GetApplicationIDByLocalDrivingLicenseApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationTB.GetApplicationIDByLocalID(LocalDrivingLicenseApplicationID);
        }

        //public methods

        public enSave Save()
        {

            switch (this._Mode)
            {

                case enMode.enAddNew:
                    this.LocalDrivingLicenseApplicationID=AddNewLocalLicense();
                    this._Mode = enMode.enUpdate;
                    return enSave.enAddScc;
                case enMode.enUpdate:
                    return enSave.enUpdateScc;
                default:
                    return enSave.enAddFail;

            }

        }

        public static bool CheckIfPersonHasThisLicense(int personID, int LicenseClassID)
        {
            return IsPersonIDHaveThisLicense(personID, LicenseClassID);

        }

        public static DataTable GetAllInfoOfLocalLicenseApplication()
        {
            return GetLocalLicenseByPersonID();
        }

        public static int GetApplicationID(int LocalDrivingLicenseApplicationID)
        {
            return GetApplicationIDByLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
        }
    }
}
