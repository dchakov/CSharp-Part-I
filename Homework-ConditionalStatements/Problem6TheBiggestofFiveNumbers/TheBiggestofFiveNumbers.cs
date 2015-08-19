//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:
//a	b	c	d	e	biggest
//5	2	2	4	1	5
//-2	-22	1	0	0	1
//-2	4	3	2	0	4
//0	-2.5	0	5	5	5
//-3	-0.5	-1.1	-2	-0.1	-0.1

using System;
using System.Threading;
using System.Globalization;


class TheBiggestofFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine("Please enter 5 numbers on a new lines");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber < secondNumber)
        {
            firstNumber = secondNumber;
        }
        if (thirdNumber < fourthNumber)
        {
            thirdNumber = fourthNumber;
        }
        if (firstNumber > thirdNumber)
        {
            if (firstNumber > fifthNumber)
            {
                Console.WriteLine("Biggest = {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("Biggest = {0}", fifthNumber);
            }
        }
        else
        {
            if (thirdNumber > fifthNumber)
            {
                Console.WriteLine("Biggest = {0}", thirdNumber);
            }
            else
            {
                Console.WriteLine("Biggest = {0}", fifthNumber);
            }
        }
    }
}
