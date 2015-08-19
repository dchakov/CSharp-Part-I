using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem16_PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            {
                Console.SetBufferSize(85, 1003);
            }
                for (int i = 0; i <= 999; i++)
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
            {
                Console.WriteLine("The current buffer height is {0} rows.",
                                  Console.BufferHeight);
                Console.WriteLine("The current buffer width is {0} columns.",
                                  Console.BufferWidth);
            }
        }
    }
}
