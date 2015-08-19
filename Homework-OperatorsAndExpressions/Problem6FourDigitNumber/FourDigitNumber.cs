using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6. Four-Digit Number• 
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011)
//and performs the following: ◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
//◦ Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
//◦ Puts the last digit in the first position:  dabc  (in our example  1201 ).
//◦ Exchanges the second and the third digits:  acbd  (in our example  2101 ).


//The number has always exactly 4 digits and cannot start with 0.
//Examples:
//n
//sum of digits
//reversed
//last digit in front
//second and third digits exchanged

//2011 4 1102 1201 2101 
//3333 12 3333 3333 3333 
//9876 30 6789 6987 9786 


namespace Problem6FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter four digit number:");
            string stringOfNumber = Console.ReadLine(); // If number entered is 01234 five digits with 1-st 0.
            int enteredNumber = int.Parse(stringOfNumber); // 01234 entered  = 1234. When check if begins 0 true
            
            int firstLeftToRight = (enteredNumber / 1000) % 10;
            int secondLeftTpRight = (enteredNumber / 100) % 10;
            int thirdLeftToRight = (enteredNumber / 10) % 10;
            int fourthLeftToRight = enteredNumber % 10;
            int sumFourdDigits = firstLeftToRight + secondLeftTpRight + thirdLeftToRight + fourthLeftToRight;

            //Check
            //The number has always exactly 4 digits and cannot start with 0.
            //If enter number 01234 int.Parse 1234. We need second variable string

            if ((firstLeftToRight != 0) && (stringOfNumber.Length==4))
            {
                Console.WriteLine("Sum of digits:" + sumFourdDigits);
                Console.WriteLine("Reversed:" + fourthLeftToRight + thirdLeftToRight + secondLeftTpRight + firstLeftToRight);
                Console.WriteLine("Last digit in front:" + fourthLeftToRight + firstLeftToRight + secondLeftTpRight + thirdLeftToRight);
                Console.WriteLine("Second and third digits exchanged:" + firstLeftToRight + thirdLeftToRight + secondLeftTpRight + fourthLeftToRight);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("The number have to be exactly four digits and cannot start with 0");
            }
        }
    }
}
