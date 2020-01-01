using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirmasMasyvas = { 1, 2, 3 };
            int[] antrasMasyvas = { 4, 5, 6 };
            int[] treciasMasyvas = new int[pirmasMasyvas.Length + antrasMasyvas.Length];

            //parodom pirma ir antra masyvus
            Console.Write("Pirmas masyvas: ");

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                Console.Write($" {pirmasMasyvas[i]}");
            }

            Console.WriteLine();
            Console.Write("Pirmas masyvas: ");

            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                Console.Write($" {antrasMasyvas[i]}");
            }

            Console.WriteLine();

            //kopijuojam pirma masyva i trecia
            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                treciasMasyvas[i] = pirmasMasyvas[i];
            }

            //kopijuojam antra masyva i trecia
            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                treciasMasyvas[i+ pirmasMasyvas.Length] = antrasMasyvas[i];
            }

            //parodom trecia masyva
            Console.Write("Trecias masyvas: ");

            for (int i = 0; i < treciasMasyvas.Length; i++)
            {
                Console.Write($" {treciasMasyvas[i]}");
            }

            Console.ReadLine();
        }
    }
}
