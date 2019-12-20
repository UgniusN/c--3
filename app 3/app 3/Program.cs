using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String tekstas = "C#Kursas";
            for (int i = 0; i < tekstas.Length; i++)
            {
                char a = tekstas[i];
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
