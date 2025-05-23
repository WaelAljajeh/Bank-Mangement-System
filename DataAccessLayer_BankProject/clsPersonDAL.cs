using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsPersonDAL
    {

        public static int AddPerson(string FirstName ,string LastName,string Email)
        {
            int PersonID = -1;
            string connectionstring=clsDataAccessSettings.connectionstring;
            SqlConnection connection=new SqlConnection(connectionstring);
            string query = @"INSERT INTO Persons (FirstName,LastName,Email) 
                VALUES (@FirstName,@LastName,@Email)
                select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue ("LastName", LastName);
            command.Parameters.AddWithValue("Email", Email);
         
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }
        public static bool GetDataByID(int PersonID,ref string FirstName,ref string LastName,ref string Email)
        {
           bool IsFound = false;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select * from Persons " +
                "where PersonID=@PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID",PersonID);
            try 
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = Reader["FirstName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    Email = Reader["Email"].ToString();
                    

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ex.ToString());
            }
            finally
            { connection.Close(); }
            return IsFound;
        }
        public static bool GetDataByEmail(string Email, ref string FirstName, ref string LastName, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select * from Persons " +
                "where Email=@Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Email", Email);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = Reader["FirstName"].ToString();
                    LastName = Reader["LastName"].ToString();
                    PersonID = (int)Reader["PersonID"];
                    

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return IsFound;
        }
        public static int GetIDByPeronInfo(string Email,string FirstName,string LastName)
        {

            int PersonID = -1;
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
                string query = "Select * from Persons " +
                    "where Email=@Email and FirstName=@FirstName and LastName=@LastName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("Email", Email);
                command.Parameters.AddWithValue("FirstName", FirstName);
                command.Parameters.AddWithValue("LastName", LastName);
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        
                        
                        PersonID = (int)Reader["PersonID"];

                    }
                Reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.ToString());
                }
                finally
                { connection.Close(); }
            return PersonID;
            }
        
        public static bool IsPersonExisting(string Email)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select * from Persons " +
                "where Email=@Email";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Email", Email);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    IsFound = true;

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
                IsFound = false;
            }
            finally
            { connection.Close(); }
            return IsFound;
        }
        public static bool UpdatePersonInfo(int PersonID,string FirstName,string LastName,string Email)
        {
            int result = 0;
             
            SqlConnection connection = new SqlConnection( clsDataAccessSettings.connectionstring);
            string query = @"Update Persons 
                            Set FirstName=@FirstName,
                             LastName=@LastName ,
                              Email=@Email
                               Where PersonID=@PersonID";
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Email", Email);
        
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
                
            }
            catch (Exception ex) { Console.WriteLine("Error "+ex.ToString()); }
            finally { connection.Close(); }
            return result > 0;
        }
        public static bool DeletePeroson(int PersonID)
        {

            int result = 0;
            //bool IsDelete = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Delete  from Persons
                          Where PersonID=@PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID",PersonID);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally
            {
                connection.Close();
            }
            return result > 0;
           
        }

    }
}
