// See https://aka.ms/new-console-template for more information
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;
namespace Number
{
    class N
    {
        public static void Main()
        {
        }

        public static void happy()
        {
           /* Write an algorithm to determine if a number n is happy.
            A happy number is a number defined by the following process:
        Starting with any positive integer, replace the number by the sum of the squares of its digits.
Repeat the process until the number equals 1(where it will stay), or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not*/
            Console.WriteLine("Enter a number(happy):");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 2)
            {
                Console.WriteLine("Not happy");
            }
            else if (n <= 0)
            {
                Console.WriteLine("Not happy");
            }

        }
    }
}