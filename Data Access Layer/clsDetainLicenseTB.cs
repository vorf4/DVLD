using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsDetainLicenseTB
    {

        public static bool IsDetainedLicense(int LicenseID)
        {

            bool isDetained = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select top 1 LicenseID from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    isDetained = true;
                }
                reader.Close();
            }
            catch
            {
                // Ignore any errors
            }
            finally
            {
                conn.Close();
            }

            return isDetained;

        }

        public static int InsertDetainLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int CreatedByUserID, bool IsReleased)
        {
            int newDetainID = -1;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased) " +
                           "OUTPUT INSERTED.DetainID " +
                           "VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased); select @@IDENTITY;";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newDetainID = insertedID;
                }
            }
            catch
            {
                // Ignore any errors
            }
            finally
            {
                conn.Close();
            }
            return newDetainID;
        }

        public static bool ReleaseDetainedLicense(int DetainID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool isReleased = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE DetainedLicenses SET IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isReleased = rowsAffected > 0;
            }
            catch
            {
                // Ignore any errors
            }
            finally
            {
                conn.Close();
            }
            return isReleased;
        }

        public static int GetDetainIDByLicenseID(int LicenseID)
        {
            int detainID = -1;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT TOP 1 DetainID FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int retrievedDetainID))
                {
                    detainID = retrievedDetainID;
                }
            }
            catch
            {
                // Ignore any errors
            }
            finally
            {
                conn.Close();
            }
            return detainID;
        }

        public static bool GetDetainedLicenseInfoByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate,
            ref decimal FineFees, ref int CreatedByUserID, ref bool IsReleased,
            ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {

            bool isFound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "SELECT LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID " +
                           "FROM DetainedLicenses WHERE DetainID = @DetainID";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                    FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    IsReleased = reader.GetBoolean(reader.GetOrdinal("IsReleased"));
                    ReleaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ReleaseDate"));
                    ReleasedByUserID = reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID")) ? -1 : reader.GetInt32(reader.GetOrdinal("ReleasedByUserID"));
                    ReleaseApplicationID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID")) ? -1 : reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"));
                    isFound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();

            }

            return isFound;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "select * from dbo.DetainedLicenses_View";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
            }
            catch
            {
                // Ignore any errors
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
