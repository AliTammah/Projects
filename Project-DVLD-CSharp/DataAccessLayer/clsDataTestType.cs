using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;


namespace DataAccessLayer
{
    public  class clsDataTestType
    {
        public static bool Update (int ID,string TypeTest,string Description,decimal Fees)
        {
            int row=0;
           SqlConnection connection=new SqlConnection (clsConnection.ConnectionString);
            string query = @"update TestTypes 
                                set TestTypeTitle=@TypeTest,
                            TestTypeDescription=@Description,
                        TestTypeFees=@Fees where TestTypeID=@ID";
            SqlCommand cmd = new SqlCommand (query, connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@TypeTest", TypeTest);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                connection.Open();
                row=cmd.ExecuteNonQuery ();
            }
            catch
            {  return false; }
            finally {connection.Close(); }
            return row>0;
        }
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from TestTypes ";
            SqlCommand command = new SqlCommand(query, connection);

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
        public static bool GetInfo(int ID ,ref string TestType,ref string Description,ref decimal fees)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"select *from TestTypes where TestTypeID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    TestType = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    fees = (decimal)reader["TestTypeFees"];

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
