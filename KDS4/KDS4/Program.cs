using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS4
{
    class Program
    {
        static void Main(string[] args)
        {
            double skaicius;
            double rezultatas;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("iveskite skaiciu:");

                if(!double.TryParse(Console.ReadLine(), out skaicius))
                {
                    Console.WriteLine("Ivesti neteisingi duomenys");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.WriteLine("Ivesto skaiciaus daugybos lentele:");

                for (int i = 1; i < 11; i++)
                {
                    rezultatas = skaicius * i;
                    Console.WriteLine(skaicius + " x " + i + " = " + rezultatas);
                }

                Console.WriteLine();
                Console.WriteLine("Testi betkoks mygtukas, Baigti spauskite [n]");
                string klaviatura = Console.ReadLine();

                if(klaviatura == "n")
                {
                    break;
                }

            }

        }
    }
}
