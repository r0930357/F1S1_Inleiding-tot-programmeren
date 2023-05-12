using System;

namespace Oefening_09_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat een zin inleest.
             * Druk daarna af hoeveel klinkers er in de zin zitten.
            */

            // Declaratie van de variabelen
            string zin;
            int totaal = 0;

            // Inlezen van de zin
            zin = Console.ReadLine().ToLower();

            totaal = ControleerKlinkers(zin);

            // Afdrukken
            Console.WriteLine($"De zin bevat {totaal} klinkers");

            Console.ReadLine();
        }

        private static int ControleerKlinkers(string zin)
        {

            int totaal = 0;

            for (int i = 0; i < zin.Length; i++)
            {
                string letter = zin.Substring(i, 1);

                if (letter == "a" || letter== "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    totaal++;
                }
            }

            return totaal;

        }
    }
}
