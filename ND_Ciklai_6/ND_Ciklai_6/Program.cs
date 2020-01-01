using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Ciklai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write($"{i}x{k}={i * k}, ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
