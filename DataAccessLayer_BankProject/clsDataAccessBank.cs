using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsDataAccessBank
    {
        public static DataTable GetAllAccounts()
        {
            //bool IsFound = false;
            DataTable result = new DataTable();
                SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"
          SELECT  p.*,c.ClientID,a.AccountID,a.Account_Number,a.Balance,a.Account_Status
          FROM Accounts a
          INNER JOIN Clients c ON a.ClientID = c.ClientID 
          INNER JOIN Persons p ON c.PersonID = p.PersonID
          
";
            SqlCommand command = new SqlCommand(query, connection);
          //  command.Parameters.AddWithValue("Account_Number",AccountNumber);
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.HasRows)
                    {
                        result.Load(Reader);
                        

                    }
                    Reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error " + ex.ToString());
                }
                finally
                { connection.Close(); }
            return result;
                //return IsFound;
            }
        
     //   static int AddAccount(string AccountNumber,int ClientID)
     //   {
     //       int AccountID = -1;
     //       string connectionstring = clsDataAccessSettings.connectionstring;
     //       SqlConnection connection = new SqlConnection(connectionstring);
   
     //       string query = @"INSERT INTO Accounts
     //       (
     //        Account_Number
     //      , Account_Status
     //      , ClientID)
     //VALUES
     //      (
     //      @Account_Number
     //      ,@Account_Status
     //      ,@ClientID)
     //   select SCOPE_IDENTITY();";
     //       SqlCommand command = new SqlCommand(query, connection);
     //       command.Parameters.AddWithValue("Account_Number", AccountNumber);
     //       command.Parameters.AddWithValue("Account_Status","active");
     //       command.Parameters.AddWithValue("ClientID", ClientID);
     //       try
     //       {
     //           connection.Open();
     //           object result = command.ExecuteScalar();
     //           if (result != null && int.TryParse(result.ToString(), out int InsertedID))
     //           {
     //               AccountID = InsertedID;
     //           }

     //       }
     //       catch (Exception ex)
     //       {
     //           Console.WriteLine("Error " + ex.ToString());
     //       }
     //       finally
     //       {
     //           connection.Close();
     //       }
     //       return AccountID;
     //   }
     //  public static int AddClient(string FirstName,string LastName,string Email,string AccountNumber,string PIN_Code)
     //   {
     //       clsPersonDAL person = new clsPerson(FirstName,LastName,Email);
     //       int PersonID = person.AddPerson();
     //       if(PersonID ==-1)
     //       {
     //           return -1;
     //       }
     //       int ClientID = -1;
     //       string connectionstring = clsDataAccessSettings.connectionstring;
     //       SqlConnection connection = new SqlConnection(connectionstring);
     //       string query = "INSERT INTO Clients (Account_Number,PIN_Code,ImagePath,PersonID)" +
     //           " VALUES (@Account_Number,@PIN_Code,@ImagePath,@PersonID)" +
     //           "select SCOPE_IDENTITY();";
     //       SqlCommand command = new SqlCommand(query, connection);
     //       command.Parameters.AddWithValue("Account_Number", AccountNumber);
     //       command.Parameters.AddWithValue("PIN_Code", PIN_Code);
     //       command.Parameters.AddWithValue("PersonID",PersonID);
     //       command.Parameters.AddWithValue("ImagePath",DBNull.Value);
     //       try
     //       {
     //           connection.Open();
     //           object result = command.ExecuteScalar();
     //           if (result != null && int.TryParse(result.ToString(), out int InsertedID))
     //           {
     //               ClientID = InsertedID;
     //           }

     //       }
     //       catch (Exception ex)
     //       {
     //           Console.WriteLine("Error " + ex.ToString());
     //       }
     //       finally
     //       {
     //           connection.Close();
     //       }
     //       int AccountID = AddAccount(AccountNumber, ClientID);
     //       if (AccountID == -1)
     //           return -1;
     //       return ClientID;
     //   }

    }
    }

