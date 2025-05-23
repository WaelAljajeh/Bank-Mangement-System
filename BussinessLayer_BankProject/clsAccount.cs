using DataAccessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BussinessLayer_BankProject
{
    public class clsAccount
    {
        enum enMode { Add=1,Update=2}
        enMode _Mode;
       public string Account_Number {  get; set; }
       public int Account_ID { get; set; }
       public string Account_Status {  get; set; }
       public int ClientID {  get; set; } 
       public float Balance {  get; set; }
        clsAccount(string Account_Number,int Account_ID,string AccountStatus,int ClientID,float Balance) 
        {
            this.Account_Number=Account_Number;
            this.Account_ID=Account_ID;
            this.Account_Status=AccountStatus;
            this.ClientID=ClientID;
            this.Balance=Balance;
            _Mode = enMode.Update;
        }
        public clsAccount()
        {
            Account_Number = "";
            Account_ID = -1;
            Account_Status = "";
            ClientID = -1;
            Balance = 0;
            _Mode= enMode.Add;
        }
        bool AddAccount()
        {
            Account_ID=clsAccountDAL.AddAccount(Account_Number,Account_Status,ClientID,Balance);
            return Account_ID!=-1;
            
        }
        public static clsAccount FindAccount(int AccountID)
        {
            string Account_Number = "";
            float Balance = 0;
            if(clsAccountDAL.GetDataByID(AccountID,ref Account_Number,ref Balance))
            {
                return new clsAccount(Account_Number, AccountID, "active", AccountID, Balance);
            }
            return null; 
        }
        bool UpdateAccount()
        {
            return clsAccountDAL.UpdateAccountInfo(Account_ID, Account_Number, Balance);
        }
      public  bool Deposit(float Amount)
        {
           if(clsAccountDAL.UpdateBalanceByID(Account_ID,Balance,Amount))
            {
                Balance = Balance + Amount;
                return true;
            }
            return false;
        }
       public bool Transfer(float amount, ref clsAccount ToAccount )
        {
            if (amount > this.Balance)
                return false;
            else
            {
                return Withdraw(amount)
                &&ToAccount.Deposit(amount);
                //return true;
            }
        }
        public bool Withdraw(float Amount)
        {
            Amount = Amount * -1;
            return Deposit(Amount);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    _Mode = enMode.Update;
                    if (AddAccount())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                case enMode.Update:
                   return UpdateAccount();
                    
            }
            return false;
        }
        public static bool DeleteAccount(int AccountID)
        {
            return clsAccountDAL.DeleteAccount(AccountID);
        }
        public static bool IsAccountNumberExisting(string AccountNumber)
        {
            return clsAccountDAL.GetDataByAccountNumber(AccountNumber);
        }
        public static float GetSumOfBalances()
        {
            return clsAccountDAL.GetSumOfBalances();
        }
        public static clsAccount GetBalanceAndIDByNumber(string AccountNumber)
        {
            float Balance = 0;
            int AccountID = -1;
            if(clsAccountDAL.GetBalanceAndIDByNumber(AccountNumber,ref AccountID,ref Balance))
            {
                return new clsAccount(AccountNumber, AccountID, "active", AccountID, Balance);
            }
            return null;
        }
    }
}
