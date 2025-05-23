using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Bank_Mangment_System
{
    public class clsAnimateText
    {
         int FormatWordCounter { get; set; }
         int TimerAnimateCounter { get; set; }
        int CounterOftxt { get; set; }
        public clsAnimateText() {
            FormatWordCounter=0; TimerAnimateCounter=0; CounterOftxt=0;
        }
        public void ResetValues()
        {
            FormatWordCounter = 0; TimerAnimateCounter=0;CounterOftxt=0;
            Console.WriteLine("Rested");
        }
        ~clsAnimateText()
        {
            CounterOftxt=0;
            FormatWordCounter = 0;
            TimerAnimateCounter = 0;
        }
     
        public  void AnimateOn(ref bool TimerEnable)
        {
            
            TimerAnimateCounter++;
            if (TimerAnimateCounter == 2)
            {
                CounterOftxt = 1;
                TimerAnimateCounter = 0;
                TimerEnable = true;
            }
            else
            {
                CounterOftxt = 0;
                TimerEnable=true;
            }
        }
     public void Animatetxt(string[] TxtsOfFormat, ref string Formattxt,  ref bool TimerChangeLabel, ref bool TimerAnimateLabel)
        {
            string text = TxtsOfFormat[CounterOftxt];
            Formattxt = "";
            while (FormatWordCounter < text.Length)
            {
                TimerChangeLabel = false;
                Formattxt = text.Substring(0, FormatWordCounter + 1);
                FormatWordCounter++;
                if (FormatWordCounter == text.Length)
                {

                    FormatWordCounter = 0;
                    TimerAnimateLabel = false;
                    TimerChangeLabel=true;
                }
                return;
            }
            //lblFormattxt.Text = text.Substring(0, i+1);


        }
    }
}
