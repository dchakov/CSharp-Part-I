using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

namespace Problem7_QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string firstStringVar = "The \"use\" of quotations causes difficulties.";
            string secondStringVar =@"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstStringVar);
            Console.WriteLine(secondStringVar);
        }
    }
}
