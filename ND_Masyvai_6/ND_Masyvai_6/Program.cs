using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = new int[100];
            int maziausiasSkaicius = 0;
            int didziausiasSkaicius = 0;

            Random rnd = new Random();

            for (int i = 0; i < skaiciuMasyvas.Length; i++)
            {
                skaiciuMasyvas[i] = rnd.Next(1, 1000);
            }

            rastiMaziausiaSkaiciu();
            rastiDidziausiaSkaiciu();

            Console.WriteLine($"Maziausias skaicius yra: {maziausiasSkaicius}");
            Console.WriteLine($"Didziausias skaicius yra: {didziausiasSkaicius}");

            Console.ReadLine();

            int rastiMaziausiaSkaiciu()
            {
                maziausiasSkaicius = skaiciuMasyvas[0];

                for (int i = 0; i < skaiciuMasyvas.Length - 1; i++)
                {
                    if (maziausiasSkaicius >= skaiciuMasyvas[i + 1])
                    {
                        maziausiasSkaicius = skaiciuMasyvas[i + 1];
                    }
                }

                return maziausiasSkaicius;
            }



            int rastiDidziausiaSkaiciu()
            {
                didziausiasSkaicius = skaiciuMasyvas[0];

                for (int i = 0; i < skaiciuMasyvas.Length - 1; i++)
                {
                    if (didziausiasSkaicius <= skaiciuMasyvas[i + 1])
                    {
                        didziausiasSkaicius = skaiciuMasyvas[i + 1];
                    }
                }

                return didziausiasSkaicius;
            }
        }
    }
}
