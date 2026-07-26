using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsApplicationTB
    {

        public static int InsertApplication(int PersonID, DateTime ApplicationDate, int TypeID, int Status, 
            DateTime LastStatusDate, double PaidFees, int UserID)
        {
            int newApplicationID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "INSERT INTO Applications (ApplicationPersonID, ApplicationDate, ApplicationTypeID," +
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
                newApplicationID = (int)command.ExecuteScalar();
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
            ref int TypeID,ref int Status,ref DateTime LastStatusDate,ref double PaidFees,ref int UserID) 
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID " +
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
                    PersonID = (int)reader["ApplicationPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    TypeID = (int)reader["ApplicationTypeID"];
                    Status = (int)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (double)reader["PaidFees"];
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

    }
}
