using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataTestAppointments
    {
        public static int Add(int ID, int TesTypeID, int LocalID, DateTime Date,
           decimal PaidFees, int UserID, bool IsLocked,int ?RTAppID)
        {
            int PointID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"INSERT INTO TestAppointments
                    (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked,RetakeTestApplicationID)
                     VALUES ( @TesTypeID, @LocalID, @Date, @PaidFees, @UserID, @IsLocked,@RTAppID);
                     SELECT SCOPE_IDENTITY();"; // لجلب الـ ID الجديد المدخل (إذا كان أوتوماتيك)

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@TesTypeID", TesTypeID);
                cmd.Parameters.AddWithValue("@LocalID", LocalID);
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
                cmd.Parameters.AddWithValue("@RTAppID", RTAppID.HasValue ? (object)RTAppID.Value : DBNull.Value);

                conn.Open();
                object result = cmd.ExecuteScalar(); // نحصل على الـ ID الجديد إذا كان موجود

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    PointID = newID;
                }
            }
            catch (Exception ex)
            {
                // التعامل مع الخطأ أو تسجيله
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return PointID;
        }

        public static bool Update(int ID, int TesTypeID, int LocalID, DateTime Date,
    decimal PaidFees, int UserID, bool IsLocked, int ?RTAppID)
        {
            bool isUpdated = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"UPDATE TestAppointments
                     SET TestTypeID = @TesTypeID,
                         LocalDrivingLicenseApplicationID = @LocalID,
                         AppointmentDate = @AppointmentDate,
                         PaidFees = @PaidFees,
                         CreatedByUserID = @CreatedByUserID,
                         IsLocked = @IsLocked,
                         RetakeTestApplicationID = @RTAppID
                     where TestAppointmentID = @ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@TesTypeID", TesTypeID);
                cmd.Parameters.AddWithValue("@LocalID", LocalID);
                cmd.Parameters.AddWithValue("@AppointmentDate", Date);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", UserID);
                cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
                cmd.Parameters.AddWithValue("@RTAppID", RTAppID.HasValue ? (object)RTAppID.Value : DBNull.Value);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
            }
            catch (Exception ex)
            {
                // يمكن تسجيل الخطأ أو عرضه
                //Console.WriteLine(ex.Message);
                isUpdated = false;
            }
            finally
            {
                conn.Close();
            }

            return isUpdated;
        }
        public static bool GetInfoByID(int ID, ref int TesTypeID, ref int LocalID, ref DateTime Date,
                                       ref decimal PaidFees, ref int UserID, ref bool IsLocked,ref int? RTAppID)
        {
            bool recordFound = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *
                     FROM TestAppointments
                     WHERE TestAppointmentID = @ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TesTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
                    LocalID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID"));
                    Date = reader.GetDateTime(reader.GetOrdinal("AppointmentDate"));
                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                    UserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked"));
                    int ordinal = reader.GetOrdinal("RetakeTestApplicationID");
                    RTAppID = reader.IsDBNull(ordinal) ? (int?)null : reader.GetInt32(ordinal);

                    recordFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                recordFound = false;
            }
            finally
            {
                conn.Close();
            }

            return recordFound;
        }
       public static bool GetInfoByLocalID( int LocalID, ref int TesTypeID, ref int ID, ref DateTime Date,
                                       ref decimal PaidFees, ref int UserID, ref bool IsLocked,ref int? RTAppID)
        {
            bool recordFound = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *
                     FROM TestAppointments
                     WHERE LocalDrivingLicenseApplicationID = @LocalID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LocalID", LocalID);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TesTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
                    ID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID"));
                    Date = reader.GetDateTime(reader.GetOrdinal("AppointmentDate"));
                    PaidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                    UserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    IsLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked"));
                    int ordinal = reader.GetOrdinal("RetakeTestApplicationID");
                    RTAppID = reader.IsDBNull(ordinal) ? (int?)null : reader.GetInt32(ordinal);

                    recordFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                recordFound = false;
            }
            finally
            {
                conn.Close();
            }

            return recordFound;
        }
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *
                     FROM TestAppointments";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static DataTable GetAllByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *
                     FROM TestAppointments where LocalDrivingLicenseApplicationID=@ID ";

                SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        public static bool IsExist(int ID)
        {
            bool exists = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT COUNT(1) FROM TestAppointments WHERE ID = @ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                exists = count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return exists;
        }


    }
}
