using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsApplicationTB
    {

        public static int InsertApplication(int PersonID, DateTime ApplicationDate, int TypeID, byte Status, 
            DateTime LastStatusDate, decimal PaidFees, int UserID)
        {
            int newApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID," +
                " ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) " +
                           "VALUES (@PersonID, @ApplicationDate, @TypeID, @Status, @LastStatusDate, @PaidFees, @UserID); select scope_identity();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newApplicationID = insertedID;
                }
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return newApplicationID;
        }

        public static bool GetApplicationByID(int ApplicationID,ref int PersonID,ref DateTime ApplicationDate,
            ref int TypeID,ref byte Status,ref DateTime LastStatusDate,ref decimal PaidFees,ref int UserID) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID " +
                           "FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    reader.Read();
                    PersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    TypeID = (int)reader["ApplicationTypeID"];
                    Status = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    UserID = (int)reader["CreatedByUserID"];
                    isFound = true;
                }

                reader.Close();

            }
            catch 
            {

                //handle exception (e.g., log the error)

            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool CheckIfPersonHasThisApplicationType(int PersonID, int TypeID)
        {
            bool hasApplication = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "SELECT COUNT(*) FROM Applications WHERE ApplicationPersonID = @PersonID AND ApplicationTypeID = @TypeID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@TypeID", TypeID);
            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                hasApplication = count > 0;
            }
            catch
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return hasApplication;
        }

        public static bool UpdateApplicationStatus(int ApplicationID, byte NewStatus, DateTime LastStatusDate)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "UPDATE Applications SET ApplicationStatus = @NewStatus, LastStatusDate = @LastStatusDate WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

    }
}
