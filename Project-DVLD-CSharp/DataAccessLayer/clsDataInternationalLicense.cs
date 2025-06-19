using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataInternationalLicense
    {
       
        
            public static int Add(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
                DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
            {
                int InternationalLicenseID = -1;
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

                string query = @"INSERT INTO InternationalLicenses 
            (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
            VALUES 
            (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
            SELECT SCOPE_IDENTITY();";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int newID))
                    {
                        InternationalLicenseID = newID;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inserting international license: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return InternationalLicenseID;
            }

            public static bool Update(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
                DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
            {
                bool isUpdated = false;
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

                string query = @"UPDATE InternationalLicenses SET 
            ApplicationID = @ApplicationID,
            DriverID = @DriverID,
            IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
            IssueDate = @IssueDate,
            ExpirationDate = @ExpirationDate,
            IsActive = @IsActive,
            CreatedByUserID = @CreatedByUserID
            WHERE InternationalLicenseID = @InternationalLicenseID";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
                    cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                    cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                    cmd.Parameters.AddWithValue("@IsActive", IsActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isUpdated = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating international license: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return isUpdated;
            }

            public static bool DeleteByID(int InternationalLicenseID)
            {
                bool isDeleted = false;
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

                string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @ID";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", InternationalLicenseID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    isDeleted = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting international license: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return isDeleted;
            }
        public static bool IsExist(int LocalID)
        {
            bool exists = false;
            using (SqlConnection conn = new SqlConnection(clsConnection.ConnectionString))
            {
                string query = "SELECT 1 FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @LocalID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LocalID", LocalID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        exists = result != null;
                    }
                    catch (Exception ex)
                    {
                        // يمكنك تسجيل الخطأ هنا إن أردت
                    }
                }
            }
            return exists;
        }

        public static bool GetInfoByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID,
                ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,
                ref bool IsActive, ref int CreatedByUserID)
            {
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
                string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @ID";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", InternationalLicenseID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                        DriverID = Convert.ToInt32(reader["DriverID"]);
                        IssuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                        ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                        IsActive = Convert.ToBoolean(reader["IsActive"]);
                        CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving international license: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return false;
            }

            public static DataTable GetAll()
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

                string query = "SELECT * FROM InternationalLicenses";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading international licenses: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return dt;
            }
        public static DataTable GetAllByInternationalAppID(int AppID)
            {
                DataTable dt = new DataTable();
                SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

                string query = "SELECT * FROM InternationalLicenses where DriverID=@AppID";

                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@AppID", AppID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading international licenses: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return dt;
            }
        }
    }


