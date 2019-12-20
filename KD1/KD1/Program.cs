using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 10 - 1; i >= 0; i--)
            {
                Console.WriteLine($"Reiksme i: {i}");
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
