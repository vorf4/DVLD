using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsDriver
    {

        // data members

        private int _DriverID;
        private int _PersonID;
        private int _CreatedByUserID;
        private DateTime _CreatedDate;

        // private methods

        private static int InsertNewDriver(int PersonID, int CreatedByUserID)
        {
            return clsDriverTB.InsertNewDriver(PersonID, CreatedByUserID);
        }

        // public methods

        public static int AddNewDriver(int PersonID, int CreatedByUserID)
        {
            int newDriverID = InsertNewDriver(PersonID, CreatedByUserID);
            return newDriverID;
        }


        public int DriverID { get => _DriverID; set => _DriverID = value; }
        public int PersonID { get => _PersonID; set => _PersonID = value; }
        public int CreatedByUserID { get => _CreatedByUserID; set => _CreatedByUserID = value; }
        public DateTime CreatedDate { get => _CreatedDate; set => _CreatedDate = value; }

    }
}
