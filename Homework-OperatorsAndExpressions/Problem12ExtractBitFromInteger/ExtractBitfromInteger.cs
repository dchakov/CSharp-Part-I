using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Extract Bit from Integer• Write an expression that extracts from given integer  n  the value of given bit at index  p .
//Examples:
//n
//binary representation
//p
//bit @ p

//5 00000000 00000101 2 1 
//0 00000000 00000000 9 0 
//15 00000000 00001111 1 1 
//5343 00010100 11011111 7 1 
//62241 11110011 00100001 11 0 

namespace Problem12ExtractBitFromInteger
{
    class ExtractBitfromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");
            int numberForBit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a index p (0-15):");
            int indexOfPosition= int.Parse(Console.ReadLine());

            if ((indexOfPosition >= 0) && (indexOfPosition<=15))
            {
                int mask = 1 << indexOfPosition ;
                int nAndMask = numberForBit & mask;
                int bit = nAndMask >> indexOfPosition;

                Console.WriteLine("The value of the bit at index {0} of a given integer is:{1}",indexOfPosition,bit);
                Console.WriteLine("{0}  {1}  {2}  {3}", numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16, '0'),indexOfPosition, bit);
            }
            else
            {
                Console.WriteLine("Index of position must be between 0 and 15");
            }
        }
    }
}
