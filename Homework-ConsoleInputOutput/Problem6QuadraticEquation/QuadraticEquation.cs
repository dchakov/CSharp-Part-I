//Problem 6. Quadratic Equation
//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Examples:
//a	b	c	roots
//2	5	-3	x1=-3; x2=0.5
//-1	3	0	x1=3; x2=0
//-0.5	4	-8	x1=x2=4
//5	2	8	no real roots

using System;
using System.Threading;
using System.Globalization;

    class QuadraticEquation
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter coefficient A:");
            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter coefficient B:");
            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter coefficient C:");
            double numberC = double.Parse(Console.ReadLine());

            double discriminant = (numberB * numberB) - (4 * numberA * numberC); // Δ = b2 - 4ac

            if (discriminant<0)
            {
                Console.WriteLine("No real roots"); //When Δ<0, there are no real roots, there are 2 complex roots x1=(-b+i√-Δ)/(2a) and x2=(-b-i√-Δ)/(2a).
            }
            else if (discriminant == 0)
	        {
                double rootX1 = (-numberB + Math.Sqrt(discriminant)) / (2 * numberA); // When Δ=0, there is one root x1=x2=-b/(2a).
                double rootX2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("Roots x1=x2={0}", rootX1);
	        }
            else
            {
                double rootX1 = (-numberB + Math.Sqrt(discriminant))/(2*numberA); // When Δ>0, there are 2 real roots x1=(-b+√Δ)/(2a) and x2=(-b-√Δ)/(2a).
                double rootX2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA);
                Console.WriteLine("Roots x1={0}; x2={1}",rootX2, rootX1);
            }
        }
    }

