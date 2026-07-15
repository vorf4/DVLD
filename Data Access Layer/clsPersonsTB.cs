using System;
using System.Data;  
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Web;

namespace Data_Access_Layer
{
    public class clsPersonsTB
    {
        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select * from People";

            SqlCommand command = new SqlCommand(query, connection);

            try {

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
            }
            finally {

                connection.Close();
            
            }

            return dt;
        }

        public static int GetCountryByName(string Name)
        {
            int countryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select CountryID from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    countryID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
            }
            finally
            {
                connection.Close();
            }

            return countryID;
        }

        public static string GetCountryNameByID(int CountryID)
        {
            string countryName = null;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select CountryName from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    countryName = Convert.ToString(result);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
            }
            finally
            {
                connection.Close();
            }

            return countryName;
        }

        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName
            , string NationalNo, DateTime DateOfBirth, int Gender, string Address, string Phone, 
            string Email, int NationalityCountryID, string ImagePath)
        {

            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "insert into People (FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth " +
                ", Gendor, Address, Phone, Email, NationalityCountryID, ImagePath) values (@FirstName, @SecondName, @ThirdName, @LastName, @NationalNo, @DateOfBirth" +
                ", @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath); select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            // Handle the Email parameter, allowing it to be null if not provided
            if (Email != null && Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            if (!string.IsNullOrEmpty(ImagePath))
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    PersonID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
            }
            finally
            {
                connection.Close();
            }

            return PersonID;

        }

        public static void UpdatePersonInfo(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo
            , DateTime DateOfBirth, int Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "update People set FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, NationalNo = @NationalNo, DateOfBirth = @DateOfBirth" +
                ", Gendor = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            // Handle the Email parameter, allowing it to be null if not provided
            if (Email != null && Email != "")
            {
                command.Parameters.AddWithValue("@Email", Email);
            }
            else
            {
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            }

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            //you can put image path null if you don't want to update it, or you can pass the new image path to update it

            if (!string.IsNullOrEmpty(ImagePath))
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it, rethrow it, etc.)
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool GetPersonByID(int PersonID,ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            ,ref string NationalNo, ref DateTime DateOfBirth, ref int Gender, ref string Address, 
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath) {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select * from People where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try {

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                isFound = reader.Read();

                if(isFound)
                {

                    FirstName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();
                    ThirdName = reader["ThirdName"].ToString();
                    LastName = reader["LastName"].ToString();
                    NationalNo = reader["NationalNo"].ToString();
                    DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                    Gender = int.Parse(reader["Gendor"].ToString());
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email = reader["Email"].ToString();
                    NationalityCountryID = int.Parse(reader["NationalityCountryID"].ToString());
                    ImagePath = reader["ImagePath"].ToString();

                }

                isFound = true; 
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                // Handle the exception (e.g., log it, rethrow it, etc.)

            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool IsNationalNoExists(string NationalNo)
        {
           
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select count(*) from People where NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                isFound = count > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "delete from People where PersonID = @PersonID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isDeleted = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

    }
}
