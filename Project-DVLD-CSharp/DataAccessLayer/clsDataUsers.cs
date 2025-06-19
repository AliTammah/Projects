using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer
{
    public class clsDataUsers
    {
        public static int  AddUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"insert into Users(PersonID,UserName,Password,IsActive)
                     values(@PersonID,@UserName,@Password,@IsActive);SELECT SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int UserIDInserted))
                {
                    UserID = UserIDInserted;
                }
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return UserID;
        } 
        public static bool  GetInfoByID(int ID,ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)
        {
            //int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from Users where UserID=@ID";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive =(bool) reader["IsActive"];
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
        public static bool  GetInfoByUserName(string UserName,ref int PersonID,ref int ID,ref string Password,ref bool IsActive)
        {
            //int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from Users where UserName=@UserName";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    ID = (int)reader["UserID"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
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
    public static bool  IsExist(int UserID)
        {
            //int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Users where UserID=@UserID";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
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
        public static bool  IsExistByUserName(string UserName)
        {
            //int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Users where UserName=@UserName";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
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
        public static bool  IsExistByPersonID(int PersonID)
        {
            //int UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from Users where PersonID=@PersonID";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
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
 public static DataTable  GetAllUsers()
        {
            //int UserID = -1;
            DataTable dataTable = new DataTable();
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from Users";
            SqlCommand command=new SqlCommand(query, connection);
            //command.Parameters.AddWithValue("@UserID", UserID);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dataTable.Load(reader);
                }
                reader.Close();

            }
            catch
            {
                //return false;
            }
            finally
            {
                connection.Close();
            }
          return dataTable;
        }
        public static bool DeleteUser(int ID)
        {
            int rowsAffcted = 0;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"delete Users where UserID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                //SqlDataReader reader = command.ExecuteReader();
                rowsAffcted = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //rowsAffcted = 0;
            }
            finally { connection.Close(); }
            return rowsAffcted > 0;

        }
        public static bool  UpdateUser(int ID,int PersonID,string UserName,string Password,bool IsActive)
        {
             //UserID = -1;
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"update Users
                                    set PersonID=@PersonID,
                                    
                                    UserName=@UserName,
                                    Password=@Password,

                                    IsActive=@IsActive
                                    where UserID=@ID
                                    ";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            int rwos = 0;
            try
            {
                connection.Open();
               rwos=command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rwos>0);
        }
    }
}
