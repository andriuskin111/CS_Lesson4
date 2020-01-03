using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> varduSarasas = new List<string>();
            varduSarasas.Add("Natalija");
            varduSarasas.Add("Vytautas");
            varduSarasas.Add("Gabija");
            varduSarasas.Add("Vasia");
            varduSarasas.Add("Ieva");

            Console.WriteLine("Pirminis sarasas:");
            parodytiSarasa();
            Console.WriteLine();

            varduSarasas.Add("Napoleonas");
            varduSarasas.Add("Asterisas");
            Console.WriteLine("Papildytas sarasas:");
            parodytiSarasa();
            Console.WriteLine();

            varduSarasas.RemoveAt(varduSarasas.IndexOf("Napoleonas"));
            varduSarasas.Insert(varduSarasas.IndexOf("Ieva") + 1, "Kleopatra");
            Console.WriteLine("Redaguotas sarasas:");
            parodytiSarasa();

            void parodytiSarasa()
            {
                foreach (var item in varduSarasas)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
