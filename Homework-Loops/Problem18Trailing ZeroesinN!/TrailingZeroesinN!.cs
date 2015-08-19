//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:
//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why

using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.BufferHeight = Console.BufferHeight = 500;
        //http://math.stackexchange.com/questions/111385/derive-a-formula-to-find-the-number-of-trailing-zeroes-in-n
        // E5(n!) = N/5^1 + N/5^2 + N/5^3 + N/5^n;

        Console.WriteLine("Please, enter number");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        int powM = 5;
        int rezult = 0;

        while ((n / powM) >= 1)
        {
            rezult += n / powM;  // E5(n!) = N/5^1 + N/5^2 + N/5^3 + N/5^n;
            powM *= 5;
          
        }
        Console.WriteLine("trailing zeroes of n! = {0}", rezult);

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        Console.WriteLine(factorialN);

        //"If entered number is 1000 then max divider is 625 rezult is 1,6 (integer 1). 10 000 and 6250 an so on. rezult is 249999");
    }
}

