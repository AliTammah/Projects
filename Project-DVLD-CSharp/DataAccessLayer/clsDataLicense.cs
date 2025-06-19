using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataBusnissLayer
{
    public class clsDataLicense
    {
        public static int Add(int ApplicationID, int DriverID, int ClassLicense, DateTime IssueDate,
    DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive, int IssueReason, int UserID)
        {
            int LicenseID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"INSERT INTO Licenses 
        (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
        VALUES 
        (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @UserID);
        SELECT SCOPE_IDENTITY();"; // لإرجاع ID الرخصة الجديدة

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@LicenseClass", ClassLicense);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                cmd.Parameters.AddWithValue("@Notes", Notes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int newID))
                {
                    LicenseID = newID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting license: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return LicenseID;
        }
        public static bool Update(int LicenseID, int ApplicationID, int DriverID, int ClassLicense, DateTime IssueDate,
    DateTime ExpirationDate, string Notes, int PaidFees, bool IsActive, int IssueReason, int UserID)
        {
            bool isUpdated = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"UPDATE Licenses SET 
        ApplicationID = @ApplicationID,
        DriverID = @DriverID,
        LicenseClass = @LicenseClass,
        IssueDate = @IssueDate,
        ExpirationDate = @ExpirationDate,
        Notes = @Notes,
        PaidFees = @PaidFees,
        IsActive = @IsActive,
        IssueReason = @IssueReason,
        CreatedByUserID = @UserID
        WHERE LicenseID = @LicenseID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", DriverID);
                cmd.Parameters.AddWithValue("@LicenseClass", ClassLicense);
                cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                cmd.Parameters.AddWithValue("@Notes", Notes ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                cmd.Parameters.AddWithValue("@IsActive", IsActive);
                cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
                cmd.Parameters.AddWithValue("@UserID", UserID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isUpdated = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating license: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isUpdated;
        }
        public static bool GetInfoByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID,
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref int PaidFees, ref bool IsActive, ref int IssueReason, ref int UserID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClass =Convert.ToInt32( reader["LicenseClass"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    UserID = Convert.ToInt32(reader["CreatedByUserID"]);
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
        public static bool GetInfoByApplicationID(int ApplicationID, ref int LicenseID, ref int DriverID,
            ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
            ref string Notes, ref int PaidFees, ref bool IsActive, ref int IssueReason, ref int UserID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = "SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = Convert.ToInt32(reader["LicenseID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    LicenseClass =Convert.ToInt32( reader["LicenseClass"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    Notes = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                    PaidFees = Convert.ToInt32(reader["PaidFees"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    UserID = Convert.ToInt32(reader["CreatedByUserID"]);
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

        public static bool DeleteByLicenseID(int LicenseID)
        {
            bool isDeleted = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                isDeleted = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting license: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isDeleted;
        }
        //public static bool IsExistByLocalID(int LocalID)
        //{
        //    bool isExist = false;
        //    SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

        //    string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

        //        conn.Open();
        //        int rowsAffected = cmd.ExecuteNonQuery();
        //        isDeleted = rowsAffected > 0;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error deleting license: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //    return isDeleted;
        //}
        public static DataTable GetAll(int AppID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select LicenseID,ApplicationID,c.ClassName,IssueDate,ExpirationDate,IsActive from Licenses

        l inner join LicenseClasses c on l.LicenseClass=c.LicenseClassID where DriverID=@AppID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                    dt.Load(reader);
                
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;
        }  
        public static DataTable GetAllLicenseInternational()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from InternationalLicenses";

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
