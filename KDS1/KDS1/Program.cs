using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");
            double skaicius = double.Parse(Console.ReadLine());

            for(int i = 1; i <= skaicius; i++)
            {
                double suma = skaicius + i;
                Console.WriteLine($"{skaicius} + {i} = {suma}");
            }

            Console.ReadLine();
        }
    }
}
