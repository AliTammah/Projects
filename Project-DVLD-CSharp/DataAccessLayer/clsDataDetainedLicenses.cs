using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class clsDataDetainedLicenses
    {
        string connectionString = clsConnection.ConnectionString;
        public static int Add(int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID,
                      bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            int ID = -1;
            string query = @"INSERT INTO DetainedLicenses 
                             (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID)
                             VALUES 
                             (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID);SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", licenseID);
            cmd.Parameters.AddWithValue("@DetainDate", detainDate);
            cmd.Parameters.AddWithValue("@FineFees", fineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", isReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate.HasValue ? (object)releaseDate.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID.HasValue ? (object)releasedByUserID.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID.HasValue ? (object)releaseApplicationID.Value : DBNull.Value);

            try
            {

                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int NewID)) {
                    ID = NewID;
                }
               


            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return ID;
        }
  
        

        public static bool Update(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID,
                           bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"UPDATE DetainedLicenses SET 
                                LicenseID = @LicenseID,
                                DetainDate = @DetainDate,
                                FineFees = @FineFees,
                                CreatedByUserID = @CreatedByUserID,
                                IsReleased = @IsReleased,
                                ReleaseDate = @ReleaseDate,
                                ReleasedByUserID = @ReleasedByUserID,
                                ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID";
            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetainID", detainID);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                cmd.Parameters.AddWithValue("@DetainDate", detainDate);
                cmd.Parameters.AddWithValue("@FineFees", fineFees);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                cmd.Parameters.AddWithValue("@IsReleased", isReleased);
                cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate.HasValue ? (object)releaseDate.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID.HasValue ? (object)releasedByUserID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID.HasValue ? (object)releaseApplicationID.Value : DBNull.Value);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }

        }



        public void Delete(int detainID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DetainID", detainID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static bool GetInfoByLicenseID(int licenseID,
                                      ref int DetainID,
                                      ref DateTime DetainDate,
                                      ref decimal FineFees,
                                      ref int CreatedByUserID,
                                      ref bool IsReleased,
                                      ref DateTime? ReleaseDate,
                                      ref int? ReleasedByUserID,
                                      ref int? ReleaseApplicationID)
        {
            bool recordFound = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DetainID = reader.GetInt32(reader.GetOrdinal("DetainID"));
                    DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                    FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    IsReleased = reader.GetBoolean(reader.GetOrdinal("IsReleased"));

                    int releaseDateIndex = reader.GetOrdinal("ReleaseDate");
                    ReleaseDate = reader.IsDBNull(releaseDateIndex) ? (DateTime?)null : reader.GetDateTime(releaseDateIndex);

                    int releasedByIndex = reader.GetOrdinal("ReleasedByUserID");
                    ReleasedByUserID = reader.IsDBNull(releasedByIndex) ? (int?)null : reader.GetInt32(releasedByIndex);

                    int appIndex = reader.GetOrdinal("ReleaseApplicationID");
                    ReleaseApplicationID = reader.IsDBNull(appIndex) ? (int?)null : reader.GetInt32(appIndex);

                    recordFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
                recordFound = false;
            }
            finally
            {
                conn.Close();
            }

            return recordFound;
        }

        public static bool GetInfoByID(int ID,
                               ref int LicenseID,
                               ref DateTime DetainDate,
                               ref decimal FineFees,
                               ref int CreatedByUserID,
                               ref bool IsReleased,
                               ref DateTime? ReleaseDate,
                               ref int? ReleasedByUserID,
                               ref int? ReleaseApplicationID)
        {
            bool recordFound = false;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT * FROM DetainedLicenses WHERE DetainID = @ID";

            try
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", ID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                    DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                    FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    IsReleased = reader.GetBoolean(reader.GetOrdinal("IsReleased"));

                    int releaseDateIndex = reader.GetOrdinal("ReleaseDate");
                    ReleaseDate = reader.IsDBNull(releaseDateIndex) ? (DateTime?)null : reader.GetDateTime(releaseDateIndex);

                    int releasedByIndex = reader.GetOrdinal("ReleasedByUserID");
                    ReleasedByUserID = reader.IsDBNull(releasedByIndex) ? (int?)null : reader.GetInt32(releasedByIndex);

                    int appIndex = reader.GetOrdinal("ReleaseApplicationID");
                    ReleaseApplicationID = reader.IsDBNull(appIndex) ? (int?)null : reader.GetInt32(appIndex);

                    recordFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
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
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses_View";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }

        
       
            return dataTable;
        }

        
    }
}
