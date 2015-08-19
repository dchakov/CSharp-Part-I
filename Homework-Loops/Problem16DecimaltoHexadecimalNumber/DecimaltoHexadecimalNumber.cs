//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal	hexadecimal
//254	FE
//6883	1AE3
//338583669684	4ED528CBB4

using System;

class DecimaltoHexadecimalNumber
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
            string hexaDecimal = null;

            while (numberDecimal >= 1)
            {
                long m = numberDecimal % 16;

                if (m == 0)
                {
                    numberDecimal /= 16;
                }
                else
                {
                    numberDecimal = (numberDecimal - numberDecimal % 16) / 16;
                }
                if (m >= 0 && m <= 9)
                {
                    rezultString = rezultString + Convert.ToString(m);
                }
                else
                {
                    switch (m)
                    {
                        case 10: hexaDecimal = "A"; break;
                        case 11: hexaDecimal = "B"; break;
                        case 12: hexaDecimal = "C"; break;
                        case 13: hexaDecimal = "D"; break;
                        case 14: hexaDecimal = "E"; break;
                        case 15: hexaDecimal = "F"; break;
                    }
                    rezultString = rezultString + hexaDecimal;
                }
            }

            for (int i = rezultString.Length - 1; i >= 0; i--)
            {
                Console.Write(rezultString[i]);
            }
            Console.WriteLine();
        }
    }
}
