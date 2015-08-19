//Problem 3. Check for a Play Card• Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character
//Valid card sign?
//5 yes 
//1 no 
//Q yes 
//q no 
//P no 
//10 yes 
//500 no 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a character: ");
        string symbol = Console.ReadLine();

        int number;

        if (int.TryParse(symbol, out number)) // Try parse first if number or string 
        {
            if (number > 10 || number < 2)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
        else
        {
            if (symbol == "J")
            {
                Console.WriteLine("yes");
            }
            else if (symbol == "Q")
            {
                Console.WriteLine("yes");
            }
            else if (symbol == "K")
            {
                Console.WriteLine("yes");
            }
            else if (symbol == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}




