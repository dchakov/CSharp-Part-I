//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal	binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000

using System;

class DecimaltoBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter integer number:");
        long numberDecimal = long.Parse(Console.ReadLine());

        if (numberDecimal == 0)
        {
            Console.WriteLine(numberDecimal);
        }
        else
        {
            string rezultString = null;
            while (numberDecimal >= 1)
            {
                long m = numberDecimal % 2; // m 0 or 1

                if (m == 0)
                {
                    numberDecimal /= 2;
                }
                else
                { 
                    numberDecimal = (numberDecimal - 1) / 2;
                }
                rezultString = rezultString + Convert.ToString(m);
            }
            
            for (int i = rezultString.Length - 1; i >= 0; i--)
            {
                Console.Write(rezultString[i]);
            }
            Console.WriteLine();
        }
    }

}


