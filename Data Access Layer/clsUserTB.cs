using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Data_Access_Layer
{
    public class clsUserTB
    {

        public static bool GetUserByUsernameAndPassword(string username, string password, ref int UserID
            , ref int PersonId, ref bool IsActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT UserID, PersonId, IsActive FROM Users WHERE UserName = @UserName AND Password = @Password";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonId = (int)reader["PersonId"];
                    IsActive = (bool)reader["IsActive"];
                    isFound = true;
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

            return isFound;

        }

        public static bool GetUserByID(int UserID, ref int PersonId, ref bool IsActive, ref string UserName, ref string Password)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "SELECT PersonId, IsActive, UserName, Password FROM Users WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonId = (int)reader["PersonId"];
                    IsActive = (bool)reader["IsActive"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    isFound = true;
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

            return isFound;

        }

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "SELECT        Users.UserID, Users.PersonID,\r\n" +
                "People.FirstName+''+ People.SecondName+''+ People.ThirdName+''+ People.LastName as FullName,\r\n" +
                "Users.UserName, Users.IsActive\r\nFROM           " +
                " Users INNER JOIN\r\n                     " +
                "    People ON Users.PersonID = People.PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dtUsers.Load(reader);
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
            return dtUsers;


        }
    }
}