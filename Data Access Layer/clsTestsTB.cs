using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsTestsTB
    {

        public static bool InsertTest(int TestAppointmentID, bool TestResult, string Notes,int CreatedByUserID)
        {
      
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)" +
                " VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID)";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = TestResult;
            if (!string.IsNullOrEmpty(Notes))
            {
                command.Parameters.AddWithValue("@Notes", Notes);
            }
            else
            {
                command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {

                conn.Open();

                object result = command.ExecuteNonQuery();

                if (result != null&& (int)result > 0) 
                {
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error inserting test record: " + ex.Message);

            }
            finally 
            { conn.Close(); }

            return isSuccess;

        }

    }
}
