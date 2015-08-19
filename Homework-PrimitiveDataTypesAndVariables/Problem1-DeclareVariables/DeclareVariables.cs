using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

namespace Problem1_DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            ushort variable1 = 52130;
            sbyte variable2 = -115;
            uint variable3 = 4825932;
            byte variable4 = 97;
            short variable5 = -10000;

            Console.WriteLine("{0:N}",variable1);
            Console.WriteLine("{0:N}",variable2);
            Console.WriteLine("{0:N}",variable3);
            Console.WriteLine("{0:N}",variable4);
            Console.WriteLine("{0:N}",variable5);
        }
    }
}
