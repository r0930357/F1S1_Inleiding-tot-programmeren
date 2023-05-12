using System;
using System.Runtime.Serialization;

namespace Oefening_09_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Schrijf een programma dat de som der cijfers van een opgegeven getal afdrukt.

            // Declaratie van de variabelen
            int som = 0;
            string cijfers;

            // Inlezen van de cijferreeks
            cijfers = Console.ReadLine();

            // Bewerking -> substring methode
            for (int i = 0; i < cijfers.Length; i++)
            {
                string cijfer = cijfers.Substring(i, 1);
                
                // string omzetten in int en optellen
                som += int.Parse(cijfer);
            }

            // Resultaat weergeven
            Console.WriteLine($"De som is: {som}");

            // Scherm stilhouden
            Console.ReadLine();
        }
    }
}
