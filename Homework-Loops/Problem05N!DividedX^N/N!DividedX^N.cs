//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.
//Examples:
//n	x	S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter number n followed by x each on new line");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double sumS = 1;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sumS = sumS + factorial / Math.Pow(x, i); //S = 1 + 1!/x + 2!/x2 + … + n!/x^n
        }
        Console.WriteLine("S = {0:0.00000}",sumS);
    }
}

