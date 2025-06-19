using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class clsDataPeople
    {
        public static int AddPerson(string FirstName, string SecondName, string thirdName, string lastName
            , string phone, byte Gender, string National, string Email, int CountryID, string Address,
            DateTime birthDate, string ImagePath)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"INSERT INTO People(NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth
            ,Gendor,Address,Phone,Email,NationalityCountryID,ImagePath)VALUES(@National,@FirstName,
              @SecondName,@thirdName,@lastName,@birthDate,@Gender,@Address,@Phone,@Email,@CountryID,@ImagePath);
             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@National", National);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            //command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                //command.ExecuteNonQuery();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }

            return PersonID;


        }
        public static bool UpdatePeople(int ID, string FirstName, string SecondName, string thirdName, string lastName
            , string phone, int Gender, string National, string Email, int CountryID, string Address,
            DateTime birthDate, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"UPDATE People 
                                set NationalNo=@National,
                                     FirstName=@FirstName,
                                        SecondName=@SecondName,ThirdName=@thirdName,
                                        LastName=@lastName,
                                        DateOfBirth=@birthDate,
                                        Gendor=@Gender,
                                        Address=@Address,
                                        Email=@Email,
                                        NationalityCountryID=@CountryID,
                                        ImagePath=@ImagePath
                                        where PersonID=@ID
                                        ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@National", National);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@thirdName", thirdName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@birthDate", birthDate);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            int RowsEfected = 0;
            try
            {
                connection.Open();
                RowsEfected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return RowsEfected > 0;
        }
        public static bool GetInfoByID(int ID, ref string FirstName, ref string SecondName, ref string thirdName, ref string lastName
            , ref string phone, ref byte Gender, ref string National, ref string Email, ref int CountryID, ref string Address,
            ref DateTime birthDate, ref string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT * from People where PersonID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    National = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    birthDate = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    CountryID = (int)reader["NationalityCountryID"];
                    Email = (string)reader["Email"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = " ";
                    }

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static bool GetInfoByName(string FirstName, ref int ID, ref string SecondName, ref string thirdName, ref string lastName
            , ref string phone, ref byte Gender, ref string National, ref string Email, ref int CountryID, ref string Address,
            ref DateTime birthDate, ref string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT * from People where FirstName=@FirstName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["PersonID"];
                    National = (string)reader["NationalNo"];
                    SecondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    birthDate = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    CountryID = (int)reader["NationalityCountryID"];
                    Email = (string)reader["Email"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = " ";
                    }

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;
        }public static bool GetInfoByNational(string National,ref string FirstName, ref int ID, ref string SecondName, ref string thirdName, ref string lastName
            , ref string phone, ref byte Gender, ref string Email, ref int CountryID, ref string Address,
            ref DateTime birthDate, ref string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT * from People where NationalNo=@National";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@National", National);
            bool isFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    ID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    birthDate = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Email = (string)reader["Email"];
                    Address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    CountryID = (int)reader["NationalityCountryID"];
                    Email = (string)reader["Email"];
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = " ";
                    }

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally { connection.Close(); }
            return isFound;
        }
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);

            string query = @"SELECT *from People";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch { }
            finally { connection.Close(); }
            return dt;
        }
        public static bool IsExist(int ID)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"SELECT found=1 from People where PersonID=@ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                isExist = false;
            }
            finally { connection.Close(); }
            return isExist;
        } 
        public static bool IsExistByNational(string  National)
        {
            bool isExist = false;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"SELECT found=1 from People where NationalNo=@National";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@National", National);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                reader.Close();
            }
            catch (Exception e)
            {
                isExist = false;
            }
            finally { connection.Close(); }
            return isExist;
        }
        public static bool DeletePeople(int ID)
        {
            int rowsAffcted = 0;
            SqlConnection connection = new SqlConnection(clsConnection.ConnectionString);
            string query = @"delete People where PersonID=@ID";
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
    }
}
