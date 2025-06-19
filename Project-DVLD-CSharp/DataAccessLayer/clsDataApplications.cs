using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class clsDataApplications
    {

        public static int Add(int ApplicationPersonID,DateTime ApplicationDate,int AppTypeID,
            int AppStatus,DateTime LastStatusDate,decimal PaidFees,int UserID)
        {
            int AppID = -1;
            SqlConnection conn = new SqlConnection(clsConnection.ConnectionString);
            string query = @"insert into Applications (ApplicantPersonID,ApplicationDate,ApplicationTypeID,
ApplicationStatus,LastStatusDate,PaidFees,CreatedByUserID)
values(@ApplicationPersonID,@ApplicationDate,@AppTypeID,@AppStatus,@LastStatusDate,@PaidFees,@UserID); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            cmd.Parameters.AddWithValue("@AppStatus", AppStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                conn.Open();
                object reader = cmd.ExecuteScalar();
                if (reader != null && int.TryParse(reader.ToString(), out int InsertedID))
                {
                    AppID = InsertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return AppID;
        }
        public static bool Update(int ID, int AppPersonID, DateTime AppDate, int AppTypeID,
            int AppStatus, DateTime LastStatusDate, decimal PaidFees, int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"update Applications set 
ApplicantPersonID=@AppPersonID,
ApplicationDate=@AppDate,
ApplicationTypeID=@AppTypeID,
ApplicationStatus=@AppStatus,
LastStatusDate=@LastStatusDate,
PaidFees=@PaidFees,
CreatedByUserID=@UserID where ApplicationID=@ID";
            bool isUpdate = false;

            SqlCommand cmd=new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@AppPersonID", AppPersonID);
            cmd.Parameters.AddWithValue("@AppDate", AppDate);
            cmd.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            cmd.Parameters.AddWithValue("@AppStatus", AppStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
              object result=cmd.ExecuteScalar();
                if (result != null)
                {
                    isUpdate = true;
                }
                else
                {
                    isUpdate = false;
                }
            }
            catch (Exception ex)
            {
                isUpdate= false;
            }
            finally
            {
                connection.Close();
            }
            return isUpdate;
        }
        public static bool ISExistByID(int ID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Applications where ApplicationID=@ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            int rows = 0;
            try
            {
                connection.Open();
                rows = cmd.ExecuteNonQuery();


            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rows > 0;
        }
        public static bool Delete(int ID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"delete from Applications where ApplicationID=@ID";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            bool isDeleted = false;
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                isDeleted = result != null; 
            }
            catch
            {
               isDeleted= false;
            }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }
        public static bool GetInfoByID(int ID, ref int AppPersonID, ref DateTime AppDate, ref int AppTypeID,
           ref int AppStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int UserID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"SELECT *
FROM Applications WHERE ApplicationID = @ID
";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID)
;
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
               if(reader.Read()) {  
                    AppPersonID = (int)reader["ApplicantPersonID"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    AppTypeID = (int)reader["ApplicationTypeID"];
                    //AppTypeID = (int)reader["ApplicationTypeID"];
                    AppStatus = (byte)reader["ApplicationStatus"];
                    PaidFees = (decimal)reader["PaidFees"];
                    UserID = (int)reader["CreatedByUserID"];
                    return true;
                }
                else
                {
                    return false;
                }
                reader.Close();
            }
            catch { return false; }
            finally { connection.Close(); }

        }
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from LocalDrivingLicenseApplications_View";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                    dt.Load(reader);
                
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
        public static DataTable GetAllLocalDriving()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection( clsConnection.ConnectionString);
            string query = @"select *from LocalDrivingLicenseApplications_View ";
           SqlCommand cmd =new SqlCommand(query, connection);
            //cmd.Parameters.AddWithValue("@className",className);
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                    dt.Load(reader);
                
                reader.Close();
            }
            catch {}
            finally { connection.Close(); }
            return dt;
        }
        public static bool UpdateStatus(int ID, int status)
        {
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"update Applications
                                    set ApplicationStatus=@status where ApplicationID=@ID";
            SqlCommand cmd=new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@status", status);
            try
            {
                connection.Open();
               object res= cmd.ExecuteScalar();
                if(res != null) 
                    return true;
                else
                    return false;
            }
            catch{
                return false;
            }
            finally { connection.Close(); }
        } 
       
    }
}
