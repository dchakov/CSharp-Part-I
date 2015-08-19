//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
//Examples:
//n	Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Please, enter number n on new line");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = n + 2 ; i <= 2*n; i++)
        {
            factorialN *= i;
        }
        for (int i = 1; i <= n ; i++)
        {
          factorialK *= i;  
        }
        Console.WriteLine(factorialN/factorialK);
    }
}
