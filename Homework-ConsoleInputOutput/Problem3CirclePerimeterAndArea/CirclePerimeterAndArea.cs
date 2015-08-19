//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:
//r	perimeter	area
//2	12.57	12.57
//3.5	21.99	38.48

using System;
using System.Threading;
using System.Globalization;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter radius r of a circle:");
            double numberR = double.Parse(Console.ReadLine());

            double perimeter = 2*Math.PI*numberR;
            double area = Math.PI*numberR*numberR;
            Console.WriteLine("The perimeter of a circle with radius {0} is :{1:0.00}", numberR, perimeter);
            Console.WriteLine("The area of a circle with radius {0} is :{1:0.00}", numberR, area);
        }
    }

