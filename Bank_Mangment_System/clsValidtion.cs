//using Bussniesslayer_LoginSySLogic;
using BussinessLayer_BankProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;


namespace LoginSySFullProject
{
    public class clsValidtion
    {
        static string[] EmailChoices = { "gmail", "hotmail", "email" };
       public static bool IsAllNotEmpty(string FirstName,  string Password, string Email)
        {
            bool IsAllTextNotEmpty;
            IsAllTextNotEmpty = (FirstName != ""  && Password != "" && Email != "");

            //Enable = IsAllTextNotEmpty;
            return IsAllTextNotEmpty;
        }
        public static bool IsAllNotEmpty(string FirstName, string LastName, string Email,string AccoutNumber,string PIN)
        {
            bool IsAllTextNotEmpty;
            IsAllTextNotEmpty = (FirstName != "" && LastName != "" && Email != ""&&AccoutNumber!=""&&PIN!="");

            //Enable = IsAllTextNotEmpty;
            return IsAllTextNotEmpty;
        }
        public static bool IsAllNotEmpty(string Email,string Password)
        {
            bool IsAllTextNotEmpty;
            IsAllTextNotEmpty = (Password != "" && Email != "");

            //Enable = IsAllTextNotEmpty;
            return IsAllTextNotEmpty;
        }
       public static bool CheckIsValidEmail(string Email)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Email.EndsWith($"@{EmailChoices[i]}.com"))
                {
                    return true;
                }
            }
            return false;

        }
        //public static bool CheckifEmailExisting(string Email)
        //{
        //    return clsLoginSYS.IsEmailExisting(Email);
        //}
        public static bool CheckifClientEmailExisting(string Email)
        {
            return true;
        }
        public static bool CheckAccountNumber(string AccountNumber)
        {
            for (int i = 0; i < AccountNumber.Length; i++)
            {
                if (Char.IsPunctuation(AccountNumber[i]))
                {
                    return false;
                }

            }
            return true;
        }
        public static bool CheckPINCode(string PIN)
        {
            for (int i = 0; i < PIN.Length; i++)
            {
                if (!Char.IsDigit(PIN[i]))
                {
                    return false;
                }

            }
            return true;

        }

        public static bool IsPasswordContainsAllChar(string password)
        {
            int digitCount=0;
            int LetterCount = 0;
            int UniqeCharCount = 0;
            for(int i=0; i < password.Length;i++)
            {
                if (char.IsDigit(password[i]))
                digitCount++;
                if(char.IsLetter(password[i]))
                    LetterCount++;
                if (char.IsPunctuation(password[i]))
                    UniqeCharCount++;

            }
            return digitCount >= 2 &&LetterCount>2&&UniqeCharCount>=2;
        }
       public static bool CheckIfPasswordMoreThan8(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
           
            return true;
        }
        public static bool CheckIsEmailExisting(string Email)
        {
            return clsPerson.IsEmailExisting(Email);
        }
        public static bool CheckIfAccountNumberExisting(string AccountNumber)
        {
            return clsAccount.IsAccountNumberExisting(AccountNumber);
        }
    }
}
