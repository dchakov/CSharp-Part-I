using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9_PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 9; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + 2);
                }
                else
                {
                    Console.WriteLine(-i - 2);
                }
            }
        }

     }
}
