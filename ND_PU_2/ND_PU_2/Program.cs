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
 
            int zaidimuSkaicius = 0;
            //int laimejimuSkaicius = 0;
            //int pralaimejimuSkaicius = 0;
            int imustiIvarciai = 0;
            //int praleisyiIvarciai = 0;



            string[] separator = { ", " };
            //int sepCount = 5;

            string[] resultsArray = results.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            zaidimuSkaicius = resultsArray.Length;

            foreach (string s in resultsArray)
            {
                Console.WriteLine(s);
            }

            int start, stop;

            for (int i = 0; i < resultsArray.Length; i++)
            {
                start  = resultsArray[i].IndexOf("Manchester", 0) + 18;
                stop = resultsArray[i].IndexOf("United") + 8;
                imustiIvarciai += int.Parse(resultsArray[i].Substring(start, stop - start));
               // Console.WriteLine(resultsArray[i].Substring(start, stop - start));
            }

            
            Console.WriteLine($"Imustu ivarciu skaicius: {imustiIvarciai}");
            Console.WriteLine($"Zaidimu skaicius: {zaidimuSkaicius}");

            Console.ReadLine();
        }
    }
}
