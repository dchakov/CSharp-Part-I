//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:
//numbers	result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16	
//even_product = 15

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please, enter n numbers separated by a space:");
        string lineToConvert = Console.ReadLine();
        int productEven = 1;
        int productOdd = 1;

        string[] words = lineToConvert.Split(' ');
        
            for (int i = 0; i < words.Length; i += 2)
            {
                int parsedWord = int.Parse(words[i]);
                productOdd *= parsedWord;
            }
            for (int i = 1; i < words.Length; i += 2)
			{
                int parsedWord = int.Parse(words[i]);
			    productEven *=parsedWord;
			}
       
        if (productEven == productOdd)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product={0}",productOdd);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", productOdd);
            Console.WriteLine("even_product = {0}", productEven);
        }
    }
}

