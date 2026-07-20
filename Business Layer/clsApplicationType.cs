using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsApplicationType
    {

        //private variables
        private int ApplicationTypeID;
        private double Fees;
        private string Title;

        //private method

        private static DataTable _GetAllApplicationTypes()
        {
            
            // Code to retrieve all application types from the database and fill the DataTable
            return clsApplicationTypeDB.GetAllApplicationTypes();
        }

        private static bool _UpdateApplicationType(int applicationTypeID, string title, double fees)
        {
            // Code to update the application type in the database
            return clsApplicationTypeDB.UpdateApplicationType(applicationTypeID, title, fees);
        }

        //public methods

        public static DataTable GetAllApplicationTypes()
        {
            return _GetAllApplicationTypes();
        }

        public static bool UpdateApplicationType(int applicationTypeID, string title, double fees)
        {
            return _UpdateApplicationType(applicationTypeID, title, fees);
        }


        //set and get methods
        public int ApplicationTypeID1 { get => ApplicationTypeID; set => ApplicationTypeID = value; }
        public double Fees1 { get => Fees; set => Fees = value; }
        public string Title1 { get => Title; set => Title = value; }
    }
}
