using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem17_PlayWithDebugger
{
    class PlayWithDebugger
    {
        static void Main(string[] args)
        {
            {
                Console.SetBufferSize(85, 1001);
            }
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
