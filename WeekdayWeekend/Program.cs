/*
 * Weekday Weekend
 * 1/9/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekdayWeekend
{
    class Program
    {
        static void Main(string[] args)
        {
            string day;

            Console.Write("What is today? >> ");
            day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday")
            {
                Console.WriteLine("Get back to work!");
            }
            else if (day == "Saturday")
            {
                Console.WriteLine("Time to relax!");
            }
        }
    }
}
