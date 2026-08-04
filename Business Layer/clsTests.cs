using System;
using System.Data;
using Data_Access_Layer;

namespace Business_Layer
{
    public class clsTests
    {

        //constructor

        public clsTests()
        { 
        
            this.TestResult = true;
            this.Notes = string.Empty;
            this.TestID1 = -1;
            this.CreatedByUserID = -1;

        }

        // Properties

        private int TestID;
        private int _TestAppointmentID;
        private bool _TestResult;
        private string _Notes;
        private int _CreatedByUserID;

        //set and get methods

        public int TestID1 { get => TestID; set => TestID = value; }
        public int TestAppointmentID { get => _TestAppointmentID; set => _TestAppointmentID = value; }
        public bool TestResult { get => _TestResult; set => _TestResult = value; }
        public string Notes { get => _Notes; set => _Notes = value; }
        public int CreatedByUserID { get => _CreatedByUserID; set => _CreatedByUserID = value; }

        //private methods

        private bool InsertTest()
        {
            return clsTestsTB.InsertTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        //public methods

        public bool SaveTest()
        {
            return InsertTest();
        }

    }
}
