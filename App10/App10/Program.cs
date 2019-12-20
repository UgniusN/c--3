using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
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

            for (int i=0; i<savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }
            Console.Read();
        }
    }
}
