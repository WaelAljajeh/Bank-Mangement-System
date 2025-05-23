using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_BankProject
{
    public class clsUserDAL
    {
        public static int AddNewUser(string Username,string Password,float Salary,int Permission,int PersonID,string ImagePath)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query =
                @"INSERT INTO Users
           (
            Username
            ,Password
            ,Salary
           ,Permission
           ,PersonID
           ,ImagePath)
     VALUES
           (
            @Username
            ,@Password
            ,@Salary
           ,@Permission
           ,@PersonID
           ,@ImagePath)
           select SCOPE_IDENTITY();";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Username",Username);
            command.Parameters.AddWithValue("Password",Password);
            command.Parameters.AddWithValue("Salary", Salary);
            command.Parameters.AddWithValue("Permission", Permission);
            command.Parameters.AddWithValue("PersonID", PersonID);
            if (ImagePath == "")
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("ImagePath", ImagePath);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result!=null&&int.TryParse(result.ToString(),out int InsertedID))
                {
                    UserID = InsertedID;
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
            return UserID;
        }
        public static DataTable GetDataFromUserAndPerosn()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select U.UserID,P.* ,U.Username,U.Password,U.Salary,U.Permission from Users U
                             inner join Persons P on U.PersonID=P.PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            //  command.Parameters.AddWithValue("Account_Number",AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);


                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return dt;
        }
        public static bool UpdateUsers(int UserID, string Username, string Password, float Salary,int Permission,string ImagePath)
        {
            int result = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Update Users 
                            Set Username=@Username,
                             Password=@Password ,
                              Salary=@Salary,
                              Permission=@Permission,
                              ImagePath=@ImagePath
                               Where UserID=@UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("Salary", Salary);
            command.Parameters.AddWithValue("Permission", Permission);
            if (ImagePath == "")
                command.Parameters.AddWithValue("ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("ImagePath", ImagePath);
            try
            {
                connection.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return result > 0;
        }
        public static bool GetDataByID(int UserID,ref string Username,ref string Password,ref float Salary,ref int Permission,ref int PersonID,ref string ImagePath)
        {
            bool IsFound=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from Users 
                         where UserID=@UserID";
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if(Reader.Read())
                {
                    IsFound= true;
                    Username = Reader["Username"].ToString();
                    Password = Reader["Password"].ToString();
                    Salary =   Convert.ToSingle(Reader["Salary"]);
                    Permission = (int)Reader["Permission"];
                    PersonID = (int)Reader["PersonID"];
                    ImagePath = Reader["ImagePath"].ToString();

                }
                Reader.Close();
            }
            catch(Exception ex) { Console.WriteLine("Error "+ex.ToString()); }
            finally{ connection.Close(); }
            return IsFound;
        }
        public static bool DeleteUser(int UserID)
        {

            int result = 0;
            //bool IsDelete = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"Delete  from Users
                          Where UserID=@UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
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
        public static bool GetDataByUsernameAndPassword(string Username, string Password,ref int UserID, ref float Salary, ref int Permission,ref int PersonID,ref string ImagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from Users 
                         where Username=@Username
                         and Password=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Username", Username);
            command.Parameters.AddWithValue ("Password", Password);

            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    Salary = 0;
                    Permission = (int)Reader["Permission"];
                    PersonID = (int)Reader["PersonID"];
                    ImagePath = Reader["ImagePath"].ToString();


                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool IsUserExisting(string Username,string Password)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from Users 
                         where Username=@Username
                         and Password=@Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Username", Username.Trim());
            command.Parameters.AddWithValue("Password", Password.Trim());
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
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return IsFound;
        }
        public static int GetUsersCount()
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select Count(UserID) from Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    Count = (int)Reader[0];
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return Count;
        }
        public static float GetAllSalaries()
        {
            float Salary = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select Sum(Salary) from Users";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    Salary = Convert.ToSingle(Reader[0]);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error " + ex.ToString()); }
            finally { connection.Close(); }
            return Salary;
        }


    }
}
