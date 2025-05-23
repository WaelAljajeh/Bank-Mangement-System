using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsClientDAL
    {
        public static int AddClient(string AccountNumber, string PIN_Code, int PersonID,string ImagePath)
        {


            int ClientID = -1;
            string connectionstring = clsDataAccessSettings.connectionstring;
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "INSERT INTO Clients (Account_Number,PIN_Code,PersonID,ImagePath)" +
                " VALUES (@Account_Number,@PIN_Code,@PersonID,@ImagePath)" +
                "select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Account_Number", AccountNumber);
            command.Parameters.AddWithValue("PIN_Code", PIN_Code);
            command.Parameters.AddWithValue("PersonID", PersonID);
            if (ImagePath == "")
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("ImagePath", ImagePath);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return ClientID;
        }
        public static bool UpdateClientInfo(int ClientID, string Account_Number, string PIN_Code, string ImagePath)
        {
            int result = 0;
            SqlConnection connect = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query =
            @"Update Clients 
               Set Account_Number=@Account_Number,
                   PIN_Code=@PIN_Code,
                   ImagePath=@ImagePath
                   Where ClientID=@ClientID";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("ClientID", ClientID);
            command.Parameters.AddWithValue("Account_Number", Account_Number);
            command.Parameters.AddWithValue("PIN_Code", PIN_Code);
             if (ImagePath == "")
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("ImagePath", ImagePath);

            try
            {
                connect.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connect.Close(); }
            return result > 0;


        }
        public static bool GetDataByID(int ClientID, ref string Account_Number, ref string PIN_Code,ref int PersonID,ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select * from Clients " +
                "where ClientID=@ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ClientID", ClientID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    Account_Number = Reader["Account_Number"].ToString();
                    PIN_Code = Reader["PIN_Code"].ToString();
                    PersonID = (int)Reader["PersonID"];
                    ImagePath = Reader["ImagePath"].ToString();

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
        public static bool DeleteClient(int ClientID)
        {
            int result = 0;
            //bool IsDelete = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Delete  from Clients
                          Where ClientID=@ClientID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ClientID", ClientID);
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
        public static int GetCountOfClients()
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select Count(ClientID) from Clients";
            SqlCommand command= new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if(Reader.Read())
                {
                    Count = (int)Reader[0];
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error "+ex.ToString()); }
            finally { connection.Close(); }
            return Count;
        }
    }
}
