using DataAccessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_BankProject
{
    public class clsUserLogs
    {
        
        DateTime Time { get; set; }
       public int UserID {  get; set; }
        public clsUserLogs() {
            Time = DateTime.Now;
            UserID = -1;
        }
        public static DataTable GetUsersLogs()
        {
            return clsUserLogsDAL.GetAllUserLogs();
        }
        public bool AddNewUserLogsWhenUserLoginSuccesfuly()
        {
            return clsUserLogsDAL.AddLogWhenUserLoginSuccessfuly(UserID,Time);
        }
        public static int GetHowManyUsersLogin()
        {
            return clsUserLogsDAL.GetCountUsersLogsSuccess(DateTime.Now);
        }
    }
}
