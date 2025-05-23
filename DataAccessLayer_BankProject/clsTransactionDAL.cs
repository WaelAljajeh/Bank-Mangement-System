using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsTransactionDAL
    {

       public static bool AddNewTransaction(int from_AccountID,int To_AccountID,int UserID,int ClientID,float Amount,float balance_after_transaction,string transaction_type,string status)
        {
            int TransID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "INSERT INTO Transactions (from_AccountID,To_AccountID,UserID,ClientID,Amount,balance_after_transaction,transaction_type,status,Transfer_Date)  " +
                "VALUES (@from_AccountID,@To_AccountID,@UserID,@ClientID,@Amount,@balance_after_transaction,@transaction_type,@status,@Transfer_Date)" +
                "select SCOPE_IDENTITY();" ;
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("from_AccountID", from_AccountID);
            command.Parameters.AddWithValue("To_AccountID", To_AccountID);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("ClientID", ClientID);
            command.Parameters.AddWithValue("Amount", Amount);
            command.Parameters.AddWithValue("balance_after_transaction", balance_after_transaction);
            command.Parameters.AddWithValue("transaction_type", transaction_type);
            command.Parameters.AddWithValue("status", status);
            command.Parameters.AddWithValue("Transfer_Date", DateTime.Now);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    TransID = InsertedID;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error "+ex.ToString());
            }
            finally
          { connection.Close(); }
            return TransID != -1;
        }
        public static DataTable GetTransLogs()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select * from Transactions";
            SqlCommand command=new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader=command.ExecuteReader();
                if(Reader.HasRows)
                {
                    dataTable.Load(Reader);
                }
                Reader.Close();
            }
            catch(Exception ex) { Console.WriteLine("Error " +ex.ToString()); }
            finally { connection.Close(); }
            return dataTable;
        }
        public static int GetTransactionsCount(int Day,string TransType)
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select Count(TransactionID) from Transactions
                Where Day(Transfer_Date)=@DayOfMonth and transaction_type=@transaction_type";
                ;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("DayOfMonth", Day);
            command.Parameters.AddWithValue("transaction_type", TransType);
            try
            {
                connection.Open();
                Count=(int)command.ExecuteScalar();
                //SqlDataReader Reader = command.ExecuteReader();
                //if (Reader.Read())
                //{
                //    Count = (int)Reader[0];
                //}
                //Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return Count;
        }
    }
}
