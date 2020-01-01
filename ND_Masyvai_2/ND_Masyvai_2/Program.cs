using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 1, 2, 3, 4, 5 };

            foreach(int elementas in masyvas)
            {
                Console.WriteLine(elementas);
            }

            Console.ReadLine();
        }
    }
}
