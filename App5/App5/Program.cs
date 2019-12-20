using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu a");
            String b = Console.ReadLine();
            int a = Convert.ToInt32(b);
            int sum = 1;
            for (int i = 1; i<=a-1; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
