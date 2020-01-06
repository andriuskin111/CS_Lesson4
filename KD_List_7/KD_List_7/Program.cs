using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sarasas = new List<int>();
            Random rnd = new Random();


            for (int i = 0; i < 100000; i++)
            {
                sarasas.Add(rnd.Next(1, 1000));
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();
            sarasas.Sort();
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine(elapsedMs);
            Console.ReadLine();
        }
    }
}
