using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sakini: ");
            String a = Console.ReadLine();
            int ilgis = a.Length-1;
            char b;
            while (ilgis >= 0)
            {
                b = a[ilgis];
                ilgis--;
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
