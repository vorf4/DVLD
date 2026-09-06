using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsLicensesTB
    {

        public static int InsertNewLicesne(int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpiryDate, 
            string Note, double PaidFees, bool IsActive, int IssueReason, int IssuedByUserID) 
        {

            int newLicenseID = -1;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"
        INSERT INTO Licenses 
            (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
        VALUES 
            (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
        
        SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClass", LicenseClassID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpiryDate);
            if (string.IsNullOrEmpty(Note))
                cmd.Parameters.AddWithValue("@Notes", System.DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Note);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", IssuedByUserID);

            try 
            {
            
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    newLicenseID = insertedID;
                }
            }
            catch
            { 
            
            } 
            finally { conn.Close(); }
            return newLicenseID;
        }

        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID, ref DateTime IssueDate, ref DateTime ExpiryDate, ref string Note
            , ref double PaidFees, ref bool IsActive, ref int IssueReason, ref int IssuedByUserID)
        {

            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) 
                {
                    reader.Read();
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClass"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpiryDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Note = reader["Notes"].ToString();
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    IssuedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    isfound = true;
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                // Handle exception (e.g., log it)

            }
            finally
            {
                conn.Close();

            }

            return isfound;
        }

        public static bool IfhaveInternationalLicense(int LicenseID) 
        {
        
            bool isfound = false;

            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "SELECT        LicenseID\r\nFROM       " +
                "     Licenses INNER JOIN\r\n              " +
                "           Applications ON Licenses.ApplicationID = Applications.ApplicationID\r\n            " +
                "             where Licenses.LicenseID = @LicenseID and Applications.ApplicationTypeID = 6";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) 
                {
                
                    isfound = true;

                }

                reader.Close();

            }
            catch
            {

                // Handle exception (e.g., log it)

            }
            finally
            {
                conn.Close();
            }

            return isfound;

        }

        public static bool IsLicenseActive(int LicenseID)
        {
            bool isActive = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT IsActive FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && bool.TryParse(result.ToString(), out bool activeStatus))
                {
                    isActive = activeStatus;
                }
            }
            catch
            {
                // Handle exception (e.g., log it)
            }
            finally
            {
                conn.Close();
            }
            return isActive;
        }

        public static int GetTypeLicense(int LicenseID)
        {
            int ID = -1;
            SqlConnection conn = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT LicenseClass FROM Licenses WHERE LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    ID = Convert.ToInt32(result);
                }
            }
            catch
            {
                // Handle exception (e.g., log it)
            }
            finally
            {
                conn.Close();
            }
            return ID;
        }
    }
}
