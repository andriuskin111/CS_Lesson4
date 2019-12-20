using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(1, 100);
            }

            for (int i = 0; i < 0; i++)
            {
                int maziausiai = skaiciai[i];
            }
        }
    }
}
