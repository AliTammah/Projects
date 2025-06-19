using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using DataAccessLayer;
namespace DataAccessLayer
{
    public  class clsDataTests
    {
        public static int Add(int AppID, bool result, string notes, int UserID)
        {
            int TestID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"insert into Tests (TestAppointmentID,TestResult,Notes,CreatedByUserID)
                    values(@AppID,@result,@notes,@UserID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            cmd.Parameters.AddWithValue("@result", result);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                conn.Open();

                object resu = cmd.ExecuteScalar();

                if (resu != null && int.TryParse(resu.ToString(), out int NewID))
                {
                    TestID = NewID;
                }
            }
            catch
            {

            }
            finally { conn.Close(); }
            return TestID;
        }
        public static bool Update(int ID,int AppID, bool result, string notes, int UserID)
        {
            SqlConnection conn=new SqlConnection(clsConnection.ConnectionString);
            string query = @"update Tests 
                                            set AppointmentID=@AppID,
    TestResult=@result,
Notes=@notes,CreatedByUserID=@UserID 
where TestID=@ID";

            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            cmd.Parameters.AddWithValue("@result", result);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            bool isUpdated=false;
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    isUpdated = true;
                }
            }
            catch
            {
                isUpdated = false;
            }
            finally
            {
                conn.Close();
            }
            return isUpdated;
        }
        public static bool IsExist(int ID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Tests where TestID=@ID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            bool isExist = false;
            try
            {
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isExist = true;
                }
            }
            catch
            {
                isExist = false;
            }
            finally
            {
                conn.Close();
            }
            return isExist;
        }
        public static bool IsExistByAppoin(int ID)
        {
            bool isExist = false;

            string query = @"SELECT 1 FROM Tests WHERE TestAppointmentID = @ID";

            using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ID", ID);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        isExist = reader.HasRows;
                    }
                }
                catch
                {
                    isExist = false;
                }
            }

            return isExist;
        }

        public static bool GetInfoByID(int ID,ref int AppID, ref bool result,ref  string notes,ref int UserID)
        {
            SqlConnection conn=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Tests where TestID=@ID";
            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            cmd.Parameters.AddWithValue("@result", result);
            cmd.Parameters.AddWithValue("@notes", notes);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            bool isExist = false;
            try { 
            conn.Open();
            SqlDataReader reader =cmd.ExecuteReader();
                if (reader.Read()) {
            isExist = true;
                    AppID = (int)reader["AppointmentID"];
                    result = (bool)reader["TestResult"];
                    notes = (string)reader["Notes"];
                    AppID = (int)reader["CreatedByUserID"];

            }
                else
                {
                    isExist = false;
                }
                reader.Close();
        }
            catch
            {
                isExist = false;
            }
            finally
            {
                conn.Close();
            }
return isExist;
        }
        public static bool GetInfoByAppointmentID(int AppID,ref int ID, ref bool result,ref  string notes,ref int UserID)
        {
            SqlConnection conn=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select * from Tests where TestAppointmentID=@AppID";
            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            //cmd.Parameters.AddWithValue("@ID", ID);
            //cmd.Parameters.AddWithValue("@result", result);
            //cmd.Parameters.AddWithValue("@notes", notes);
            //cmd.Parameters.AddWithValue("@UserID", UserID);
            bool isExist = false;
            try { 
            conn.Open();
            SqlDataReader reader =cmd.ExecuteReader();
                if (reader.Read()) {
                    ID = reader["TestID"] != DBNull.Value ? (int)reader["TestID"] : 0;
                    result = reader["TestResult"] != DBNull.Value ? (bool)reader["TestResult"] : false;
                    notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : string.Empty;
                    UserID = reader["CreatedByUserID"] != DBNull.Value ? (int)reader["CreatedByUserID"] : 0;

                    isExist = true;

                }
                else
                {
                    isExist = false;
                }
                reader.Close();
        }
            catch
            {
                isExist = false;
            }
            finally
            {
                conn.Close();
            }
return isExist;
        }
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *
                     FROM Tests";

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
    }
}
