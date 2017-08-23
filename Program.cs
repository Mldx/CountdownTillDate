using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountdownTillDate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Now = DateTime.Now;
            Console.Write("Current Time: "); //Making a lot of spaces, so everything will be aligned, when written to the console.
            printDateTime(Now);

            DateTime schoolEnd = new DateTime(); //Since DateTimes start at 1/1/1 0:0:0, I will substract one from DD/MM/YYYY
            schoolEnd = schoolEnd.AddDays(21 - 1); //Currently, you are only able to change the date from the code. I might change that in the future :)
            schoolEnd = schoolEnd.AddMonths(6 - 1);
            schoolEnd = schoolEnd.AddYears(2020 - 1);
            schoolEnd = schoolEnd.AddHours(12);
            schoolEnd = schoolEnd.AddMinutes(0);
            schoolEnd = schoolEnd.AddSeconds(0);
            Console.Write("School End:   ");
            printDateTime(schoolEnd);  

            DateTime schoolStart = new DateTime(); //Since DateTimes start at 1/1/1 0:0:0, I will substract one from DD/MM/YYYY
            schoolStart = schoolStart.AddDays(8 - 1); //Currently, you are only able to change the date from the code. I might change that in the future :)
            schoolStart = schoolStart.AddMonths(8 - 1);
            schoolStart = schoolStart.AddYears(2017 - 1);
            schoolStart = schoolStart.AddHours(8);
            schoolStart = schoolStart.AddMinutes(10);
            schoolStart = schoolStart.AddSeconds(0);
            Console.Write("School Start: ");
            printDateTime(schoolStart);

            Console.WriteLine("\n---------------------------------\n"); //Prints a line which makes it

            Console.Write("To Be added! :)");
            // TO BE ADDED!!

            string g = Console.ReadLine(); //Makes sure the console won't close after reaching this point.
        }

        static void printDateTime(DateTime print) //Function to print a DateTimes date.
        {
            Console.WriteLine(
                zeroAdder(print.Day.ToString()) +
                "/" +
                zeroAdder(print.Month.ToString()) +
                "/" +
                zeroAdder(print.Year.ToString()) +
                " " +
                zeroAdder(print.Hour.ToString()) +
                ":" +
                zeroAdder(print.Minute.ToString()) +
                ":" +
                zeroAdder(print.Second.ToString()));
        }

        static string zeroAdder(string Number) //Function that adds a zero to a string, if the string is LESS than 2 characters in length.
        {
            if (Number.Length < 2)
            {
                Number = "0" + Number;
            }
            return Number;
        }
    }
}
