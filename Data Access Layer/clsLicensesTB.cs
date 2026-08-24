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

    }
}
