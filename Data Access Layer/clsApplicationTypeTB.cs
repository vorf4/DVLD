using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsApplicationTypeTB
    {

        public static DataTable GetAllApplicationTypes()
        {
          
            DataTable dt = new DataTable()  ;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "SELECT * FROM ApplicationTypes";

            SqlCommand command = new SqlCommand(query, connection);

            try 
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex) 
            {

                // Handle exception (e.g., log the error)

            }
            finally
            {
            
                connection.Close();


            }

            return dt;

        }

        public static bool UpdateApplicationType(int applicationTypeID, string title, double fees)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE ApplicationTypes SET ApplicationTypeTitle = @Title, ApplicationFees = @Fees WHERE ApplicationTypeID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Fees", fees);
            command.Parameters.AddWithValue("@ID", applicationTypeID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if at least one row was updated
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public static double GetApplicationFees(string applicationTypeTitle)
        {
            double fees = 0.0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeTitle = @Title";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", applicationTypeTitle);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    fees = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return fees;
        }

        public static string GetApplicationTypeTitleByID(int applicationTypeID)
        {
            string title = string.Empty;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE ApplicationTypeID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", applicationTypeID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    title = result.ToString();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return title;
        }

        public static int GetApplicationTypeIDByTitle(string applicationTypeTitle)
        {
            int id = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ApplicationTypeID FROM ApplicationTypes WHERE ApplicationTypeTitle = @Title";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", applicationTypeTitle);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    id = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public static double GetApplicationFeesByID(int applicationTypeID)
        {
            double fees = 0.0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", applicationTypeID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    fees = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return fees;
        }

    }
}
