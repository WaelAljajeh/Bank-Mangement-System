using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_BankProject;
namespace BussinessLayer_BankProject
{
    
    public class clsClient:clsPerson
    {
        enMode _Mode;
        
       public int ClientID { get; set; }
       public  string AccountNumber { get; set; }
       public string PIN_Code { get; set; }
       public string ImagePath {  get; set; }
       
        clsClient(int ClientID,string FirstName,string LastName,string Email,string AccountNumber,string PIN_Code,string ImagePath,int PersonID):base(FirstName,LastName,Email,PersonID) {
            this.ClientID = ClientID;
            this.AccountNumber = AccountNumber;
        this.PIN_Code = PIN_Code;
         this.ImagePath = ImagePath;
        
            _Mode = enMode.Update;
        }
        public clsClient()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            AccountNumber = "";
            PIN_Code = "";
            ClientID = -1;
            PersonID = -1;
            ImagePath = "";
            _Mode=enMode.Add;
        }
        
        bool AddClient()
        {

           ClientID= clsClientDAL.AddClient(this.AccountNumber,this.PIN_Code,this.PersonID,this.ImagePath);
           return ClientID!=-1;
        }
        bool UpdateClient()
        {
            return clsClientDAL.UpdateClientInfo(ClientID, AccountNumber, PIN_Code, ImagePath);
        }
        public override bool Save()
        {
            
           
            switch(_Mode)
            {
                case enMode.Add:
                    if (PersonID == -1)
                    {
                        if (!base.Save())
                        {

                            return false;
                        }
                    }
                    _Mode = enMode.Update; 
                    if(AddClient())
                    {
                        return true;
                    }
                    
                    else
                    {
                        return false;
                    }
                    
                case enMode.Update:
                    
                    return base.Save()&&UpdateClient();
                   
            }
            return false;
        }
        public static clsClient FindClientByID(int ClientID)
        {
            string FirstName = "", LastName = "", Email = "",ImagePath="";
            int PersonID = -1;
            string Account_Number = "", PIN_Code = "";
            if(clsClientDAL.GetDataByID(ClientID,ref Account_Number,ref PIN_Code,ref PersonID,ref ImagePath))
            {
                 clsPerson Person= clsPerson.FindPersonByID(PersonID);
                FirstName=Person.FirstName; LastName=Person.LastName;
                Email = Person.Email;
                 
                
                return new clsClient(ClientID,FirstName,LastName,Email,Account_Number,PIN_Code,ImagePath,PersonID);
             
                
            }
            return null;
        }
        public static bool DeleteClient(int ClientID)
        {
            return clsClientDAL.DeleteClient(ClientID);
        }
        public static int GetCountOfClients()
        {
            return clsClientDAL.GetCountOfClients();
        }   
    }
}
