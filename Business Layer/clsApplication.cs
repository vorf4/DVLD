using System;
using System.ComponentModel;
using System.Data;
using System.Dynamic;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsApplication
    {

        // constructor

        private clsApplication(enMode Mode, int ApplicationID, int PersonID, 
            DateTime ApplicationDate, int TypeID, enStatus Status,
            DateTime LastStatusDate, decimal PaidFees, int UserID) 
        {
        
            this._Mode = Mode;
            this._ApplicationID = ApplicationID;
            this._PersonID = PersonID;
            this.ApplicationDate = ApplicationDate;
            this.TypeID = TypeID;
            this._Status = Status;
            this._LastStatusDate = LastStatusDate;
            this._PaidFees = PaidFees;
            this._UserID = UserID;

        } // Update

        public clsApplication()
        {

            this._Mode = enMode.enAddNew;
            this._ApplicationID = 0;
            this._PersonID = 0;
            this.ApplicationDate = DateTime.Now;
            this.TypeID = 0;
            this._Status = enStatus.enNew;
            this._LastStatusDate = DateTime.Now;
            this._PaidFees = 0.0m;
            this._UserID = 0;
        } // AddNewUser

        //enums 

        private enum enMode 
        { 
        
            enAddNew=0,
            enUpdate=1

        };

        private enum enStatus
        { 
        
            enNew = 1,
            enCancelled=2,
            enCompleted = 3

        };

        public enum enSave
        {
        
            enAddScc = 0,
            enUpdateScc = 1,
            enLostScc = 2,

        };

        // private variables

        private enMode _Mode;
        private int _ApplicationID;
        private int _PersonID;
        private DateTime ApplicationDate;
        private int TypeID;
        private enStatus _Status;
        private DateTime _LastStatusDate;
        private decimal _PaidFees;
        private int _UserID;

        // private methods

        private int _AddNewApplication() 
        {
        
            return clsApplicationTB.InsertApplication(this._PersonID, this.ApplicationDate, this.TypeID,
                (byte)this._Status, this._LastStatusDate, this._PaidFees, this._UserID);

        }

        private static clsApplication findByID(int ApplicationID)
        {

            int PersonID = 0;
            DateTime ApplicationDate = DateTime.Now;
            int TypeID = 0;
            byte Status = 0;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0.0m;
            int UserID = 0;

            if (clsApplicationTB.GetApplicationByID(ApplicationID, ref PersonID, ref ApplicationDate, ref TypeID, ref Status, ref LastStatusDate, ref PaidFees, ref UserID))
            {

                return new clsApplication(enMode.enUpdate, ApplicationID, PersonID, ApplicationDate, TypeID, (enStatus)Status, LastStatusDate, PaidFees, UserID);

            }

            return null;

        }

        private static bool _CheckIfHasThisApplication(int PersonID, int TypeID)
        {

            return clsApplicationTB.CheckIfPersonHasThisApplicationType(PersonID, TypeID);
        }

        private static bool _UpdateApplicationStatus(int ApplicationID, enStatus newStatus)
        {
            return clsApplicationTB.UpdateApplicationStatus(ApplicationID, (byte)newStatus,DateTime.Now);
        }

        // public methods

        public static clsApplication Find(int ApplicationID)
        {
            return findByID(ApplicationID);
        }

        public enSave Save() 
        {

            switch (this._Mode)
            {

                case enMode.enAddNew:
                    {
                        this._ApplicationID = _AddNewApplication();
                        this._Mode = enMode.enUpdate;
                        return enSave.enAddScc;
                    }
                case enMode.enUpdate:
                    {
                        return enSave.enUpdateScc;
                    }
                default:
                    {
                        return enSave.enLostScc;
                    }

            }

        }

        public static bool CheckIfPersonHasThisApplicationType(int PersonID, int TypeID)
        {
            return _CheckIfHasThisApplication(PersonID, TypeID);
        }

        public void UpdateStatus(int newStatus)
        {
            this._Status = (enStatus)newStatus;
        }

        public static bool CancelledApplication(int ApplicationID)
        {
            return _UpdateApplicationStatus(ApplicationID, enStatus.enCancelled);
        }

        // get and set methods

        private enMode Mode { get => _Mode; set => _Mode = value; }
        public int ApplicationID { get => _ApplicationID; set => _ApplicationID = value; }
        public int PersonID { get => _PersonID; set => _PersonID = value; }
        public DateTime ApplicationDate1 { get => ApplicationDate; set => ApplicationDate = value; }
        public int TypeID1 { get => TypeID; set => TypeID = value; }
        private enStatus Status { get => _Status; set => _Status = value; }
        public DateTime LastStatusDate { get => _LastStatusDate; set => _LastStatusDate = value; }
        public decimal PaidFees { get => _PaidFees; set => _PaidFees = value; }
        public int UserID { get => _UserID; set => _UserID = value; }
    }
}
