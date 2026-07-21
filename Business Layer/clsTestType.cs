using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsTestType
    {

        private static DataTable _GetInfoTests() { return clsTestTypeTB.GetInfoOfTestType(); }

        public static DataTable GetInfoOfTestType() { return _GetInfoTests(); }

        private static bool _UpdateTestType(int testTypeID, string testTypeTitle, string testTypeDescription, double testTypeFees)
        {
            return clsTestTypeTB.UpdateTestTypeByID(testTypeID, testTypeTitle, testTypeDescription, testTypeFees);
        }

        public static bool UpdateTestType(int testTypeID, string testTypeTitle, string testTypeDescription, double testTypeFees)
        {
            return _UpdateTestType(testTypeID, testTypeTitle, testTypeDescription, testTypeFees);
        }



    }
}
