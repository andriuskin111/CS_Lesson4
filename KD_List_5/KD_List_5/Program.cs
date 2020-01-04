using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arIeina = true;
            int startIndex;

            List<int> pirmasSarasas = new List<int>();
            pirmasSarasas.Add(1);
            pirmasSarasas.Add(2);
            pirmasSarasas.Add(4);
            pirmasSarasas.Add(8);
            pirmasSarasas.Add(16);

            List<int> antrasSarasas = new List<int>();
            antrasSarasas.Add(2);
            antrasSarasas.Add(4);
            antrasSarasas.Add(8);

            startIndex = pirmasSarasas.IndexOf(antrasSarasas.ElementAt(0));

            int count = 0;

            foreach (var item in antrasSarasas)
            {
                if (!pirmasSarasas.Contains(item))
                {
                    arIeina = false;
                }
                else
                {                   
                    if(pirmasSarasas.ElementAt(startIndex) != antrasSarasas.ElementAt(count))
                    {
                        Console.WriteLine("ok");
                        arIeina = false;                       
                    }
                    count++;
                    startIndex++;
                }
            }

            if(arIeina == true)
            {
                Console.WriteLine("Antras sarasas ieina i pirma");
            }
            else
            {
                Console.WriteLine("Antras sarasas neieina i pirma");
            }

            Console.ReadLine();
        }
    }
}
