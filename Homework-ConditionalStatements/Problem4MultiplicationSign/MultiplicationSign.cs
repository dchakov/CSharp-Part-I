//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.
//Examples:
//a	b	c	result
//5	2	2	+
//-2	-2	1	+
//-2	4	3	-
//0	-2.5	4	0
//-1	-0.5	-5.1	-

using System;
using System.Threading;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

        Console.WriteLine("Please enter 3 real numbers on a new lines");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (firstNumber > 0)
            {
                if (secondNumber > 0 ^ thirdNumber > 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else
            {
                if (secondNumber > 0 ^ thirdNumber > 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }


        }
    }
}

