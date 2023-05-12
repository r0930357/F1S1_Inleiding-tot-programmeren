using System;
using System.Collections.Generic;
using System.Linq;

namespace Oefening_07_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*De gebruiker krijgt steeds de vraag of deze nog een cijfer wil toevoegen aan de lijst.
             * Bij ja als antwoord, zal de gebruiker een cijfer kunnen ingeven dat toegevoegd word aan de lijst.
             * Bij nee als antwoord, zal het laagste getal, het hoogste getal en het gemiddelde van de cijfers weergegeven worden.
             * Hierna sluit het programma af.
            */

            //Declaratie van de variabelen
            List<int> getallen = new List<int>();
            int getal, poging = 0, resultaat = 0, gemiddelde;
            string invoer, invoergetal;

            do
            {
                //Console.Write("Cijfer toevoegen?: ");
                invoer = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(invoer) || (invoer.ToLower() != "ja" && invoer.ToLower() != "nee"));

            while (invoer.ToLower() != "nee")
            {
                do
                {
                    //Console.Write("Geef cijfer in: ");
                    invoergetal = (Console.ReadLine());
                } while (!int.TryParse(invoergetal, out getal));

                getallen.Add(getal);
                poging++;
                resultaat += getal;

                do
                {
                    //Console.Write("Nog een cijfer toevoegen?: ");
                    invoer = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(invoer) || (invoer.ToLower() != "ja" && invoer.ToLower() != "nee"));
            }
            Console.WriteLine("Statistieken:");
            Console.Write($"Laagste cijfer: {getallen.Min()}\n");
            Console.Write($"Hoogste cijfer: {getallen.Max()}\n");
            gemiddelde = resultaat / poging;
            Console.Write($"Gemiddelde: {gemiddelde}\n");

            Console.ReadLine();
        }
    }
}
