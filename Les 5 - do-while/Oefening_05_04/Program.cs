using System;

namespace Oefening_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * De gebruiker krijgt een zin te zien om te onthouden.
             * Namelijk 'Op de stoel ligt een zonnehoed en peperkoek'.
             * Vervolgens kan deze op enter drukken om het spel te starten.
             * Het scherm wordt leeggemaakt.
             * Lees vervolgens de pogingen van de gebruiker om de zin te reproduceren in.
             * Dit kan in 1 of meerdere keren gebeuren.
             * Wanneer de gebruiker het woord raadt, zal weergegeven worden in hoeveel pogingen deze werd geraden.
             */


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.Title = "Les 5 - Oefening 4";

            int teller = 1, aantalPogingen;
            string zin = "Op de stoel ligt een zonnehoed en peperkoek", invoer;

            Console.Write(zin);
            Console.ReadLine();
            Console.Clear();

            do
            {
                Console.Write("Reproduceer de zin: ");
                invoer = Console.ReadLine();
                if (invoer != zin)
                {
                    teller++;
                }
                aantalPogingen = teller;
            } while (invoer != zin);

            Console.Clear();

            if (aantalPogingen == 1)
            {
                Console.WriteLine("Je had {0} poging nodig!", aantalPogingen);
            }
            else
            {
                Console.WriteLine("Je had {0} pogingen nodig!", aantalPogingen);
            }
            Console.ReadLine();
        }
    }
}
