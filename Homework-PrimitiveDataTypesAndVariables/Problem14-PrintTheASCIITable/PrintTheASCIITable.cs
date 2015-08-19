using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 14.* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

namespace Problem14_PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1 ASCII table Ecoding.ASCII

            Console.SetBufferSize(85,700);
            Console.WriteLine("ASCII table");
            Console.WriteLine("\n");
            Console.OutputEncoding = Encoding.ASCII;

            for (int i = 0; i <= 255; i++)
            {
                if (char.IsControl((char)i))
                {
                    Console.WriteLine("{0} = Special purpose",i);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", i, (char)i);
                }

            }

            // EXAMPLE 2 ASCII table Ecoding.Default

            Console.WriteLine("\n");
            Console.WriteLine("Default ASCII table");
            Console.WriteLine("\n");
            Console.OutputEncoding = Encoding.Default;
            for (int i = 0; i <= 255; i++)
            {
                if (char.IsControl((char)i))
                {
                    Console.WriteLine("{0} = Special purpose",i);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", i, (char)i);
                }
            }
        }

    }
}
