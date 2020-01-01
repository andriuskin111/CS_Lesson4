using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] masyvas = { "a", "b", "c", "d", "e", "f" };

            //for (int i = 0; i < masyvas.Length; i++)
            //{
            //    Console.Write($"{masyvas[i]} ");
            //}

            for (int i = masyvas.Length - 1; i >= 0; i--)
            {
                Console.Write($"{masyvas[i]} ");
            }

            Console.ReadLine();
        }
    }
}
