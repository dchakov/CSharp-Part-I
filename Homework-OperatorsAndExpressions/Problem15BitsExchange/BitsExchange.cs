using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 15.* Bits Exchange• Write a program that exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer.
//Examples:
//n
//binary representation of n
//binary result
//result

//1140867093 01000100 00000000 01000000 00010101 01000010 00000000 01000000 00100101 1107312677 
//255406592 00001111 00111001 00110010 00000000 00001000 00111001 00110010 00111000 137966136 
//4294901775 11111111 11111111 00000000 00001111 11111001 11111111 00000000 00111111 4194238527 
//5351 00000000 00000000 00010100 11100111 00000100 00000000 00010100 11000111 67114183 
//2369124121 10001101 00110101 11110111 00011001 10001011 00110101 11110111 00101001 2335569705 

namespace Problem15BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");
            uint numberForBit = uint.Parse(Console.ReadLine());

            Console.WriteLine("n \\binary representation of n");
            Console.WriteLine("{0}  {1}", Convert.ToString(numberForBit, 2).PadLeft(32, '0'), numberForBit);

                for (int i = 0; i <= 2; i++)
                {
                    uint maskFirst = (uint)Math.Pow(2, (3 + i));
                    uint nAndMaskFirst = numberForBit & maskFirst;
                    uint bitFirst = nAndMaskFirst >> (3 + i);  // get the bit at position 3 in a number n

                    uint maskSecond = (uint)Math.Pow(2, (24 + i));
                    uint nAndMaskSecond = numberForBit & maskSecond;
                    uint bitSecond = nAndMaskSecond >> (24 + i);  // get the bit at position 24 in a number n

                    if ((bitFirst == 1) && (bitSecond == 0))
                    {
                        maskFirst = ~maskFirst;
                        numberForBit = numberForBit & maskFirst; // set the the bit at position p to 0
                        numberForBit = numberForBit | maskSecond; // set the bit at position p to 1
                    }
                    else if ((bitFirst == 0) && (bitSecond == 1))
                    {
                        numberForBit = numberForBit | maskFirst; // set the bit at position p to 1
                        maskSecond = ~maskSecond;
                        numberForBit = numberForBit & maskSecond; // set the the bit at position p to 0
                    }
                }
                Console.WriteLine("binary result \\ result");
                Console.WriteLine("{0}  {1}",Convert.ToString(numberForBit,2).PadLeft(32,'0'), numberForBit);
         }
    }
}

