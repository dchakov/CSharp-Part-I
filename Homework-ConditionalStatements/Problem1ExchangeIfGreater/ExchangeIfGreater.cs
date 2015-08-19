//Problem 1. Exchange If Greater• Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:
//a
//b
//result
//5 2 2 5 
//3 4 3 4 
//5.5 4.5 4.5 5.5 

using System;
using System.Threading;
using System.Globalization;

class ExchangeIfGreater
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine("Please, enter two numbers on new lines:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
           a = a + b;
           b = a - b;
           a = a - b; 
        }
        Console.WriteLine("{0} {1}", a, b);
    }
}
