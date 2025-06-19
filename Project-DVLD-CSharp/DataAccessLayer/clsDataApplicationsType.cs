using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsDataApplicationsType
    {

        public static int AddApplicationsType(string Name, decimal Fees)
        {
            int AppID = -1;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"insert into ApplicationTypes(ApplicationTypeID,ApplicationTypeTitle,ApplictionFees)
                            values(@Name,@Fees); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    AppID = InsertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return AppID;

        }
        public static bool Update(int ID, string Name, decimal Fees)
        {
            int rwos = 0;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"UPDATE ApplicationTypes set 
                                      ApplicationTypeTitle=@Name,
                                        ApplicationFees=@Fees where ApplicationTypeID=@ID    ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Fees", Fees);
            try {
                connection.Open();
                rwos = command.ExecuteNonQuery();

            }
            catch {
                return false;
            }
            finally { connection.Close(); }
            return rwos > 0;
        }
        public static bool IsExist(int ID)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select found=1 from ApplicationTypes where ApplicationTypeID=@ID";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
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
        }
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            SqlConnection connection=new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from ApplicationTypes ";
            SqlCommand command =new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return table;
        }
        public static bool GetInfoByID(int ID, ref string name, ref decimal fees)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from ApplicationTypes where ApplicationTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    name = (string)reader["ApplicationTypeTitle"];
                    fees = (decimal)reader["ApplicationFees"];

                }
                else
                {
                    isfound = false;
                }
                reader.Close();

            }
            catch { isfound = false; }
            finally { connection.Close(); }
            return isfound;
        } 
        public static bool GetInfoByName( string name,ref int ID, ref decimal fees)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from ApplicationTypes where ApplicationTypeTitle=@name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    ID = (int)reader["ApplicationID"];
                    fees = (decimal)reader["ApplicationFees"];

                }
                else
                {
                    isfound = false;
                }
                reader.Close();

            }
            catch { isfound = false; }
            finally { connection.Close(); }
            return isfound;
        }
    } 
}
