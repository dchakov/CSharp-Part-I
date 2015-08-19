//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
//Examples:
//numbers	sum
//1 2 3 4 5	15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1 0	11.84

using System;
using System.Threading;
using System.Globalization;

    class SumOf5Numbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter 5 numbers separated by a space:");
            string lineToConvert = Console.ReadLine();
            double sum = 0;

            string[] words = lineToConvert.Split(' ');
            foreach (string word in words)
            {
                double parsedWord = double.Parse(word);
                sum = sum + parsedWord;
            }
            Console.WriteLine("Sum of the numbers = {0}",sum);
        }
    }
