using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] savaitesDienos =
{
                "pirmadienis",
                "antradienis",
                "treciadienis",
                "ketvirtadienis",
                "penktadienis",
                "sestadienis",
                "sekmadienis"
            };

            foreach(var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            savaitesDienos[2] = "TRECIADIENIS";
            Console.WriteLine("");
            Console.WriteLine("Po:");

            foreach(var diena in savaitesDienos)
            {
                Console.WriteLine(diena);
            }
            Console.Read();
        }
    }
}
