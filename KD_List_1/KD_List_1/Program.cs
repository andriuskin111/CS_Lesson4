using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciuSarasas = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                skaiciuSarasas.Add(rnd.Next(1, 100));
            }

            foreach (var item in skaiciuSarasas)
            {
                if(item % 2 == 0)
                {
                    Console.WriteLine(item);
                }               
            }

            Console.ReadLine();
        }        
    }
}
