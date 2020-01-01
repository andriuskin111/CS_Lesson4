using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = new int[5];

            //irasome vartotojo ivestus duomenis i pirma masyva
            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.WriteLine($"Iveskite skaiciu nr {i + 1}");

                if (!int.TryParse(Console.ReadLine(), out skaiciuMasyvas[i]))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys \n");
                    i--;
                }
            }

            //isvedam i konsole nesurusiuota masyva
            Console.Write("Jusu ivestas masyvas: ");

            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.Write($" {skaiciuMasyvas[i]}");
            }

            Console.WriteLine();

            //surusiuojam ir isvedam masyva i konsole
            Array.Sort(skaiciuMasyvas);

            Console.Write($"Surusiuotas masyvas: ");

            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.Write($" {skaiciuMasyvas[i]}");
            }

            Console.ReadLine();

        }
    }
}
