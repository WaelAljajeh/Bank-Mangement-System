using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsCurrencyDAL
    {
        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select * from Currencies";
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
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally { connection.Close(); }
            return dt;
        }
        public static float FindRatesByCurrencyCode(string currencyCode)
        {
            float Rate = 0;
            //DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select Exchange_Rate from Currencies
                    where Currency_Code=@Currency_Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Currency_Code",currencyCode);
            try
            {
                connection.Open();
                Rate = Convert.ToSingle(command.ExecuteScalar());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally { connection.Close(); }
            return Rate ;
        }
        public static bool FindCurrencyCurrencyCode(string currencyCode,ref float Rate,ref string Country,ref string Currency_name)
        {
            bool IsFound = false;
            //DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Select * from Currencies
                    where Currency_Code=@Currency_Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Currency_Code", currencyCode);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                { 
                    IsFound = true;
                    Rate = Convert.ToSingle(Reader["Exchange_Rate"]) ;
                    Currency_name = Reader["Currency_name"].ToString();
                    Country = Reader["Country"].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally { connection.Close(); }
            return IsFound;
        }

    }
}
