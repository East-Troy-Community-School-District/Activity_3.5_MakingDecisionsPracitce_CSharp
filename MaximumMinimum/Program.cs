/*
 * Maximum Minimum
 * Pawelski
 * 10/1/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, max;

            Console.Write("Enter a number >> ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number >> ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                max = number1;
            }
            else
            {
                max = number2;
            }

            Console.WriteLine("The maximum is " + max);
        }
    }
}
