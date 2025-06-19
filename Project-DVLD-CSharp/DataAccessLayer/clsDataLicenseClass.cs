using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsDataLicenseClass
    {


        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LicenseClasses ";
            SqlCommand cmd=new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                    dt.Load(reader);
                
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        public static bool IsExist(int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from LicenseClasses where LicenseClass=@ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
            }
            catch
            {
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool GetInfoByID(int ID, ref string ClassName, ref string DescriptionClass,
            ref int MinimumAlloAge, ref int validityLength, ref decimal ClassFees)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LicenseClasses where LicenseClassID=@ID";
            SqlCommand CMD = new SqlCommand(query, connection);
            CMD.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                if (reader.Read())
                {
                    ClassName = (string)reader["ClassName"];
                    DescriptionClass = (string)reader["ClassDescription"];
                    MinimumAlloAge = (byte)reader["MinimumAllowedAge"];
                    validityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];
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
            finally
            {
                connection.Close();
            }
        } 
        public static bool GetInfoByName( string ClassName,ref int ID, ref string DescriptionClass,
            ref byte MinimumAlloAge, ref byte validityLength, ref decimal ClassFees)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LicenseClasses where ClassName=@ClassName";
            SqlCommand CMD = new SqlCommand(query, connection);
            CMD.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                connection.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                if (reader.Read())
                {
                    ID = (int)reader["licenseClassID"];
                    DescriptionClass = (string)reader["ClassDescription"];
                    MinimumAlloAge = (byte)reader["MinimumAllowedAge"];
                    validityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = (decimal)reader["ClassFees"];
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
            finally
            {
                connection.Close();
            }
        }

    }
}
