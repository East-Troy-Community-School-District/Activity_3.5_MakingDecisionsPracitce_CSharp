﻿/*
 * Even Odd
 * Pawelski
 * 10/1/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Enter a number >> ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("That is an even number!");
            }
        }
    }
}
