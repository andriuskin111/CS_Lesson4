using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int visuElementuSuma = 0;
            int pirmaEilute = 0;
            int antraEilute = 0;
            int treciaEilute = 0;
            int pirmasStulpelis = 0;
            int antrasStulpelis = 0;
            int treciasStulpelis = 0;
            int[,] matrica = new int[3, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            suskaiciuotiElementuSuma();
            suskaiciuotiPirmaEilute();
            suskaiciuotiAntraEilute();
            suskaiciuotiTreciaEilute();
            suskaiciuotiPirmaStulpeli();
            suskaiciuotiAntraStulpeli();
            suskaiciuotitreciaStulpeli();

            Console.WriteLine($"Matricos elementu suma: {visuElementuSuma}");
            Console.WriteLine($"Pirmos eilutes suma: {pirmaEilute}");
            Console.WriteLine($"Antros eilutes suma: {antraEilute}");
            Console.WriteLine($"Trecios eilutes suma: {treciaEilute}");
            Console.WriteLine($"Pirmo stulpelio suma: {pirmasStulpelis}");
            Console.WriteLine($"Antro stulpelio suma: {antrasStulpelis}");
            Console.WriteLine($"Trecio stulpelio suma: {treciasStulpelis}");

            Console.ReadLine();

            void suskaiciuotiElementuSuma()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        visuElementuSuma += matrica[i, k];
                    }
                }
            }

            void suskaiciuotiPirmaEilute()
            {
                for (int i = 0; i < 3; i++)
                {
                    pirmaEilute += matrica[0, i];
                }
            }

            void suskaiciuotiAntraEilute()
            {
                for (int i = 0; i < 3; i++)
                {
                    antraEilute += matrica[1, i];
                }
            }

            void suskaiciuotiTreciaEilute()
            {
                for (int i = 0; i < 3; i++)
                {
                    treciaEilute += matrica[2, i];
                }
            }

            void suskaiciuotiPirmaStulpeli()
            {
                for (int i = 0; i < 3; i++)
                {
                    pirmasStulpelis += matrica[i, 0];
                }
            }

            void suskaiciuotiAntraStulpeli()
            {
                for (int i = 0; i < 3; i++)
                {
                    antrasStulpelis += matrica[i, 1];
                }
            }

            void suskaiciuotitreciaStulpeli()
            {
                for (int i = 0; i < 3; i++)
                {
                    treciasStulpelis += matrica[i, 2];
                }
            }
        }
    }
}
