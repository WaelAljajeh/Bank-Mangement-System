using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsUserLogsDAL
    {
        public static bool AddLogWhenUserLoginSuccessfuly(int UserID,DateTime Time)
        {
            int LogID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"INSERT INTO UserLogs
           (LogDate
           ,UserID)
     VALUES
           (@LogDate
           ,@UserID)
            select SCOPE_IDENTITY()"
             ;
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("UserId", UserID);
            command.Parameters.AddWithValue("LogDate", Time);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    LogID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return LogID != -1;
        }
        public static DataTable GetAllUserLogs()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select UL.LogID,U.*,UL.LogDate from UserLogs UL  
               inner join Users U on UL.UserID=U.UserID ";
            SqlCommand command = new SqlCommand(query,connection);
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
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ex.ToString());
            }
            finally { connection.Close(); }
            return dt;
        }
        public static int GetCountUsersLogsSuccess(DateTime NowDate)
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select Count(LogID) from UserLogs
                Where Day(LogDate)=@DayOfMonth and Year(LogDate)=@Year and Month(LogDate)=@Month";
            ;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("DayOfMonth", NowDate.Day);
            command.Parameters.AddWithValue("Year", NowDate.Year);
            command.Parameters.AddWithValue("Month", NowDate.Month);
            //command.Parameters.AddWithValue("transaction_type", TransType);
            try
            {
                connection.Open();
                Count = (int)command.ExecuteScalar();
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
