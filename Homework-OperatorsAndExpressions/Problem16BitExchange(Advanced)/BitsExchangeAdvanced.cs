using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16.** Bit Exchange (Advanced)• Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
//• The first and the second sequence of bits may not overlap.
//Examples:
//n
//p
//q
//k
//binary representation of n
//binary result
//result

//1140867093 3 24 3 01000100 00000000 01000000 00010101 01000010 00000000 01000000 00100101 1107312677 
//4294901775 24 3 3 11111111 11111111 00000000 00001111 11111001 11111111 00000000 00111111 4194238527 
//2369124121 2 22 10 10001101 00110101 11110111 00011001 01110001 10110101 11111000 11010001 1907751121 
//987654321 2 8 11 - - overlapping 
//123456789 26 0 7 - - out of range 
//33333333333 -1 0 33 - - out of range 


namespace Problem16BitExchange_Advanced_
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");
            uint numberForBit = uint.Parse(Console.ReadLine());

            Console.WriteLine("n \\binary representation of n");
            Console.WriteLine("{0}  {1}", Convert.ToString(numberForBit, 2).PadLeft(32, '0'), numberForBit);

            Console.WriteLine("Enter the first position of the bits, that are going to be exchanged:");
            int positionFirst = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second position of the bits, that are going to be exchanged:");
            int positionSecond = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of the bits, that are going to be exchanged:");
            int numberOfBitsToExchange = int.Parse(Console.ReadLine());

            if ((positionFirst + numberOfBitsToExchange > 32) || (positionSecond + numberOfBitsToExchange > 32) || (positionFirst<0) || (positionSecond<0))
            {
              Console.WriteLine("Out of range");  
            }

            else if (Math.Min(positionFirst,positionSecond)+numberOfBitsToExchange > Math.Max(positionFirst,positionSecond))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = 0; i < numberOfBitsToExchange; i++)
                {
                    uint maskFirst = (uint)Math.Pow(2, (positionFirst + i));
                    uint nAndMaskFirst = numberForBit & maskFirst;
                    uint bitFirst = nAndMaskFirst >> (positionFirst + i);  // get the bit at position 3 in a number n

                    uint maskSecond = (uint)Math.Pow(2, (positionSecond + i));
                    uint nAndMaskSecond = numberForBit & maskSecond;
                    uint bitSecond = nAndMaskSecond >> (positionSecond + i);  // get the bit at position 24 in a number n

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
                Console.WriteLine("{0}  {1}", Convert.ToString(numberForBit, 2).PadLeft(32, '0'), numberForBit);
            }
        }
    }
}
