using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

namespace Problem9ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            // Example 1
            Console.WriteLine("Example 1");
            int a = 5;
            int b = 10;
            Console.WriteLine("Value of a before exchange is:" + a);
            Console.WriteLine("Value of b before exchange is:" + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Value of a after exchange is:" + a);
            Console.WriteLine("Value of b after exchange is:" + b);
            Console.WriteLine("\n");

            // Example 2
            Console.WriteLine("Example 2");
            int c = 5;
            int d = 10;
            Console.WriteLine("Value of c before exchange is:" + c);
            Console.WriteLine("Value of d before exchange is:" + d);
            int s = c;
            c = d;
            d = s;
            Console.WriteLine("Value of c after exchange is:" + c);
            Console.WriteLine("Value of d after exchange is:" + d);
        }
    }
}
