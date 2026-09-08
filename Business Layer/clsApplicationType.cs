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
            return clsApplicationTypeTB.GetAllApplicationTypes();
        }

        private static bool _UpdateApplicationType(int applicationTypeID, string title, double fees)
        {
            // Code to update the application type in the database
            return clsApplicationTypeTB.UpdateApplicationType(applicationTypeID, title, fees);
        }

        private static double _GetApplicationFees(string applicationTypeTitle)
        {
            // Code to retrieve the fees for a specific application type from the database
            return clsApplicationTypeTB.GetApplicationFees(applicationTypeTitle);
        }

        private static string _GetApplicationTypeTitle(int applicationTypeID)
        {
            // Code to retrieve the title for a specific application type from the database
            return clsApplicationTypeTB.GetApplicationTypeTitleByID(applicationTypeID);
        }

        private static int _GetApplicationTypeID(string applicationTypeTitle)
        {
            // Code to retrieve the ID for a specific application type from the database
            return clsApplicationTypeTB.GetApplicationTypeIDByTitle(applicationTypeTitle);
        }

        private static double _GetApplicationFeesByID(int applicationTypeID)
        {
            // Code to retrieve the fees for a specific application type by ID from the database
            return clsApplicationTypeTB.GetApplicationFeesByID(applicationTypeID);
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

        public static double GetApplicationFees(string applicationTypeTitle)
        {
            return _GetApplicationFees(applicationTypeTitle);
        }

        public static string GetApplicationTypeTitle(int applicationTypeID)
        {
            return _GetApplicationTypeTitle(applicationTypeID);
        }

        public static int GetApplicationTypeID(string applicationTypeTitle)
        {
            return _GetApplicationTypeID(applicationTypeTitle);
        }

        public static double GetApplicationFeesByID(int applicationTypeID)
        {
            return _GetApplicationFeesByID(applicationTypeID);
        }

        //set and get methods
        public int ApplicationTypeID1 { get => ApplicationTypeID; set => ApplicationTypeID = value; }
        public double Fees1 { get => Fees; set => Fees = value; }
        public string Title1 { get => Title; set => Title = value; }
    }
}
