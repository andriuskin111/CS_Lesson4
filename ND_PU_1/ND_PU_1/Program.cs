using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND_PU_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------pirmas budas (blogas)-----------------------------------------
            //string[,] vardai = new string[6, 2]
            //{
            //    {"Beyonce", "m" },
            //    {"David Bowie", "v" },
            //    {"Elvis Costello", "v" },
            //    {"Madonna", "m" },
            //    {"Elton John", "v" },
            //    {"Charles Aznavor", "v" }
            //};

            //Console.WriteLine("Vyrai:");

            //for (int i = 0; i < 6; i++)
            //{
            //    if (vardai[i, 1] == "v")
            //    {
            //        Console.WriteLine(vardai[i, 0]);
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("Moterys:");

            //for (int i = 0; i < 6; i++)
            //{
            //    if (vardai[i, 1] == "m")
            //    {
            //        Console.WriteLine(vardai[i, 0]);
            //    }
            //}

            //-----------------------------------antras budas (geresnis)------------------------------------------
            string[] vardai = 
            {
                "Beyonce (m)",
                "David Bowie (v)",
                "Elvis Costello (v)",
                "Madonna (m)",
                "Elton John (v)",
                "Charles Aznavor (v)" 
                };

            Console.WriteLine("Vyrai:");

            for (int i = 0; i < vardai.Length; i++)
            {
                if (vardai[i].Contains("(v)"))
                {
                    Console.WriteLine(vardai[i].Remove(vardai[i].Length - 3));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Moterys:");

            for (int i = 0; i < vardai.Length; i++)
            {
                if (vardai[i].Contains("(m)"))
                {
                    Console.WriteLine(vardai[i].Remove(vardai[i].Length -3));
                }
            }

            Console.ReadLine();
        }
    }
}
