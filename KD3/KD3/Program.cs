using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] savaitesDienos = {
                "Pirmadienis",
                "Antradienis",
                "Treciadienis",
                "Ketvirtadienis",
                "Penktadienis",
                "Sestadienis",
                "Sekmadienis"
            };

            for (int i = 0; i < savaitesDienos.Length; i++)
            {
                Console.WriteLine(savaitesDienos[i]);
            }

            Console.ReadLine();
        }
    }
}
