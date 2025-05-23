using DataAccessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_BankProject
{
    public class clsBankSystem
    {
        clsClient Client=new clsClient();
        clsAccount Account=new clsAccount();
        enum enMode {Add=1,Update=2}
        enMode _Mode;
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string AccountNumber {  get; set; }
        public string PIN { get; set; }
        public int ClientID {  get; set; }
        public string ImageFilePath {  get; set; }
        public int PersonID {  get; set; }
        public float Balance {  get; set; }
        public clsBankSystem()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            AccountNumber = "";
            PIN = "";
            ClientID = -1;
            ImageFilePath = "";
            PersonID= -1;
            Balance = 0;
            _Mode = enMode.Add;
        }
        clsBankSystem(clsClient Client,clsAccount Acouunt)
        {
            this.Account = Acouunt;
            this.Client=Client;
            this.FirstName = Client.FirstName;
            this.LastName = Client.LastName;
            this.Email = Client.Email;
            this.AccountNumber = Client.AccountNumber;
            this.PIN = Client.PIN_Code;
            this.ClientID = Client.ClientID;
            this.ImageFilePath = Client.ImagePath;
            this.PersonID = Client.PersonID;
            this.Balance=Account.Balance;
            _Mode = enMode.Update;

        }
        clsBankSystem(string firstName, string lastName, string email, string accountNumber, string pIN, int clientID, string imageFilePath, int personID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            AccountNumber = accountNumber;
            PIN = pIN;
            ClientID = clientID;
            ImageFilePath = imageFilePath;
            PersonID = personID;
            _Mode= enMode.Update;
        }

        bool AddClient()
        {
           
            Client = new clsClient();
            Client.FirstName = FirstName;
            Client.LastName = LastName;
            Client.Email = Email;
            Client.AccountNumber = AccountNumber;
            Client.PIN_Code = PIN;
            Client.PersonID = PersonID;
           
            if (Client.Save())
            {
                ClientID = Client.ClientID;
                return true;

            
            }
            return false;

        }
        bool AddNewClientAccount()
        {
     
            if (AddClient())
            {
                Account = new clsAccount();
                Account.Account_Number = AccountNumber;
                Account.Account_Status = "active";
                Account.ClientID = ClientID;
                Account.Balance = this.Balance;
                if (Account.Save())
                {
                    return true;
                }
            }
            return false;
            
        }
        public static DataTable GetData()
        {
            DataTable dt = clsDataAccessBank.GetAllAccounts();
            return dt;
        }
        public static clsBankSystem FindInfo(int ClientID)
        {
            clsClient Client = new clsClient();
            clsAccount Account = new clsAccount();
            //string FirstName = "", LastName = "", Email = "", Account_Number, PIN_Code;
            Client = clsClient.FindClientByID(ClientID);
            Account=clsAccount.FindAccount(ClientID);
            if(Client!=null)
            {
            
                return new clsBankSystem(Client,Account);
            }
            return null;
            
            
        }
        void UpdateAccountClientInfo(ref clsClient Client,ref clsAccount Account)
        {
            Client.FirstName = FirstName; Client.LastName=LastName;
            Client.Email = Email;
            Client.AccountNumber = AccountNumber;
            Account.Account_Number=AccountNumber;
            Client.ImagePath = ImageFilePath;
            Client.PIN_Code = PIN;
            
        }
        bool UpdateClientAccount()
        {
            
            if (Client != null && Account != null) 
            {
                UpdateAccountClientInfo(ref Client, ref Account);
                return Client.Save() && Account.Save();
            }
            return false;


        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    _Mode = enMode.Update;
                    return AddNewClientAccount();

                case enMode.Update:
                    return UpdateClientAccount();
                    
            }
            return false;
        }
        public static bool DeleteClientAccount(int ClientAccountID)
        {
         
            return clsAccount.DeleteAccount(ClientAccountID) && clsClient.DeleteClient(ClientAccountID) ;
        }
    }
}
