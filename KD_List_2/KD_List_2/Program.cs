using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentuSarasas = new List<string>();
            studentuSarasas.Add("Antanas Juknevicius");
            studentuSarasas.Add("Vaidotas Zala");
            studentuSarasas.Add("Benediktas Vanagas");
            studentuSarasas.Add("Edvardas Lucevicius");
            studentuSarasas.Add("Vytautas Svedas");

            List<string> studentuSarasasPavelavusiu = new List<string>();
            studentuSarasasPavelavusiu.Add("Andrius Petrauskas");
            studentuSarasasPavelavusiu.Add("Vladas Ciunelis");
            studentuSarasasPavelavusiu.Add("Eldar Ushadov");

            Console.WriteLine("Studentu sarasas:");
            parodytiSarasa();
            Console.WriteLine();

            studentuSarasas.AddRange(studentuSarasasPavelavusiu);
            Console.WriteLine("Papildytas studentu sarasas:");
            parodytiSarasa();
            Console.WriteLine();

            studentuSarasas.Sort();
            Console.WriteLine("Surusiuotas studentu sarasas:");
            parodytiSarasa();

            void parodytiSarasa()
            {
                foreach (var item in studentuSarasas)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
