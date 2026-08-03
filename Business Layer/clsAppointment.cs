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
            this._Mode = enMode.enEditNew;
            this.AppointmentID = AppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.UserID = UserID;
            this.IsLocked = IsLocked;
            this.RetakeTestAppointmentID = RetakeTestAppointmentID;
        }

        public clsAppointment()
        { 
        
            this._Mode = enMode.enAddNew;
            this.LocalDrivingLicenseApplicationID= -1;
            this.RetakeTestAppointmentID= -1;
            this.PaidFees= 0;
            this.IsLocked= false;
            this.AppointmentDate = DateTime.Now;
            this.AppointmentID = -1;
            this.UserID= -1;

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

        //private methods

        private static DataTable GetAllAppointmentsByLocalID(int LocalID)
        {
            return clsAppointmentTB.GetAllAppointmentsByLocalID(LocalID);
        }

        private bool InsertAppointment()
        {
            return clsAppointmentTB.InsertAppointment(this.TestTypeID, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.UserID, this.IsLocked, this.RetakeTestAppointmentID);
        }

        //public methods

        public static DataTable GetAppointmentsByLocalID(int LocalID)
        {
            return clsAppointment.GetAllAppointmentsByLocalID(LocalID);
        }
        public enSave save() 
        {

            switch (this._Mode) 
            {
            
                case enMode.enAddNew:
                    if (this.InsertAppointment())
                    {
                        this._Mode = enMode.enEditNew;
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

    }
}
