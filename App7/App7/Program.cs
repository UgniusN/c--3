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
            int a;
            String b;
            String pasirinkimas;
            int skaicius;
            for (; ; )
            {
                Console.WriteLine("Iveskite skaiciu: ");
                b = Console.ReadLine();
                a = Convert.ToInt32(b);
                for (int j = 0; j<=a; j++)
                {
                    skaicius = j * a;
                    Console.WriteLine();
                    Console.Write("{0} ", skaicius);
                }
                Console.WriteLine("Testi (taip / ne)");
                pasirinkimas = Console.ReadLine();
                if (pasirinkimas == "ne")
                    break;
                else if (pasirinkimas == "taip")
                    Console.WriteLine("Tesiama pagal prasyma");
                else
                    Console.WriteLine("Neteisingas pasirinkimas");
            }
            Console.ReadLine();
        }
    }
}
