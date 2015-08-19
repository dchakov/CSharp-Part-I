using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3. Divide by 7 and 5• Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.
//Examples:
//n
//Divided by 7 and 5?


//3 false 
//0 false 
//5 false 
//7 false 
//35 true 
//140 true 

namespace Problem3DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int someNumber = int.Parse(Console.ReadLine());
            if (someNumber == 0)
            {
                Console.WriteLine("FALSE");
                Console.WriteLine("The number you enter CANNOT be divided by 7 and 5");
            }
            else if (((someNumber % 7) == 0) && ((someNumber % 5) == 0))
            {
                Console.WriteLine("\n");
                Console.WriteLine("TRUE");
                Console.WriteLine("The number you enter CAN be divided by 7 and 5");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("FALSE");
                Console.WriteLine("The number you enter CANNOT be divided by 7 and 5");
            }
        }
    }
}
