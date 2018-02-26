using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esimene:");
            Console.WriteLine("------------------------------------");

            int WordsCount = 0;
            string Path = @"C:\games\tekst.txt";
            string Text = new System.IO.StreamReader(Path).ReadToEnd();
            WordsCount = Text.Split(' ').Length;
            Console.WriteLine("Tekstis on " + WordsCount + " sõna");


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Teine ja kolmas:");
            Console.WriteLine("------------------------------------");

            var counts = Text.GroupBy(x => x).OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in counts)
            {
                Console.WriteLine("Tekstis on: " + item.Key + " " + item.Value + " tükki");
            }


            Console.WriteLine("------------------------------------");
            Console.WriteLine("Neljas:");
            Console.WriteLine("------------------------------------");



 
            Console.ReadLine();
        }
    }
}
