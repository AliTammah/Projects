using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataApplicationInfo
    {
        public static bool GetInfoApplicationBasic(int ID, ref string FullName, ref int PassedTest, ref string status)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select FullName,Status,PassedTestCount from LocalDrivingLicenseApplications_View 
                                    where LocalDrivingLicenseApplicationID=@ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@FullName", FullName);
            cmd.Parameters.AddWithValue("@PassedTest", PassedTest);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FullName = (string)reader["FullName"];
                    PassedTest = (int)reader["PassedTestCount"];
                    status = (string)reader["Status"];

                    return true;
                }


                else
                    return false;
                reader.Close();
            }
            catch
            {
                return false;
            }
            finally { connection.Close(); }
        }
    }
}
