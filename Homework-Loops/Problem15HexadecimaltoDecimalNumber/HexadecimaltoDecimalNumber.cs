//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//hexadecimal	decimal
//FE	254
//1AE3	6883
//4ED528CBB4	338583669684

using System;

class HexadecimaltoDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Please, enter a hexadecimal integer number");
        string hexaDecimal = Console.ReadLine();
        long rezult = 0;
        int numberDecimal = 0;

        for (int i = hexaDecimal.Length - 1; i >=0 ; i--)
        {
            int number;
            string str = Convert.ToString(hexaDecimal[i]);
            
            if (int.TryParse(str, out number))
            {
                 rezult += number*(long)Math.Pow(16, hexaDecimal.Length- i- 1);
            }
            else
            {
                switch (str)
                {
                    case "A": numberDecimal = 10; break;
                    case "B": numberDecimal = 11; break;
                    case "C": numberDecimal = 12; break;
                    case "D": numberDecimal = 13; break;
                    case "E": numberDecimal = 14; break;
                    case "F": numberDecimal = 15; break;
                }
                rezult += numberDecimal * (long)Math.Pow(16, hexaDecimal.Length - i - 1);
            }
        }
        Console.WriteLine(rezult);
    }
}
