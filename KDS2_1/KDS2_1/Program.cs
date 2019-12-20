using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] skaiciai = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iveskite {i + 1} skaiciu:");
                skaiciai[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = skaiciai.Length - 1; i >= 0; i--)
            {
                Console.Write(skaiciai[i]);
            }
          //  Console.WriteLine(skaiciai[1]);
            Console.ReadLine();
        }
    }
}
