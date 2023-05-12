using System;
using System.Collections.Generic;

namespace Oefening_07_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* De gebruiker krijgt steeds de vraag of deze nog een naam wil toevoegen aan de lijst.
             * Bij "ja" als antwoord, zal de gebruiker een naam kunnen ingeven die toegevoegd word aan de lijst.
             * Bij "nee" als antwoord, zal de lijst van namen weergegeven worden.
             * Hierna sluit het programma af.
            */

            List<string> naam = new List<string>();
            string vraag = string.Empty;

            Console.Write("Wil u een naam toevoegen?: ");
            vraag = Console.ReadLine();

            while (vraag.ToLower() != "nee")
            {
                Console.Write("Geef een naam in: ");
                naam.Add(Console.ReadLine());

                foreach (string namen in naam)
                {
                    naam.Add(namen);
                }

                Console.Write("Wil u nog een naam toevoegen?: ");
                vraag = Console.ReadLine();
            }

            Console.Write(naam);
            Console.ReadLine();
        }
    }
}
