using System;
using System.Collections.Generic;
using System.Linq;

namespace Oefening_07_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Schrijf een programma dat de gebruiker vraagt om getallen in te geven.
             * Herhaal dit tot het getal 0 wordt ingegeven.
             * Toon nu aan de gebruiker het laagste en hoogste getal alsook het gemiddelde van alle getallen.
            */

            List<int> getallen = new List<int>();
            int getal, poging = 0, resultaat = 0, gemiddelde;
            string invoer;

            do {
                //Console.Write("Geef een getal: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal));
            
            while (getal != 0)
            {
                getallen.Add(getal);
                poging++;
                resultaat += getal;

                do
                {
                    //Console.Write("Geef een volgend getal: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out getal));
            }

            Console.WriteLine("Statistieken:");
            Console.Write($"Hoogste cijfer: {getallen.Max()}\n");
            Console.Write($"Laagste cijfer: {getallen.Min()}\n");
            gemiddelde = resultaat / poging;
            Console.Write($"Gemiddelde: {gemiddelde}\n");

            Console.ReadLine();
        }
    }
}
