using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_5
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

            Console.Write("Atsitiktiniu skaiciu pirmas masyvas: ");

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                Console.Write($" {pirmasMasyvas[i]} ");
            }

            Console.WriteLine();
            Console.Write("Atsitiktiniu skaiciu antras masyvas: ");

            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                Console.Write($" {antrasMasyvas[i]} ");
            }

            Console.WriteLine();

            Array.Copy(pirmasMasyvas, 0, bendrasMasyvas, 0, pirmasMasyvas.Length);
            Array.Copy(antrasMasyvas, 0, bendrasMasyvas, pirmasMasyvas.Length, antrasMasyvas.Length);

            Array.Sort(bendrasMasyvas);

            Console.Write("Bendras surusiuotas masyvas: ");

            for (int i = 0; i < bendrasMasyvas.Length; i++)
            {
                Console.Write($" {bendrasMasyvas[i]} ");
            }

            Console.ReadLine();
        }
        }
    }

