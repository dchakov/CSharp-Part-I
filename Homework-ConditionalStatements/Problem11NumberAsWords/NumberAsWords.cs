//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:
//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number [0...999]");
        string enteredNumber = Console.ReadLine();

        int firstLeftToRight = 0;
        int secondLeftTpRight = 0;
        int thirdLeftToRight = 0;

        string[] numbersZeroTwenty ={"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"
        , "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen", "Twenty"};

        string[] numbersTwentyHundred = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        int number;
        if (int.TryParse(enteredNumber, out number))
        {
            firstLeftToRight = (number / 100) % 10;
            secondLeftTpRight = (number / 10) % 10;
            thirdLeftToRight = number % 10;


            if ((number >= 0) && (number <= 20))
            {
                Console.WriteLine(numbersZeroTwenty[number]);
            }
            else if ((number > 20) && (number <= 99))
            {
                Console.WriteLine(numbersTwentyHundred[secondLeftTpRight - 2] + " " + numbersZeroTwenty[thirdLeftToRight].ToLower());
            }
            else if ((number > 99) && (number <= 999))
            {
                if (secondLeftTpRight == 0 && thirdLeftToRight == 0)
                {
                    Console.WriteLine(numbersZeroTwenty[firstLeftToRight] + " hundred");
                }
                else if ((secondLeftTpRight * 10 + thirdLeftToRight) > 0 && (secondLeftTpRight * 10 + thirdLeftToRight) <= 20)
                {
                    Console.WriteLine(numbersZeroTwenty[firstLeftToRight] + " hundred and " + numbersZeroTwenty[secondLeftTpRight * 10 + thirdLeftToRight].ToLower());
                }
                else
                {
                    Console.WriteLine(numbersZeroTwenty[firstLeftToRight] + " hundred and " + numbersTwentyHundred[secondLeftTpRight - 2].ToLower() + " " + numbersZeroTwenty[thirdLeftToRight].ToLower());
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid number", enteredNumber);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number", enteredNumber);
        }
    }
}


