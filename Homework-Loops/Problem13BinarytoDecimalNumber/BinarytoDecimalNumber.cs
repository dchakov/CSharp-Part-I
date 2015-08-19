//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//binary	decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736

using System;
using System.IO;

class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter binary number");
        string binaryNumber = Console.ReadLine();
        long rezult = 0;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            if ((char)binaryNumber[i] == 49)
            {
                rezult = rezult + (long)Math.Pow(2,binaryNumber.Length-i-1);
            }
        }
        Console.WriteLine(rezult);
    }
}

