using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 1, 2, 3, 4, 5 };
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                suma += masyvas[i];
            }

            Console.WriteLine(suma);

            Console.ReadLine();
        }
    }
}
