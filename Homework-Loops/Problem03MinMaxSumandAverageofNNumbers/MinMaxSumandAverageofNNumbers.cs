//Problem 3. Min, Max, Sum and Average of N Numbers• Write a program that reads from the console a sequence of  n  integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//• The input starts by the number  n  (alone in a line) followed by  n  lines, each holding an integer number.
//• The output is like in the examples below.
//Example 1:
//input
//output
//3 min = 1 
//2 max = 5 
//5 sum = 8 
//1 avg = 2.67 
//Example 2:
//input
//output
//2 min = -1 
//-1 max = 4 
//4 sum = 3 
// avg = 1.50 

using System;

class MinMaxSumandAverageofNNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number n  (alone in a line) followed by  n  lines");
        int n = int.Parse(Console.ReadLine());    
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", (double)sum / n);
    }
}

