using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_BankProject;
namespace BussinessLayer_BankProject
{
    public class clsPerson
    {
        protected enum enMode { Add=1,Update=2};
        enMode _Mode;
        public int PersonID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        //public string ImagePath {  get; set; }
        public clsPerson(string FirstName, string LastName, string Email,int PersonID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.PersonID = PersonID;
            _Mode = enMode.Update;
            //ImagePath = imagePath;
        }
        public clsPerson() {
            FirstName = "";
            PersonID = -1;
            LastName = "";
            Email = "";
            //ImagePath = "";
            _Mode= enMode.Add;
        }
        bool AddPerson()
        {
            PersonID = clsPersonDAL.AddPerson(FirstName, LastName, Email);
            return PersonID != -1;
        }
        public static int GetIDByPersonInfo(string Email,string FirstName,string LastName)
        {
            return clsPersonDAL.GetIDByPeronInfo(Email,FirstName,LastName);
        }
        protected static clsPerson FindPerson(string Email)
        {
            string FirstName = "",LastName="";int PersonID = -1;
            
             if(clsPersonDAL.GetDataByEmail(Email,ref FirstName,ref LastName,ref PersonID))
             {
                return new clsPerson(Email,FirstName,LastName,PersonID);
             }
             return null;
        }
        protected static clsPerson FindPersonByID(int PersonID)
        {
            string FirstName = "", LastName = "",Email=""; ;
            
            if (clsPersonDAL.GetDataByID(PersonID,ref FirstName,ref LastName,ref Email))
            {
                return new clsPerson(FirstName, LastName, Email,PersonID);
            }
            return null;
        }
        bool UpdatePerosn()
        {
            return clsPersonDAL.UpdatePersonInfo(PersonID,FirstName,LastName,Email);
        }
        virtual public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Add:
                    _Mode=enMode.Update;
                    if (AddPerson()) return true;
                    else
                        return false;
                case enMode.Update:
                    return UpdatePerosn();
                    
            }
            return false;

        }
        public static bool IsEmailExisting(string Email)
        {
           return clsPersonDAL.IsPersonExisting(Email);
        }
        protected static bool DeletePerosn(int PersonID)
        {
            return clsPersonDAL.DeletePeroson(PersonID);
        }


       
    }
}
