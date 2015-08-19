//Problem 12.* Zero Subset• We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//• Assume that repeating the same subset several times is not a problem.
//Examples:
//numbers
//result
//3 -2 1 1 8 //-2 + 1 + 1 = 0 
//3 1 -7 35 22 no zero subset 
  
//1 3 -4 -2 -1
//1 + -1 = 0 
// 1 + 3 + -4 = 0 
// 3 + -2 + -1 = 0 
  
//1 1 1 -1 -1
//1 + -1 = 0 
// 1 + 1 + -1 + -1 = 0 
  
//0 0 0 0 0 0 + 0 + 0 + 0 + 0 = 0 
//Hint: you may check for zero each of the 32 subsets with 32  if  statements.

using System;

class ZeroSubset
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 5 integer numbers on a new lines");
        int[] myArray = new int[5];
        for (int i = 0; i < 5; i++)
        {
            myArray[i] = int.Parse(Console.ReadLine());
        }
        int count = 0;
        for (int i = 1; i <= Math.Pow(2, 5) - 1; i++)
        {
            int curentSum = 0;
            for (int j = 0; j < 5; j++)
            {
                int mask = 1 << j;        // 00000000 00100000
                int nAndMask = i & mask;  // 00000000 00100000
                int bit = nAndMask >> j;  // 00000000 00000001
                if (bit == 1)
                {
                    curentSum += myArray[j];
                }
            }
            if (curentSum == 0)
            {
                count++;
            }
        }
        if (count == 0)
        {
            Console.WriteLine("no zero subset");
        }
        else
        {
            Console.WriteLine("Number of subsets is:" + count);
        }   
    }
}

