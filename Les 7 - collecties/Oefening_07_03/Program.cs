using System;
using System.Collections.Generic;
using System.Linq;

namespace Oefening_07_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker vraagt om cijfers in te geven.
             * Deze cijfers steek je in een lijst.
             * Print daarna het hoogste en het laagste getal uit de lijst.
             * Maak gebruik van volgende methodes:
             * Sort(), First() en Last().
            */

            //Declaratie van de variabelen.
            List<int> getallen = new List<int>();
            int getal, lijstlengte = 13;
            string invoer = "";

            //Bewerking
            for (int i = 0; i < lijstlengte; i++)
            {
                //Inlezen: validatie integer
                do
                {
                    Console.Write("Geef een getal in: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out getal));
                
                //getal inlezen in de lijst
                getallen.Add(getal);
            }


            //Weergave
            Console.WriteLine($"Laagste getal: {getallen.Min()}");
            Console.WriteLine($"Hoogste getal: {getallen.Max()}");
            
            //scherm leegmaken
            Console.ReadLine();
        }
    }
}
