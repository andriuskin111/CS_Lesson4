using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirmasMasyvas = new int[10];
            int[] antrasMasyvas = new int[10];
            int[] bendrasMasyvas = new int[pirmasMasyvas.Length + antrasMasyvas.Length];

            Random rnd = new Random();

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                pirmasMasyvas[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                antrasMasyvas[i] = rnd.Next(1, 100);
            }

            Array.Copy(pirmasMasyvas, 0, bendrasMasyvas, 0, pirmasMasyvas.Length);
            Array.Copy(antrasMasyvas, 0, bendrasMasyvas, pirmasMasyvas.Length, antrasMasyvas.Length);

            var elementuGrupe = bendrasMasyvas.GroupBy(v => v);

            Console.Write("Atsitiktiniu skaiciu masyvas: ");

            for (int i = 0; i < bendrasMasyvas.Length; i++)
            {
                Console.Write($" {bendrasMasyvas[i]} ");
            }

            Console.WriteLine();

            foreach(var grupe in elementuGrupe)
            {
                Console.WriteLine($"Elementas {grupe.Key} kartojasi {grupe.Count()} kartu");
            }

            Console.ReadLine();
        }
    }
}
