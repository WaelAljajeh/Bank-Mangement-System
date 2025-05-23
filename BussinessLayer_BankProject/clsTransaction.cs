using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_BankProject;
namespace BussinessLayer_BankProject
{
    public class clsTransaction
    {
        public  enum enTransType {Transaction=1,WithDraw=2,Deposite=3};
        public enTransType TransType { get; set; }
        public enum enTransStatus {Success=0,Failed=1};
        public enTransStatus Status { get; set; }
       public int from_AccountID { get; set; }
       public int To_AccountID { get; set; }
       public int UserID { get; set; }
        public int ClientID { get; set; }
       public float Amount {  get; set; }
        public float balance_after_transaction {  get; set; }
        public clsTransaction()
        {
            from_AccountID = -1;
            To_AccountID = -1;
            UserID = -1; ClientID = -1;
            Amount = 0;
            balance_after_transaction = 0;

        }
        clsTransaction(int from_AccountID, int to_AccountID, int userID, int clientID, float amount, float balance_after_transaction)
        {
            this.from_AccountID = from_AccountID;
            To_AccountID = to_AccountID;
            UserID = userID;
            ClientID = clientID;
            Amount = amount;
            this.balance_after_transaction = balance_after_transaction;
        }
       public bool AddNewTransaction()
       {
            return clsTransactionDAL.AddNewTransaction(from_AccountID, To_AccountID, UserID, ClientID, Amount, balance_after_transaction, TransType.ToString(), Status.ToString());
       }
        public bool Deposit(clsAccount Account)
        {
            if (Amount <= 0)
            {
                //Trans.Status = clsTransaction.enTransStatus.Failed;
                //Trans.AddNewTransaction();
                return false;
            }

            if (!Account.Deposit(Amount))
            {
                this.Status = clsTransaction.enTransStatus.Failed;
            }
            this.Status = clsTransaction.enTransStatus.Success;
            return AddNewTransaction();

        }
        public bool Transfer(clsAccount FromAccount,clsAccount ToAccount)
        {
            return FromAccount.Transfer(Amount,ref ToAccount)&&AddNewTransaction();
        }
        public static DataTable GetTransLogs()
        {
            return clsTransactionDAL.GetTransLogs();
        }
        public static int GetTransactionCountPerDays(int Day,string TransType)
        {
            return clsTransactionDAL.GetTransactionsCount(Day,TransType);
        }
        public bool Withdraw(clsAccount Account)
        {
            if (Amount > Account.Balance)
            {
                this.Status= clsTransaction.enTransStatus.Failed;
                AddNewTransaction();
                return false;
            }
            else
            {
                if (!Account.Withdraw(Amount))
                {
                    return false;
                }

            }
            return AddNewTransaction() ;    
          
         
        }

    }
}
