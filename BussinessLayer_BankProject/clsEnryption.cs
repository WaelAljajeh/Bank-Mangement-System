using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_BankProject
{
    public class clsEnryption
    {
       public static string EncryptPassword(string password,int key)
        {
            string Newpass="";
            for (int i = 0; i < password.Length; i++)
            {
                int x = Convert.ToInt32(password[i]);
                x += key;
                Newpass +=Convert.ToChar(x);
            }
            return Newpass;

        }
       public static string DecryptPassword(string password, int key)
        {
            string Newpass="";
            for (int i = 0; i < password.Length; i++)
            {
                int x = Convert.ToInt32(password[i]);
                x -= key;
                Newpass += Convert.ToChar(x);
            }
            return Newpass;
        }

    }
}
