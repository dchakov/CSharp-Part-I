using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Modify a Bit at Given Position• We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
//• Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  at the position  p  from the binary representation of  n  while preserving all other bits in  n .
//Examples:
//n
//binary representation of n
//p
//v
//binary result
//result


//5 00000000 00000101 2 0 00000000 00000001 1 
//0 00000000 00000000 9 1 00000010 00000000 512 
//15 00000000 00001111 1 1 00000000 00001111 15 
//5343 00010100 11011111 7 0 00010100 01011111 5215 
//62241 11110011 00100001 11 0 11110011 00100001 62241 

namespace Problem14ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number:");
            int numberForBit = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a index p (0-15):");
            int indexOfPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter a value v 0 or 1:");
            int valueV= int.Parse(Console.ReadLine());

            if (valueV == 0)
            {
                int mask = ~(1 << indexOfPosition);
                int nAndMask = numberForBit & mask; // set the the bit at position p to 0

                Console.WriteLine("n \\binary representation of n \\ p \\ v \\ binary result \\ result");
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16, '0'), indexOfPosition, valueV, Convert.ToString(nAndMask, 2).PadLeft(16, '0'), nAndMask);
            }
            else
            {
                int mask = 1 << indexOfPosition;
                int nAndMask = numberForBit | mask; // set the bit at position p to 1

                Console.WriteLine("n \\binary representation of n \\ p \\ v \\ binary result \\ result");
                Console.WriteLine("{0}  {1}  {2}  {3}  {4}  {5}", numberForBit, Convert.ToString(numberForBit, 2).PadLeft(16, '0'), indexOfPosition, valueV, Convert.ToString(nAndMask, 2).PadLeft(16, '0'), nAndMask);
             } 
        }
    }
}
