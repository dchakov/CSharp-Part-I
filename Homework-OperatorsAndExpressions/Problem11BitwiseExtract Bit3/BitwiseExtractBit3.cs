using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 11. Bitwise: Extract Bit #3• Using bitwise operators, write an expression for finding the value of the bit  #3  of a given unsigned integer.
//• The bits are counted from right to left, starting from bit  #0 .
//• The result of the expression should be either  1  or  0 .
//Examples:
//n
//binary representation
//bit #3

//5 00000000 00000101 0 
//0 00000000 00000000 0 
//15 00000000 00001111 1 
//5343 00010100 11011111 1 
//62241 11110011 00100001 0 

namespace Problem11BitwiseExtract_Bit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter positive number:");
            int numberForBit= int.Parse(Console.ReadLine());

            if (numberForBit >= 0)
            {
                int positionOfNumber = 3;
                int mask = 1 << positionOfNumber;        
                int nAndMask = numberForBit & mask;      
                int bit = nAndMask >> positionOfNumber;
                Console.WriteLine("The value of the bit  #3  of a given unsigned integer is:"+bit);
                Console.WriteLine("{0}  {1}  {2}",numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16,'0') ,bit);  
            }
            else
	        {
                Console.WriteLine("Number must be positive");
	        }
        }
    }
}
