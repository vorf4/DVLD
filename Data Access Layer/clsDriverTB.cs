using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsDriverTB
    {

        public static int InsertNewDriver(int PersonID, int CreatedByUserID)
        {
            int newDriverID = -1;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = @"
        INSERT INTO Drivers 
            (PersonID, CreatedByUserID,CreatedDate)
        VALUES 
            (@PersonID, @CreatedByUserID, @CreatedDate);
        
        SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newDriverID = insertedID;
                }
            }
            catch
            {
                // Handle exception (log it, rethrow it, etc.)
            }
            finally
            {
                conn.Close();
            }
            return newDriverID;
        }

    }
}
