using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KD_List_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string textLine;

            try
            {
                StreamReader reader = new StreamReader("C:/Users/1011/Documents/Visual Studio 2019/Dot NET Kursai/Countries.txt");
                textLine = reader.ReadLine();
                Console.WriteLine(textLine);

                string[] separator = { ", " };
                string[] textColum = textLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                Array.Sort(textColum);
                using (StreamWriter writer = new StreamWriter("C:/Users/1011/Documents/Visual Studio 2019/Dot NET Kursai/Countries_sorted.txt"))
                {
                    foreach (var item in textColum)
                    {
                        writer.WriteLine(item);
                    }
                }
                    

                
                
            }

            catch
            {
                Console.WriteLine("File not found");
            }

            Console.ReadLine();
        }
    }
}
