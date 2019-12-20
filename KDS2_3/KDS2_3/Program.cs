using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ivestiSkaiciai = new double[5];
            double[] skaiciai = new double[ivestiSkaiciai.Length];

            for (int i = 0; i < ivestiSkaiciai.Length; i++)

            {
                Console.WriteLine($"Iveskite {i + 1} skaiciu:");
                ivestiSkaiciai[i] = Convert.ToDouble(Console.ReadLine());
                
            }

            Array.Copy(ivestiSkaiciai, 0, skaiciai, 0, 5);

            for (int i = 0; i < ivestiSkaiciai.Length; i++)
            {
                Console.Write(skaiciai[i]);
            }
            
            Console.ReadLine();
        }
    }
}
