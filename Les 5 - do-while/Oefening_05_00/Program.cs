using System;
using System.Reflection.Emit;

namespace Oefening_05_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int aantalMilligram, milligram0, uur = 0, resultaat = 0;

            do
            {
                invoer = Console.ReadLine();
                milligram = aantalMilligram / 2;
                resultaat = uur + 5;
            } while (!int.TryParse(invoer, out aantalMilligram) && aantalMilligram >= 1);

            Console.WriteLine(resultaat);
            Console.ReadLine();
                
        }
    }
}