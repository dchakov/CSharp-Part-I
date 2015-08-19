using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 13. Check a Bit at Given Position• Write a Boolean expression that returns if the bit at position  p  
//(counting from  0 , starting from the right) in given integer number  n , has value of 1.
//Examples:
//n
//binary representation of n
//p
//bit @ p == 1

//5 00000000 00000101 2 true 
//0 00000000 00000000 9 false 
//15 00000000 00001111 1 true 
//5343 00010100 11011111 7 true 
//62241 11110011 00100001 11 false 

namespace Problem13CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");
            int numberForBit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a index p (0-15):");
            int indexOfPosition = int.Parse(Console.ReadLine());

            if ((indexOfPosition >= 0) && (indexOfPosition <= 15))
            {
                int mask = 1 << indexOfPosition;
                int nAndMask = numberForBit & mask;
                int bit = nAndMask >> indexOfPosition;
                if (bit==1)
                {
                    Console.WriteLine("The value of the bit at index {0} of a given integer is:TRUE", indexOfPosition);
                    Console.WriteLine("{0}  {1}  {2}  TRUE", numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16, '0'), indexOfPosition);  
                }
                else
                {
                    Console.WriteLine("The value of the bit at index {0} of a given integer is:FALSE", indexOfPosition);
                    Console.WriteLine("{0}  {1}  {2}  ", numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16, '0'), indexOfPosition);  
                }
            }
            else
            {
                Console.WriteLine("Index of position must be between 0 and 15");
            }
        }
    }
}
