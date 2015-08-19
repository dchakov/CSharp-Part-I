//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//numbers
//sum
//3 90 
//20  
//60  
//10  
//5 6.5 
//2  
//-1  
//-0.5  
//4  
//2  
//1 1 
//1  

using System;
using System.Threading;
using System.Globalization;


    class SumOfnNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter a number greater than 1:");
            int numberN = int.Parse(Console.ReadLine());

            if (numberN < 0)
            {
                Console.WriteLine("Number you entered is less than 1");
                return;
            }
            double sum = 0;

            for (int i = 1; i <= numberN; i++)
            {
                Console.WriteLine("Enter number {0}", i);
                double numberToSum = double.Parse(Console.ReadLine());
                sum = sum + numberToSum;
            }
            Console.WriteLine("Sum of the entered {0} numbers ={1}", numberN, sum);

            // Example 2. No input.Program pick random numbers.

            Console.WriteLine('\n');
            Console.WriteLine("Example 2. No input.Program pick random number n and sums more random n numbers.");

            Random n = new Random(); 
            int numberForCount = n.Next(10); //Returns a non-negative random integer that is less than the specified maximum.

            Console.WriteLine("Picked random number from computer = "+numberForCount);

            double sumIntegers = 0;
            double sumDouble = 0;

            for (int j = 1; j <= numberForCount; j++)
            {
                int optionNumber = n.Next(1, 3); // Option 1 or 2
                int integerNumber = n.Next(-100,100); // number between -100 and 100
                double floatingNumber = n.NextDouble(); // Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.

                if (optionNumber==1)
                {
                    Console.WriteLine(integerNumber);
                    sumIntegers = sumIntegers + integerNumber;
                }
                if (optionNumber==2)
                {
                    Console.WriteLine("{0:0.00}",Math.Round(floatingNumber,2));
                    sumDouble = sumDouble + floatingNumber;
                }

             }
            Console.WriteLine("Sum of the entered {0} numbers ={1:0.00}", numberForCount, (sumIntegers+sumDouble));
        }
    }

