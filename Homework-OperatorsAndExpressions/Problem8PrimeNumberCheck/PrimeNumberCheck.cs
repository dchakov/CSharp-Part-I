using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Prime Number Check• Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

//Examples:
//n
//Prime?

//1 false 
//2 true 
//3 true 
//4 false 
//9 false 
//97 true 
//51 false 
//-3 false 
//0 false 

namespace Problem8PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a positive number:");
            int enteredNumber = int.Parse(Console.ReadLine());

            if (enteredNumber==2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("TRUE",enteredNumber);
                Console.WriteLine("The Number {0} is prime", enteredNumber);
            }
            
            else if ((enteredNumber==0) || (enteredNumber<=0))
            {
                Console.WriteLine("\n");
                Console.WriteLine("FALSE", enteredNumber);
                Console.WriteLine("The Number {0} is NOT prime", enteredNumber);
            }
            else
            {
                int k = 0; 
                for (int i = 1; i <= enteredNumber; i++)
                {
                    if (enteredNumber % i == 0)
                    {
                        k++; // Counter k . Two options of divide by itself or by 1 if more FALSE.
                    }  
                }
                     if (k==2)
                        {
                         Console.WriteLine("\n");
                         Console.WriteLine("TRUE",enteredNumber);
                         Console.WriteLine("The Number {0} is prime", enteredNumber);    
                        }
                    else
                         {
                         Console.WriteLine("\n");
                         Console.WriteLine("FALSE", enteredNumber);
                         Console.WriteLine("The Number {0} is NOT prime", enteredNumber);
                         }
                
            }
        }
    }
}
