//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
//Examples:
//a	b	greater
//5	6	6
//10	5	10
//0	0	0
//-5	-2	-2
//1.5	1.6	1.6

using System;
using System.Threading;
using System.Globalization;

    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter number A:");
            double numberA = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number B:");
            double numberB = double.Parse(Console.ReadLine());

            double greaterer = Math.Max(numberA, numberB);
            Console.WriteLine("Greaterer of number A and B is:" + greaterer);
        }
    }
