using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = { 2, 7, 19, 50, -4, -7, 11, -4, 2, 7 };

            Console.Write("Nesurusiuotas masyvas: ");

            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.Write($" {skaiciuMasyvas[i]} ");
            }

            Console.WriteLine();

            surusiuotiMasyva();

            Console.Write("Surusiuotas masyvas: ");

            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                Console.Write($" {skaiciuMasyvas[i]} ");
            }

            Console.ReadLine();

            void surusiuotiMasyva()
            {
                for (int i = 0; i < skaiciuMasyvas.Length - 1; i++)
                {
                    for (int k = i + 1; k < skaiciuMasyvas.Length; k++)
                    {
                        if (skaiciuMasyvas[i] > skaiciuMasyvas[k])
                        {
                            (skaiciuMasyvas[i], skaiciuMasyvas[k]) = (skaiciuMasyvas[k], skaiciuMasyvas[i]);
                        }
                    }
                }
            }
        }
    }
}
