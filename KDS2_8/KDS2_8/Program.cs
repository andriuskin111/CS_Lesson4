using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciuMasyvas = new int[] { 1, 9, 6, 7, 5, 9 , 12, 15, 90, 2, -1};

            surusiuotiMasyva();

            Console.WriteLine($"Antras didziausiai skaicius: {skaiciuMasyvas[skaiciuMasyvas.Length - 2]}");
            Console.WriteLine($"Antras maziausias skaicius: {skaiciuMasyvas[1]}");
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
