using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsAppointment
    {

        // enumns

        private enum enMode 
        {
        
            enAddNew=1,
            enEditNew=2,
            enFailed=3

        }

        public enum enSave 
        {

            enAddScc=1,
            enEditScc=2,
            enFailedScc=3

        }

        // conestracter 

        private clsAppointment(int AppointmentID, int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, double PaidFees, int UserID, bool IsLocked, int RetakeTestAppointmentID)
        {
            this.Mode = enMode.enEditNew;
            this.AppointmentID1 = AppointmentID;
            this.TestTypeID1 = TestTypeID;
            this.LocalDrivingLicenseApplicationID1 = LocalDrivingLicenseApplicationID;
            this.AppointmentDate1 = AppointmentDate;
            this.PaidFees1 = PaidFees;
            this.UserID1 = UserID;
            this.IsLocked1 = IsLocked;
            this.RetakeTestAppointmentID1 = RetakeTestAppointmentID;
        }

        public clsAppointment()
        { 
        
            this.Mode = enMode.enAddNew;
            this.LocalDrivingLicenseApplicationID1= -1;
            this.RetakeTestAppointmentID1= -1;
            this.PaidFees1= 0;
            this.IsLocked1= false;
            this.AppointmentDate1 = DateTime.Now;
            this.AppointmentID1 = -1;
            this.UserID1= -1;

        }

        // priavte variables

        private enMode _Mode;
        private int AppointmentID;
        private int TestTypeID;
        private int LocalDrivingLicenseApplicationID;
        private DateTime AppointmentDate;
        private double PaidFees;
        private int UserID;
        private bool IsLocked;
        private int RetakeTestAppointmentID;

        // set and get methods
        private enMode Mode { get => _Mode; set => _Mode = value; }
        public int AppointmentID1 { get => AppointmentID; set => AppointmentID = value; }
        public int TestTypeID1 { get => TestTypeID; set => TestTypeID = value; }
        public int LocalDrivingLicenseApplicationID1 { get => LocalDrivingLicenseApplicationID; set => LocalDrivingLicenseApplicationID = value; }
        public DateTime AppointmentDate1 { get => AppointmentDate; set => AppointmentDate = value; }
        public double PaidFees1 { get => PaidFees; set => PaidFees = value; }
        public int UserID1 { get => UserID; set => UserID = value; }
        public bool IsLocked1 { get => IsLocked; set => IsLocked = value; }
        public int RetakeTestAppointmentID1 { get => RetakeTestAppointmentID; set => RetakeTestAppointmentID = value; }

        //private methods

        private static DataTable GetAllAppointmentsByLocalID(int LocalID,int TestTypeID)
        {
            return clsAppointmentTB.GetAllAppointmentsByLocalID(LocalID, TestTypeID);
        }

        private bool InsertAppointment()
        {
            return clsAppointmentTB.InsertAppointment(this.TestTypeID1, this.LocalDrivingLicenseApplicationID1,
                this.AppointmentDate1, this.PaidFees1, this.UserID1, this.IsLocked1, this.RetakeTestAppointmentID1);
        }

        private static bool IsAppointmentLocked(int AppointmentID)
        {
            return clsAppointmentTB.IsAppointmentLocked(AppointmentID);
        }

       private static bool UpdateAppointment(int AppointmentID, DateTime AppointmentDate,  bool IsLocked)
        {
            return clsAppointmentTB.UpdateAppointment(AppointmentID, AppointmentDate, IsLocked);
        }

        //public methods

        public static DataTable GetAppointmentsByLocalID(int LocalID, int TestTypeID)
        {
            return clsAppointment.GetAllAppointmentsByLocalID(LocalID, TestTypeID);
        }
        public enSave save() 
        {

            switch (this.Mode) 
            {
            
                case enMode.enAddNew:
                    if (this.InsertAppointment())
                    {
                        this.Mode = enMode.enEditNew;
                        return enSave.enAddScc;
                    }
                    else
                    {
                        return enSave.enFailedScc;
                    }
                    break;
                default:
                    return enSave.enFailedScc;
                    break;

            }

        }

        public static bool IsAppointmentLockedPublic(int AppointmentID)
        {
            return IsAppointmentLocked(AppointmentID);
        }

        public static bool UpdateDataOfIsLocked(int AppointmentID,  bool IsLocked)
        {
            return UpdateAppointment(AppointmentID, DateTime.Now, IsLocked);
        }

        public static bool UpdateDataOfAppointmentDate(int AppointmentID, DateTime AppointmentDate)
        {
            return UpdateAppointment(AppointmentID, AppointmentDate, false);
        }

    }
}
