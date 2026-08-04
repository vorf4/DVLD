using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace Data_Access_Layer
{
    public class clsUserTB
    {

        public static bool GetUserByUsernameAndPassword(string username, string password, ref int UserID
            , ref int PersonId, ref bool IsActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

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

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

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

        public static bool GetUserByPersonID(int PersonID, ref int UserID, ref bool IsActive, ref string UserName, ref string Password)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT UserID, IsActive, UserName, Password FROM Users WHERE PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    UserID = (int)reader["UserID"];
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
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
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

        public static int AddUser(int PersonId, string UserName, string Password, bool IsActive)
        {
            int newUserId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "INSERT INTO Users (PersonId, UserName, Password, IsActive) VALUES (@PersonId, @UserName, @Password, @IsActive); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    newUserId = Convert.ToInt32(result);
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
            return newUserId;
        }

        public static bool UpdateUser(int UserID, int PersonId, string UserName, string Password, bool IsActive)
        {
            bool isUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "UPDATE Users SET PersonId = @PersonId, UserName = @UserName, Password = @Password, IsActive = @IsActive WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return isUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isDeleted = rowsAffected > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

        public static bool IsUserExists(int UserID)
        {
            bool exists = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }

        public static bool IsUsernameExists(string UserName)
        {
            bool exists = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }

        public static bool IsPersonIdExists(int PersonId)
        {
            bool exists = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT COUNT(*) FROM Users WHERE PersonId = @PersonId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            try
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }

        public static bool IsNationalIdExists(string NationalId)
        {
            bool exists = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT        count(*)\r\nFROM    " +
                "        People INNER JOIN\r\n       " +
                "                  Users ON People.PersonID = Users.PersonID" +
                " WHERE People.NationalNo = @NationalId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@NationalId", NationalId);
            try
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception e)
            {
                // Handle exception (e.g., log the error)
            }
            finally
            {
                connection.Close();
            }
            return exists;
        }

        public static string GetPasswordByID(int UserID)
        {
            string password = null;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.ConnectionString);
            string query = "SELECT Password FROM Users WHERE UserID = @UserID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    password = (string)result;
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
            return password;
        }

    }
}