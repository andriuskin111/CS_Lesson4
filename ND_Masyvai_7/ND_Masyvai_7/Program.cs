using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirmasMasyvas = new int[5];
            int[] antrasMasyvas = new int[pirmasMasyvas.Length];

            //irasome vartotojo ivestus duomenis i pirma masyva
            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                Console.WriteLine($"Iveskite skaiciu nr {i + 1}");

                if (!int.TryParse(Console.ReadLine(), out pirmasMasyvas[i]))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys \n");
                    i--;
                }
            }

            //isvedam i konsole pirma masyva
            Console.Write("Jusu ivestas masyvas: ");

            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                Console.Write($" {pirmasMasyvas[i]}");
            }

            Console.WriteLine();

            //kopojuojam pirma masyva i antra
            for (int i = 0; i < pirmasMasyvas.Length; i++)
            {
                antrasMasyvas[i] = pirmasMasyvas[i];
            }

            //isvedam nukopijuota masyva i konsole
            Console.Write("Nukopijuotas masyvas: ");

            for (int i = 0; i < antrasMasyvas.Length; i++)
            {
                Console.Write($" {antrasMasyvas[i]}");
            }

            Console.ReadLine();
        }
    }
}
