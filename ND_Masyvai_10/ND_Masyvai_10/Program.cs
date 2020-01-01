using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_Masyvai_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = {
                "Andrius",
                "Giedrius",
                "Ieva",
                "Aleksandras",
                "Vilija",
                "Romanas",
                "Gintare",
                "Egle",
                "Vasia",
                "Paulina"
            };
            string[] isimtiVardai = new string[8];

            Array.Copy(vardai, 0, isimtiVardai, 0, 5);
            Array.Copy(vardai, 6, isimtiVardai, 5, 1);
            Array.Copy(vardai, 8, isimtiVardai, 6, 2);

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.WriteLine($"{i} {vardai[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < isimtiVardai.Length; i++)
            {
                Console.WriteLine($"{i} {isimtiVardai[i]}");
            }

            Console.ReadLine();
        }
    }
}
