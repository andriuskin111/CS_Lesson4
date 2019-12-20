using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sakinys = Console.ReadLine();

            for (int i = sakinys.Length - 1; i >= 0; i--)
            {
                char simbolis = sakinys[i];
                Console.Write(simbolis);
            }

            Console.ReadLine();
        }
    }
}
