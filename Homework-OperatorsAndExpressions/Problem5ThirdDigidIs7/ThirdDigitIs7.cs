using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 5. Third Digit is 7?• Write an expression that checks for given integer if its third digit from right-to-left is  7 .

//Examples:
//n
//Third digit 7?

//5 false 
//701 true 
//9703 true 
//877 false 
//777877 false 
//9999799 true 

namespace Problem5ThirdDigidIs7
{
    class ThirdDigitIs7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter number:");
            int numberToCheck = int.Parse(Console.ReadLine());
            if ((numberToCheck/100) % 10 == 7)
            {
                Console.WriteLine("\n");
                Console.WriteLine("TRUE");
                Console.WriteLine("The third digit from right-to-left is  7");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("FALSE");
            }
        }
    }
}
