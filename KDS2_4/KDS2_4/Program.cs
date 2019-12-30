using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rndSkaiciai = new int[10];
            int[] surusiuotiSkaiciai = new int[10];
            int didziausiasSkaicius = 0;
            int maziausiasSkaicius = 0;

            Random rnd = new Random();

            for (int i = 0; i < rndSkaiciai.Length; i++)
            {
                rndSkaiciai[i] = rnd.Next(1, 100);
            }

            Console.Write("Atsitiktiniu skaiciu masyvas: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {rndSkaiciai[i]} ");
            }

            rastiMaziausiaSkaiciu();
            rastiDidziausiaSkaiciu();
            surusiuotiMasyva();

            Console.WriteLine();
            Console.WriteLine($"Maziausias skaicius yra: {maziausiasSkaicius}");
            Console.WriteLine($"Didziausias skaicius yra: {didziausiasSkaicius}");

            Console.Write("Surusiuotu skaiciu masyvas: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {surusiuotiSkaiciai[i]} ");
            }

            Console.ReadLine();

            int rastiMaziausiaSkaiciu()
            {
                maziausiasSkaicius = rndSkaiciai[0];

                for (int i = 0; i < rndSkaiciai.Length - 1; i++)
                {
                    if (maziausiasSkaicius >= rndSkaiciai[i + 1])
                    {
                        maziausiasSkaicius = rndSkaiciai[i + 1];
                    }
                }

                return maziausiasSkaicius;
            }

            int rastiDidziausiaSkaiciu()
            {
                didziausiasSkaicius = rndSkaiciai[0];

                for (int i = 0; i < rndSkaiciai.Length - 1; i++)
                {
                    if (didziausiasSkaicius <= rndSkaiciai[i + 1])
                    {
                        didziausiasSkaicius = rndSkaiciai[i + 1];
                    }
                }

                return didziausiasSkaicius;
            }

            void surusiuotiMasyva()
            {
                Array.Sort(rndSkaiciai);

                for (int i = 0; i < rndSkaiciai.Length; i++)
                {
                    surusiuotiSkaiciai[i] = rndSkaiciai[i];
                }
            }
        }
    }
}
