using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Andrius";
            for (int i = 0; i < vardas.Length; i++)
            {
                Console.Write($"{vardas[i]} ");
            }

            Console.WriteLine();

            for (int i = vardas.Length - 1; i >= 0; i--)
            {
                Console.Write($"{vardas[i]} ");
            }

            Console.ReadLine();
        }
    }
}
