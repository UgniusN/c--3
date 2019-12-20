using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu: ");
            String b = Console.ReadLine();
            int a = Convert.ToInt32(b);
            for (int i=0; i<a; i+=2)
            {
                Console.Write("{0},", i);
            }
            Console.Read();
        }
    }
}
