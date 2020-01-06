using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD_List_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dnr = new List<string>();
            string rna = "A, A, C, G, U, A, A";
            string[] separator = { ", " };
            string[] rnaArray = rna.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rnaArray.Length; i++)
            {
                if(rnaArray[i] == "A")
                {
                    dnr.Add("A-T");
                }
                if(rnaArray[i] == "U")
                {
                    dnr.Add("T-A");
                }
                if (rnaArray[i] == "G")
                {
                    dnr.Add("G-C");
                }
                if (rnaArray[i] == "C")
                {
                    dnr.Add("C-G");
                }

                dnr.Add(",");
            }

            dnr.RemoveAt(dnr.Count - 1);

            Console.WriteLine($"RNA: {rna}\n");
            Console.Write("DNR: ");

            foreach (var item in dnr)
            {
                Console.Write(item);
            }

            Console.ReadLine();
        }
    }
}
