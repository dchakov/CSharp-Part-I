//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.
//Examples:
//n	comments
//1	0
//3	0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a number greater or equal to 1:");
            int numberN = int.Parse(Console.ReadLine());
                         
            int previousNumber = -1;
            int nextNumber = 1;
            int sumNumbers = 0;
            
            if (numberN < 1)
            {
                Console.WriteLine("Number you entered is less than 1");
                return;
            }

            for (int i = 1; i <= numberN; i++)
            {
                sumNumbers = previousNumber + nextNumber;
                previousNumber = nextNumber;
                nextNumber = sumNumbers;
                Console.Write("{0} ", nextNumber);
            }
        }
    }

