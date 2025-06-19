using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDataLocalDrivingLicenseApplication
    {
        public static int Add(int AppID, int LicenseClassID)
        {
            int LocalID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"insert into LocalDrivingLicenseApplications (ApplicationID,LicenseClassID)
values(@AppID,@LicenseClassID) ;SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LocalID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            return LocalID;
        }
        //public static bool Delete(int AppID) {
        public static bool GetInfoByID(int LocalID,ref int AppID,ref int ClassID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalID";
            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalID",LocalID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AppID = (int)reader["ApplicationID"];
                    ClassID = (int)reader["LicenseClassID"];
                    return true;
                }
                else
                {
                    return false;   
                }
                
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally { connection.Close(); }
            return false;
        } 
        public static bool GetInfoByAppID(int AppID,ref int LocalID,ref int ClassID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LocalDrivingLicenseApplications where ApplicationID=@AppID";
            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AppID",AppID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LocalID = (int)reader["LocalDrivingLicenseApplicationID"];
                    ClassID = (int)reader["LicenseClassID"];
                    return true;
                }
                else
                {
                    return false;   
                }
                
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally { connection.Close(); }
            return false;
        }
        public static bool Delete(int LocalID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalID";
            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalID", LocalID);
            bool isDeleted = false;
            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isDeleted = rowsAffected > 0;

            }
            catch
            {
               isDeleted= false;
            }
            finally { connection.Close(); }
            return isDeleted;
        }
      
    }
}
