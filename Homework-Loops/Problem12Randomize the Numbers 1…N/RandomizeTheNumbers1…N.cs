//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:
//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number n");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = 1+i; // Add numbers from 1 to n in array
        }
        
        Random m = new Random();
        int indexToexchange1;
        int indexToExchange2;

        for (int i = 0; i < n; i++)  // Exchange random 2 numbers
        {
            indexToexchange1 = m.Next(0, n);
            indexToExchange2 = m.Next(0, n);

            if (indexToexchange1 != indexToExchange2)
            {
                array[indexToexchange1] = array[indexToexchange1] + array[indexToExchange2]; // a=a+b
                array[indexToExchange2] = array[indexToexchange1] - array[indexToExchange2]; // b=a-b
                array[indexToexchange1] = array[indexToexchange1] - array[indexToExchange2]; // a=a-b
            }
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
