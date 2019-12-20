using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; ++i)
            {
                Thread.Sleep(100);
                Console.Write("\r{0}%", i);
                Console.SetCursorPosition(0, 1);
                for (int x = 0; x<=i; x++)
                {
                    Console.Write("#");
                }
                Console.SetCursorPosition(0, 0);
            }
            Console.Read();
        }
    }
}
