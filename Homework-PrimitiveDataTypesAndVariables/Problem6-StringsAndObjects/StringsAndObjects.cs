using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

namespace Problem6_StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstStringVar = "Hello";
            string secondStringVar = "World";
            object result = firstStringVar + " " + secondStringVar;
            string thirdStringVar = (string)result;
            Console.WriteLine(result);
            Console.WriteLine(thirdStringVar);
        }
    }
}
