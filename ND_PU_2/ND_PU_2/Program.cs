using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_PU_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1," +
                " Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";
            string Manch = "Manchester United"; //padarom kintamaji, kad galetumem naudoti jo Length
 
            int zaidimuSkaicius = 0;
            int laimejimuSkaicius = 0;
            int pralaimejimuSkaicius = 0;
            int lygiosios = 0;
            int imustiIvarciai = 0;
            int praleistiIvarciai = 0;
            int visiImustiIvarciai = 0;
            int visiPraleistiIvarciai = 0;
            int count = 1;

            // naudojam Split funkcija su separatoriumi, kad isskaidyt stringa i dalis tarp kuriu ", " ir sukemsam i masyva
            string[] separator = { ", " };
            string[] resultsArray = results.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            zaidimuSkaicius = resultsArray.Length;

            //Parodom visus zaidimus atskirai
            foreach (string s in resultsArray)
            {               
                Console.WriteLine($"Zaidimas Nr {count}: {s} ");
                count++;
            }

            Console.WriteLine();

            // surandam zaidimu masyve mums reikalingus skaicius, juos konvertuojam i int, sudedam kur ka reikia
            // zodziu daug rasyt, zodziais lengviau paaiskint
            for (int i = 0; i < resultsArray.Length; i++)
            {
                if (resultsArray[i].IndexOf(Manch) != 0)
                {
                    imustiIvarciai = int.Parse(resultsArray[i].Substring(resultsArray[i].Length - 1, 1));
                    visiImustiIvarciai += imustiIvarciai;
                    praleistiIvarciai = int.Parse(resultsArray[i].Substring(resultsArray[i].IndexOf(Manch) - 2, 1));
                    visiPraleistiIvarciai += praleistiIvarciai;

                    if(imustiIvarciai > praleistiIvarciai)
                    {
                        laimejimuSkaicius++;
                    }
                    if (imustiIvarciai < praleistiIvarciai)
                    {
                        pralaimejimuSkaicius++;
                    }
                    if (imustiIvarciai == praleistiIvarciai)
                    {
                        lygiosios++;
                    }
                }
                else
                {
                    imustiIvarciai = int.Parse(resultsArray[i].Substring(resultsArray[i].IndexOf(Manch, 0) + Manch.Length + 1, 1));
                    visiImustiIvarciai += imustiIvarciai;
                    praleistiIvarciai = int.Parse(resultsArray[i].Substring(resultsArray[i].Length - 1, 1));
                    visiPraleistiIvarciai += praleistiIvarciai;

                    if (imustiIvarciai > praleistiIvarciai)
                    {
                        laimejimuSkaicius++;
                    }
                    if (imustiIvarciai < praleistiIvarciai)
                    {
                        pralaimejimuSkaicius++;
                    }
                    if (imustiIvarciai == praleistiIvarciai)
                    {
                        lygiosios++;
                    }
                }

            }           
            
            // isvedam rezultatus i konsole
            Console.WriteLine($"Zaidimu skaicius: {zaidimuSkaicius}");
            Console.WriteLine($"Laimejimu skaicius: {laimejimuSkaicius}");
            Console.WriteLine($"Pralaimejimu skaicius: {pralaimejimuSkaicius}");
            Console.WriteLine($"Lygiuju skaicius: {lygiosios}");
            Console.WriteLine($"Imustu ivarciu skaicius: {visiImustiIvarciai}");
            Console.WriteLine($"Praleistu ivarciu skaicius: {visiPraleistiIvarciai}");

            Console.ReadLine();
        }
    }
}
