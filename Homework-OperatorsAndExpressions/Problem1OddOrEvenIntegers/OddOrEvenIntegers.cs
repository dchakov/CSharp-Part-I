using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Odd or Even Integers• Write an expression that checks if given integer is odd or even.

//Examples:
//n
//Odd?
//3 true 
//2 false 
//-2 false 
//-1 true 
//0 false 

namespace Problem1OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int numberToCheck = int.Parse(Console.ReadLine());
            if ((numberToCheck % 2) != 0)
            {
                Console.WriteLine("The number you entered is ODD");
            }
            else
            {
                Console.WriteLine("The number you entered is EVEN");
            }
        }
    }
}
