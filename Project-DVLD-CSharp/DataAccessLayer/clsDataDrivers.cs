using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class clsDataDrivers
    {
        public static int Add(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int DriverID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                         VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                         SELECT SCOPE_IDENTITY();";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    DriverID = newID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return DriverID;
        }

        public static bool Update(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            bool isUpdated = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"UPDATE Drivers 
                         SET PersonID = @PersonID, 
                             CreatedByUserID = @CreatedByUserID, 
                             CreatedDate = @CreatedDate 
                         WHERE DriverID = @DriverID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                conn.Open();
                isUpdated = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isUpdated;
        }

        public static bool GetInfoByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public static bool DeleteByDriverID(int DriverID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID";
            bool isDeleted = false;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);

                conn.Open();
                isDeleted = cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isDeleted;
        }

        public static bool ISExistByID(int DriverID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT COUNT(*) FROM Drivers WHERE DriverID = @DriverID";
            bool exists = false;

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);

                conn.Open();
                exists = (int)cmd.ExecuteScalar() > 0;
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

        public static DataTable GetAll()
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT * FROM Drivers";
            DataTable dt = new DataTable();

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

            return dt;
        }
        public static DataTable GetAllFromDriversView()
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT * FROM Drivers_View";
            DataTable dt = new DataTable();

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

            return dt;
        }
    }
}
