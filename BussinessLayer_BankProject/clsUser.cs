using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_BankProject;
using Microsoft.SqlServer.Server;
namespace BussinessLayer_BankProject
{
    public class clsUser : clsPerson
    {
        enMode _Mode;
        public enum enPermission { eAll=-1, pShowClientList = 1, PAddNewClient = 2, PDeleteClient = 4, PUpdateClient = 8, PFindClient = 16, PTrans = 32, PRegisterLogin = 64, PCurrecy = 128, PMangeUser = 256 
        };
        enPermission permission;
        
    
        public int UserID {  get; set; }
        public string Username {  get; set; }
        public string Password { get; set; }
        public float Salary {  get; set;  }
        public int Permission {  get; set; }
        public string ImagePath {  get; set; }
        public clsUser() 
        {
            _Mode = enMode.Add;
            FirstName = "";
            LastName = "";
            Email = "";
            ImagePath = "";
            UserID = -1;
            Username = "";
            Password = "";
            Salary = 0; 
            Permission = 0;
            PersonID=-1;
        }
        clsUser(string FirstName,string LastName,string Email,int PersonID,string ImagePath,int UserID,string Username,string Password, float Salary, int Permission)
        :base(FirstName, LastName, Email, PersonID)
        {
            this.UserID= UserID;
            this.Username= Username;
            this.Password= Password;
            this.Salary= Salary;
            this.Permission = Permission;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;

        }
        bool AddNewUser()
        {
           UserID=clsUserDAL.AddNewUser(Username, clsEnryption.EncryptPassword(Password,Password.Length),Salary,Permission,PersonID,ImagePath);
            return UserID != -1;
        }
       public  bool CheckPermission(enPermission Permission)
        {
            if(Permission == enPermission.eAll)
            { return true; }
            if(((int)Permission&this.Permission)==(int)Permission)
            {
                return true;
            }
            return false;

        }
        bool UpdateUser()
        {
            return clsUserDAL.UpdateUsers(UserID, Username,clsEnryption.EncryptPassword(Password,Password.Length), Salary, Permission, ImagePath);
        }
       public static bool DeleteUser(int UserID)
        {
            return clsUserDAL.DeleteUser(UserID);
        }
       public static bool IsUserExisting(string Username,string Password)
        {
            return clsUserDAL.IsUserExisting(Username,clsEnryption.EncryptPassword(Password,Password.Length));
        }
        public static DataTable GetUserData()
        {
            DataTable dataTable=clsUserDAL.GetDataFromUserAndPerosn();
            foreach (DataRow row in dataTable.Rows)
            {
                row["Password"] = clsEnryption.DecryptPassword(row["Password"].ToString(), row["Password"].ToString().Length);

            }
            return dataTable;
        }
       public static clsUser FindUserByID(int UserID)
        {
            string FirstName = "", LastName = "", Email = "", ImagePath = "";
            string Username = "",Password="";
            float Salary = 0;int Permission = 0; int PersonID=-1;
            if (clsUserDAL.GetDataByID(UserID,ref Username,ref Password,ref Salary, ref Permission, ref PersonID,ref ImagePath)) 
            {
                Password = clsEnryption.DecryptPassword(Password, Password.Length);
                clsPerson Person = clsPerson.FindPersonByID(PersonID);
                FirstName = Person.FirstName; LastName = Person.LastName;
                Email = Person.Email;
                
                return new clsUser(FirstName, LastName, Email,PersonID, ImagePath,UserID,Username,Password,Salary,Permission);
            }
            return null;
        }
        public static clsUser FindUserByUsernameandPassword(string Username,string Password)
        {
            string FirstName = "", LastName = "", Email = "", ImagePath = "";
            int UserID = -1;
            float Salary = 0; int Permission = 0; int PersonID = -1;
            if (clsUserDAL.GetDataByUsernameAndPassword(Username,clsEnryption.EncryptPassword(Password,Password.Length),ref UserID,ref Salary,ref Permission,ref PersonID,ref ImagePath))
            {
                clsPerson Person = clsPerson.FindPersonByID(PersonID);
                FirstName = Person.FirstName; LastName = Person.LastName;
                Email = Person.Email;
                
                return new clsUser(FirstName, LastName, Email, PersonID, ImagePath, UserID, Username, Password, Salary, Permission);
            }
            return null;
        }

        public override bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    if (!base.Save())
                    {

                        return false;
                    }
                    _Mode = enMode.Update;
                    return AddNewUser();
                case enMode.Update:
                    return base.Save()&&UpdateUser();
            }
            return false;
        }
        public static int GetUserCount()
        {
            return clsUserDAL.GetUsersCount();
        }
        public static float GetAllSalaries()
        {
            return clsUserDAL.GetAllSalaries();
        }

    }
}
