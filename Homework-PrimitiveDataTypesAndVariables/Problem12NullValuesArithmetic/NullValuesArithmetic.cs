using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

namespace Problem12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? integerNullValue = null;
            double? doubleNullValue = null;

            Console.WriteLine("This is integer with NULL value -> {0}",integerNullValue);
            Console.WriteLine("This is double with NULL value -> {0}", doubleNullValue);
            Console.WriteLine("\n");

            Console.WriteLine("Add some number to null values");
            integerNullValue = integerNullValue + 5;
            doubleNullValue = doubleNullValue + 0.4;
            Console.WriteLine("Null integer + number={0}",integerNullValue);
            Console.WriteLine("Null double + number={0}", doubleNullValue);
            Console.WriteLine("\n");

            Console.WriteLine("Check if variables has values");
            Console.WriteLine(integerNullValue.HasValue);
            Console.WriteLine(doubleNullValue.HasValue);
            Console.WriteLine("\n");

            Console.WriteLine("Assigne number to integer with NULL value");
            integerNullValue = 5;
            doubleNullValue = 0.4;
            Console.WriteLine(integerNullValue);
            Console.WriteLine(doubleNullValue);
        }
    }
}
