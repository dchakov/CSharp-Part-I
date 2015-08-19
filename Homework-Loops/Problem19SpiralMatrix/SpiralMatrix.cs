//Problem 19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7

using System;

class SpiralMatrix
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please, enter number n on new line");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int x = 0;
        int y = 0;
        int count = 1;
        int side = n;

        while (count <= n * n)
        {
            for (int i = 0; i < side; i++) //Right
            {
                matrix[x, y] = count;
                y++;
                count++;
            }
            x++;
            y--;
            side--; // cut first row 

            for (int i = 0; i < side; i++) //Down
            {
                matrix[x, y] = count;
                x++;
                count++;
            }
            y--;
            x--;

            for (int i = 0; i < side; i++) //Left
            {
                matrix[x, y] = count;
                y--;
                count++;
            }
            x--;
            y++;
            side--;
            for (int i = 0; i < side; i++) //Up
            {
                matrix[x, y] = count;
                x--;
                count++;
            }
            y++;
            x++;
           
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n ; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
        }
        Console.WriteLine();
    }
}

            //if (x == 0 && y < n)
            //{
            //    matrix[x, y] = count;
            //    y++;
            //    count++;
            //}
            //if (y == n - 1 && x < n)
            //{
            //    matrix[x, y] = count;
            //    x++;
            //    count++;
            //}
            //if (x == n - 1 && y > 0)
            //{
            //    matrix[x, y] = count;
            //    y--;
            //    count++;
            //}
            //if (x == n-1 && y > 0)
            //{
            //    matrix[x, y] = count;
            //    x--;
            //    count++;
            //}
           