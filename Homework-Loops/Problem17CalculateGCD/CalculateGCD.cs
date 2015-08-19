//Problem 17.* Calculate GCD• Write a program that calculates the greatest common divisor (GCD) of given two integers  a  and  b .
//• Use the Euclidean algorithm (find it in Internet).
//Examples:
//a
//b
//GCD(a, b)
//3 2 1 
//60 40 20 
//5 -15 5 

using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        //http://en.wikipedia.org/wiki/Euclidean_algorithm
        //a = q0 b + r0
        //b = q1 r0 + r1
        //r0 = q2 r1 + r2
        //r1 = q3 r2 + r3

        Console.WriteLine("Please, enter two integers on separate lines");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int q = 0;
        int rezult = 0;

        while (b != 0)
        {
            q = a % b;
            a = b;
            if (b != 0)
            {
                rezult = b;
            }
            b = q;
        }
        Console.WriteLine(rezult);
    }
}
