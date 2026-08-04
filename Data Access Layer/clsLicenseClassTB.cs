using System;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace Data_Access_Layer
{
    public class clsLicenseClassTB
    {

        public static DataTable GetAllClassName() 
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select ClassName from LicenseClasses";
            
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
            catch (Exception e) 
            {

                // Handle exception (e.g., log the error)

            }
            finally
            {
                connection.Close();
            }

            return dt;
        
        }

        public static double GetFeesByClassName(string className)
        {
            double fees = 0.0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ClassFees FROM LicenseClasses WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", className);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    fees = Convert.ToDouble(result);
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
            return fees;
        }

        public static int GetLicenseClassIDByClassName(string className)
        {
            int classID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT LicenseClassID FROM LicenseClasses WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", className);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    classID = Convert.ToInt32(result);
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
            return classID;
        }

        public static string GetLicenseClassNameByClassID(int classID)
        {
            string className = string.Empty;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @ClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", classID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    className = result.ToString();
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
            return className;
        }

    }
}
