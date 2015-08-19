﻿//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:
//a	b	c	sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1

using System;
using System.Threading;
using System.Globalization;

class SumOf3numbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            Console.WriteLine("Please, enter number A:");
            double numberA = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter number B:");
            double numberB = double.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter number C:");
            double numberC = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum of A + B + C = {0}",numberA+numberB+numberC);
        }
    }

