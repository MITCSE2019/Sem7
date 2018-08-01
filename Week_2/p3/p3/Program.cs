using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int day, month, year, hr, min, sec;
            double ticks;
            Console.WriteLine("Enter the time in format-> dd:mm:yy:HH:MM::SS");
            string origTime = Console.ReadLine();
            string dayStr = origTime.Substring(0, origTime.IndexOf(':'));
            string tempTime = origTime.Substring(origTime.IndexOf(':') + 1, origTime.Length - 3);
            string monthStr = tempTime.Substring(0, tempTime.IndexOf(':'));
            tempTime = tempTime.Substring(tempTime.IndexOf(':') + 1, tempTime.Length - 3);
            string yearStr = tempTime.Substring(0, tempTime.IndexOf(':'));
            tempTime = tempTime.Substring(tempTime.IndexOf(':') + 1, tempTime.Length - 3);
            string hrStr = tempTime.Substring(0, tempTime.IndexOf(':'));
            tempTime = tempTime.Substring(tempTime.IndexOf(':') + 1, tempTime.Length - 3);
            string minStr = tempTime.Substring(0, tempTime.IndexOf(':'));
            tempTime = tempTime.Substring(tempTime.IndexOf(':') + 1, tempTime.Length - 3);
            string secStr = tempTime;
            if (int.TryParse(dayStr, out day) == false || int.TryParse(monthStr, out month) == false || int.TryParse(yearStr, out year) == false || int.TryParse(hrStr, out hr) == false || int.TryParse(minStr, out min) == false || int.TryParse(secStr, out sec) == false)
            {
                Console.WriteLine("Wrong Output");
                Console.Read();
                return;
            }
            if (hr >= 24)
            {
                Console.WriteLine("Hrs should be less than 24");
                Console.Read();
                return;
            }
            else if (min >= 60)
            {
                Console.WriteLine("Minutes should be less than 60");
                Console.Read();
                return;
            }
            else if (sec >= 60)
            {
                Console.WriteLine("Seconds should be less than 60");
                Console.Read();
                return;
            }
            else if (month >= 13)
            {
                Console.WriteLine("Month should be less than 13");
                Console.Read();
                return;
            }
            else if (day >= 32)
            {
                Console.WriteLine("Day should be less than 32");
                Console.Read();
                return;
            }
            Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}", day, month, year, hr, min, sec);
            Console.WriteLine("Enter ticks");
            string ticksStr = Console.ReadLine();
            if (double.TryParse(ticksStr, out ticks) == false)
            {
                Console.WriteLine("Enter valid number");
                Console.Read();
                return;
            }
            ticks = (int)(ticks * 0.0000001);
            sec = sec + (int)ticks;
            if (sec >= 60)
            {
                int addMins = sec / 60;
                sec %= 60;
                min += addMins;
            }
            if (min >= 60)
            {
                int addHrs = min / 60;
                min %= 60;
                hr += addHrs;
            }
            if (hr >= 24)
            {
                int addDay = hr / 24;
                hr %= 24;
                day += addDay;
            }
            if (day >= 31)
            {
                int addMonth = day / 31;
                day %= 31;
                month += addMonth;
            }
            if (month >= 13)
            {
                int addYear = month / 12;
                month %= 12;
                year += addYear;
            }
            Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}", day, month, year, hr, min, sec);
            Console.Read();
        }
    }
    
}
