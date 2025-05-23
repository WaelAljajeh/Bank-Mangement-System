using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsAccountDAL
    {
        public static int AddAccount(string AccountNumber, string AccountStatus, int ClientID,float Balance)
        {
            int AccountID = -1;
            string connectionstring = clsDataAccessSettings.connectionstring;
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "INSERT INTO Accounts           (Account_Number,Account_Status,ClientID,Balance,CreatedAt)  " +
                "VALUES          (@Account_Number,@Account_Status,@ClientID,@Balance,@CreatedAt)" +
                "select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Account_Number", AccountNumber);
            command.Parameters.AddWithValue("Account_Status", AccountStatus);
            command.Parameters.AddWithValue("ClientID", ClientID);
            command.Parameters.AddWithValue("Balance", Balance);
            command.Parameters.AddWithValue("CreatedAt",DateTime.Now);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    AccountID = InsertedID;
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

            return AccountID;
        }
        public static bool UpdateAccountInfo(int AccountID, string Account_Number,float Balance)
        {

            int result = 0;
            SqlConnection connect = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query =
            @"Update Accounts 
               Set Account_Number=@Account_Number
                   ,Balance=@Balance
                   Where AccountID=@AccountID";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("Account_Number", Account_Number);
            command.Parameters.AddWithValue("AccountID", AccountID);
            command.Parameters.AddWithValue("Balance", Balance);
            try
            {
                connect.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connect.Close(); }
            return result > 0;
        }
        public static bool GetDataByID(int AccountID, ref string Account_Number,ref float Balance)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select * from Accounts
                where AccountID=@AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    Account_Number = Reader["Account_Number"].ToString();
                    Balance = Convert.ToSingle(Reader["Balance"]);


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
        public static bool DeleteAccount(int AccountID)
        {
            int result = 0;
            //bool IsDelete = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Delete  from Accounts
                          Where AccountID=@AccountID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("AccountID", AccountID);
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
        public static bool GetDataByAccountNumber(string Account_Number)
        {
            int AccountID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select * from Accounts
                where Account_Number=@Account_Number";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Account_Number", Account_Number);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    
                    AccountID = (int)Reader["AccountID"];

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return AccountID!=-1;
        }
        public static float GetSumOfBalances()
        {
            float Balance = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select Sum(Balance) from Accounts";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    Balance = Convert.ToSingle(Reader[0]);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return Balance;
        }
        public static bool UpdateBalanceByID(int AccountID,float Balance,float Amount)
        {
            int result = 0;
            SqlConnection connect = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query =
            @"Update Accounts 
               Set Balance=@Balance+@Amount
                   Where AccountID=@AccountID";
            SqlCommand command = new SqlCommand(query, connect);
            command.Parameters.AddWithValue("AccountID", AccountID);
            command.Parameters.AddWithValue("Balance", Balance);
            command.Parameters.AddWithValue("Amount", Amount);
            try
            {
                connect.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connect.Close(); }
            return result > 0;
        }
        public static bool GetBalanceAndIDByNumber(string Account_Number, ref int AccountID, ref float Balance)
        {
            bool IsFound = false; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select * from Accounts
                where Account_Number=@Account_Number";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Account_Number", Account_Number);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    AccountID = (int)Reader["AccountID"];
                    Balance = Convert.ToSingle(Reader["Balance"]);

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
    }
}
