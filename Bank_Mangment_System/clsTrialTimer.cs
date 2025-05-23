using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Web.UI.WebControls;
namespace Bank_Mangment_System

{
    public class clsTrialTimer
    {
       static int CounterTry { get; set; }
        static string TimeTries { get; set; }
       static DateTime DateSinceLastTry = DateTime.MinValue;
      static  bool CheckIfTimeOver()
        {
            return (DateSinceLastTry.CompareTo(DateTime.Now) == 0 || DateSinceLastTry.CompareTo(DateTime.Now) == -1);

        }
        void StopTimerOfPrevent(Timer timerProgramStopped)
        {
            if (CheckIfTimeOver())
            {
                timerProgramStopped.Stop();
            }

        }
       static void StoreTimeinFile()
        {
            File.WriteAllText("C:\\Users\\Laptop Home\\Desktop\\Doucement\\TimerTriesforBank.txt", DateTime.Now.AddMinutes(5).ToString());
        }
      static void GetDateFromFile()
        {
            TimeTries = File.ReadAllText("C:\\Users\\Laptop Home\\Desktop\\Doucement\\TimerTriesforBank.txt");
            if(TimeTries!="")
            DateSinceLastTry = Convert.ToDateTime(TimeTries);

        }
       static void TimeRemainingOn(Label lblTryAgain, Label lblTimer, Label lblSecond, Button btnLogin, bool enable)
        {


            lblTryAgain.Visible = enable;
            lblTimer.Visible = enable;
            lblSecond.Visible = enable;
            btnLogin.Enabled = !enable;
        }
       public static void IncrementCounter(Timer timerProgramStopped, Label lblTryAgain, Label lblTimer, Label lblSecond, Button btnLogin)
        {
            CounterTry++;
            if (CounterTry == 3)
            {
                CounterTry = 0;
                StoreTimeinFile();
                TimeRemainingOn(lblTryAgain, lblTimer, lblSecond, btnLogin, true);
                timerProgramStopped.Start();


            }
        }
       public static void StartTimer(Label lblTryAgain, Label lblTimer, Label lblSecond, Button btnLogin,Timer timerProgramStopped)
        {
            GetDateFromFile();
            int Minute = 0;
            int Second = 0;
            TimeSpan timeRemaining = DateSinceLastTry - DateTime.Now;
            if (CheckIfTimeOver())
            {
                TimeRemainingOn(lblTryAgain,  lblTimer, lblSecond, btnLogin, false);
                timerProgramStopped.Enabled = false;
                return;
            }
            Minute = (int)timeRemaining.Minutes;
            Second = (int)timeRemaining.Seconds;
            lblTimer.Text = Minute.ToString();
            lblSecond.Text = Second.ToString();
        }
       public static void TimeLoader(Label lblTryAgain, Label lblTimer, Label lblSecond, Button btnLogin, Timer timerProgramStopped)
        {
            GetDateFromFile();
            if (!CheckIfTimeOver())
            {
                TimeRemainingOn(lblTryAgain, lblTimer, lblSecond, btnLogin,true);
                timerProgramStopped.Start();

            }
            else
            { TimeRemainingOn(lblTryAgain, lblTimer, lblSecond, btnLogin, false); }
        }
    }
}
