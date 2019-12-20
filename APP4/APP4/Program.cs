using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("#");
            }
            Console.WriteLine();
            Console.WriteLine("Pabaiga");
            Console.Read();
        }
    }
}
