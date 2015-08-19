using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;

//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©
//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

namespace Problem8_IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Currency Symbol: {0}", NumberFormatInfo.CurrentInfo.CurrencySymbol);
            Console.WriteLine("Change console Culture to English");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
            Console.WriteLine("Currency Symbol: {0}", NumberFormatInfo.CurrentInfo.CurrencySymbol);

            // Set the Console font to "Lucida Console" from Raster Fonts.

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            char symbol = '\u00a9';
            Console.WriteLine(" " + " " + " " + symbol);
            Console.WriteLine(" " + " " + symbol + " " + symbol);
            Console.WriteLine(" " + symbol + " " + " " + " " + symbol);
            Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
         }

    }
}
