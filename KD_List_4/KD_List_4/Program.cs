using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int veiksmas;
            int pazymys;
            int indeksas;
            double vidurkis;
            List<int> pazymiuSarasas = new List<int>();

            while (true)
            {                
                if(pazymiuSarasas.Count() == 0)
                {
                    Console.WriteLine("Sarase nera pazymiu\n");
                }
                else
                {                    
                    parodytiSarasa();
                }

                Console.WriteLine("Galimi veiksmai:\n0 - papildyti\n1 - istrinti\n2 - iterpti\n" +
                    "3 - parodyti pazymiu vidurki\n4 - iseiti is programos");

                while (!int.TryParse(Console.ReadLine(), out veiksmas) || veiksmas > 4 || veiksmas < 0)
                {
                    Console.WriteLine("Ivesti neteisingi duomenys, bandykiste dar karta:");
                }

                if(veiksmas == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Iveskite pazymi nuo 0 iki 10:");

                    while (!int.TryParse(Console.ReadLine(), out pazymys) || pazymys > 10 || pazymys < 0)
                    {
                        Console.WriteLine("Ivesti neteisingi duomenys, bandykiste dar karta:");
                    }

                    pazymiuSarasas.Add(pazymys);
                    Console.WriteLine();
                }

                if (veiksmas == 1)
                {
                    if(pazymiuSarasas.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Veiksmas negalimas");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Iveskite pazymio kuri norite istrinti numeri sarase:");

                        while (!int.TryParse(Console.ReadLine(), out indeksas) || indeksas > pazymiuSarasas.Count || indeksas < 1)
                        {
                            Console.WriteLine("Ivesti neteisingi duomenys, bandykiste dar karta:");
                        }

                        pazymiuSarasas.RemoveAt(indeksas - 1);
                        Console.WriteLine();
                    }
                    
                }

                if (veiksmas == 2)
                {
                    if (pazymiuSarasas.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Veiksmas negalimas");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Iveskite numeri sarase kur bus iterptas pazymys:");

                        while (!int.TryParse(Console.ReadLine(), out indeksas) || indeksas > pazymiuSarasas.Count || indeksas < 1)
                        {
                            Console.WriteLine("Ivesti neteisingi duomenys, bandykiste dar karta:");
                        }

                        Console.WriteLine();
                        Console.WriteLine("Iveskite pazymi nuo 0 iki 10:");

                        while (!int.TryParse(Console.ReadLine(), out pazymys) || pazymys > 10 || pazymys < 0)
                        {
                            Console.WriteLine("Ivesti neteisingi duomenys, bandykiste dar karta:");
                        }

                        pazymiuSarasas.Insert(indeksas - 1, pazymys);
                        Console.WriteLine();
                    }
                   
                }

                if (veiksmas == 3)
                {
                    if (pazymiuSarasas.Count == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Veiksmas negalimas");
                    }
                    else
                    {
                        vidurkis = pazymiuSarasas.Average();
                        Console.WriteLine();
                        Console.WriteLine($"Pazymiu vidurkis yra: {vidurkis}");
                        Console.WriteLine();
                    }

                }

                if(veiksmas == 4)
                {
                    Environment.Exit(0);
                }

            }

            void parodytiSarasa()
            {
                Console.WriteLine("Pazymiu sarasas:");

                foreach (var item in pazymiuSarasas)
                {
                    Console.Write($" {item} ");
                }

                Console.WriteLine();
            }
        }
    }
}
