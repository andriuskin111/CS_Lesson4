using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int skaicius = 0;

            Console.WriteLine("Iveskite skaiciu");

            if (!int.TryParse(Console.ReadLine(), out skaicius))

            {
                Console.WriteLine("Ivesti neteisingi duomenys");
                Console.ReadLine();
                Environment.Exit(0);
            }

            for (int i = 0; i <= skaicius; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
