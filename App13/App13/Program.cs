using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[5];
            String a;
            int b;
            int suma=0;
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                a = Console.ReadLine();
                b = Convert.ToInt32(a);
                skaiciai[i] = b;
            }
            for(int i=0; i<5; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine(suma);
            Console.Read();
        }
    }
}
