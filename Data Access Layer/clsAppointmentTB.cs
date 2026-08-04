using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class clsAppointmentTB
    {

        public static DataTable GetAllAppointmentsByLocalID(int LocalID, int TestTypeID)
        {

            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection(clsDataAccessSetting.connectionString);

            string query = "select TestAppointmentID,AppointmentDate,PaidFees,IsLocked " +
                "from TestAppointments\r\n" +
                "where LocalDrivingLicenseApplicationID = @LocalID and TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@LocalID", LocalID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {

                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAllAppointmentsByLocalID: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return dt;

        }

        public static bool InsertAppointment(int TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, double PaidFees, int UserID, bool IsLocked, int RetakeTestAppointmentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "insert into TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked,RetakeTestApplicationID) values(@TestTypeID,@LocalDrivingLicenseApplicationID,@AppointmentDate,@PaidFees,@UserID,@IsLocked,@RetakeTestAppointmentID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@IsLocked", SqlDbType.Bit).Value = IsLocked;
            if (RetakeTestAppointmentID != -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestAppointmentID", RetakeTestAppointmentID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestAppointmentID", DBNull.Value);
            }
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in InsertAppointment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static bool IsAppointmentLocked(int AppointmentID)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "select IsLocked from TestAppointments where TestAppointmentID = @AppointmentID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            try
            {
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToBoolean(result);
                }
                else
                {
                    throw new Exception("Appointment not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in IsAppointmentLocked: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public static bool UpdateAppointment(int AppointmentID, DateTime AppointmentDate,  bool IsLocked)
        {
            SqlConnection con = new SqlConnection(clsDataAccessSetting.connectionString);
            string query = "update TestAppointments set AppointmentDate=@AppointmentDate,IsLocked=@IsLocked where TestAppointmentID=@AppointmentID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@IsLocked", SqlDbType.Bit).Value = IsLocked;
            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in UpdateAppointment: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

    }
}
