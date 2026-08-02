using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Data_Access_Layer
{
    public class clsLocalDrivingLicenseApplicationTB
    {

        public static int AddNewLocalLicense(int applicationID, int licenseClassID)
        {
            int newID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID)" +
                " VALUES (@ApplicationID, @LicenseClassID); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationID);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newID = insertedID;
                }
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
                newID = 0; // Indicate failure
            }
            finally
            {
                connection.Close();
            }
            return newID;
        }

        public static bool IsPersonIDHaveThisLicense(int personID, int LicenseClassID)
        {

            bool isFound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT        ApplicantPersonID\r\nFROM        " +
                "    Applications INNER JOIN\r\n          " +
                "               LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID\r\n  " +
                "                       where ApplicantPersonID = @PersonID and LicenseClassID = @LicenseClassID and Applications.ApplicationStatus != 2;";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                conn.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    isFound = true;
                }

                reader.Close();

            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
                isFound = false; // Indicate failure
            }
            finally
            {
                conn.Close();
            }

            return isFound;

        }

        public static DataTable GetAllInfoOfLocalLicenseApplication()
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select * from LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public static int GetApplicationIDByLocalID(int localID)
        {
            int applicationID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalID";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@LocalID", localID);

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int id))
                {
                    applicationID = id;
                }
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                conn.Close();
            }

            return applicationID;
        }

        public static bool GetLocalDrivingLicenseApplicationByID(int localID, ref int applicationID, ref int licenseClassID)
        {

            bool result = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT ApplicationID, LicenseClassID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalID";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LocalID", localID);

            try
            {

                conn.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    licenseClassID = (int)reader["LicenseClassID"];
                    result = true;
                }
                reader.Close();

            }
            catch
            {

                // Handle exception (e.g., log the error)

            }
            finally
            {
                conn.Close();

            }
            return result;

        }



    }
        
}
