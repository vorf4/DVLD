using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsLicenseClass
    { 

        private int _id;
        private string _name;
        private string _description;
        private string _MinimumAllowedAge;
        private string _MaximumAllowedAge;
        private double _Fees;

        private static DataTable GetAllClassName() 
        {
        return clsLicenseClassTB.GetAllClassName();
        }

        private static double GetFeesByClassName(string className)
        {
            return clsLicenseClassTB.GetFeesByClassName(className);
        }

        private static int GetClassIDByClassName(string className)
        {
            return clsLicenseClassTB.GetLicenseClassIDByClassName(className);
        }

        public static DataTable GetClassName()
        {
        return GetAllClassName();
        }

        public static double GetFees(string className)
        {
            return GetFeesByClassName(className);
        }

        public static int GetClassID(string className)
        {
            return GetClassIDByClassName(className);
        }

    }
}
