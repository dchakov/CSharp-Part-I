//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.
//Examples:
//a	b	c	biggest
//5	2	2	5
//-2	-2	1	1
//-2	4	3	4
//0	-2.5	5	5
//-0.1	-0.5	-1.1	-0.1

using System;
using System.Threading;
using System.Globalization;

class TheBiggestof3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine("Please enter 3 numbers on a new lines");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Biggest = {0}", firstNumber);   
            }
            else
            {
                Console.WriteLine("Biggest = {0}", thirdNumber);
            }
        }
        else
        {
            if (secondNumber > thirdNumber)
            {
                Console.WriteLine("Biggest = {0}", secondNumber);
            }
            else
            {
                Console.WriteLine("Biggest = {0}", thirdNumber);
            }
        }
    }
}


