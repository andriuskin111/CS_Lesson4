using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirmasMasyvas = new int[10];
            int indeksas;
            
            Random rnd = new Random();

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                pirmasMasyvas[i] = rnd.Next(1, 100);
            }

            Console.Write("Atsitiktiniu skaiciu masyvas: ");

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                Console.Write($" {pirmasMasyvas[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("Pasirinkite masyvo elementa kuri norite istrinti: ");

            indeksas = int.Parse(Console.ReadLine());

            for (int i = indeksas; i < pirmasMasyvas.Length - 1; i++)
            {
                pirmasMasyvas[i] = pirmasMasyvas[i + 1];
            }

            Array.Resize(ref pirmasMasyvas, pirmasMasyvas.Length - 1);

            int[] antrasMasyvas = new int[pirmasMasyvas.Length];

            Array.Copy(pirmasMasyvas, 0, antrasMasyvas, 0, pirmasMasyvas.Length);

            Console.Write("Masyvas be istrinto elemento: ");

            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                Console.Write($" {antrasMasyvas[i]} ");
            }

            Console.ReadLine();
        }
    }
}
