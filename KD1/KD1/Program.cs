using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 10 - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"Reiksme i: {i}");
            //}

            //for (char c = 'A'; c <= 'Z'; c++)
            //{
            //    Console.WriteLine(c);
            //}

            //String vardas = "C#Kursas";

            //for (int i = 0; i < vardas.Length; i++)
            //{
            //    char current = vardas[i];
            //    Console.WriteLine(current);
            //}

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100); // pause 100 ms
                Console.Write("#");
            }

            Console.ReadLine();
        }
    }
}
