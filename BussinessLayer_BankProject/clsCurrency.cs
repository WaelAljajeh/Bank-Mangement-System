using DataAccessLayer_BankProject;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer_BankProject
{

    public class clsCurrency
    {
       public string Currecny_Code { get; set; }
        string Currency_name { get; set; }
        string Country {  get; set; }
        float Rate {  get; set; }
        public clsCurrency()
        {
            Currecny_Code = "";
            Currency_name = "";
            Country = "";
            Rate = 0;

        }
        clsCurrency(string Currecny_Code, string Currency_name,string Country,float Rate)
        {
            this.Currency_name = Currency_name;
            this.Country = Country;
            this.Rate = Rate;
            this.Currecny_Code=Currecny_Code;
        }
        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyDAL.GetAllCurrencies();
        }
        public static float GetRateByCurrencyCode(string currencyCode)
        {
            return clsCurrencyDAL.FindRatesByCurrencyCode(currencyCode);
        }
         float GetValueAfterExchangeToUSD(float Amount)
        {
            return (float)((float)Amount / (float)Rate);
        }
        public float CalculateCurrency(float Amount,clsCurrency currency2)
        {
            float AmountOfUSD = GetValueAfterExchangeToUSD(Amount);
            if(currency2.Currecny_Code=="USD")
            {
                return AmountOfUSD;
            }
            return (float)((float)AmountOfUSD*(float)currency2.Rate);

        }
        public static clsCurrency FindCurrencyByItsCode(string code)
        {
            string country = "", currency_name = "";
            float rate = 0;
            if (clsCurrencyDAL.FindCurrencyCurrencyCode(code, ref rate, ref country, ref currency_name))
            {
                return new clsCurrency(code, currency_name, country, rate);
            }
            return null;
        }

    }
}
