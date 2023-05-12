using System;
using System.Collections.Generic;

namespace Oefening_08_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Deze oefening is een uitbreiding op oefening 06.02.
             * - Lees de familie- en voornaam van de gebruiker in. Controleer dat de invoer ingevuld is.
             * - Lees de hobby van de gebruiker in aan de hand van het bijhorende nummer.
             * - Hierbij wordt een tijdschrift suggestie getoond. Gebruik hiervoor onderstaande tabel.
             * - Vervolgens krijgt de gebruiker opnieuw de optie om een hobby in te geven.
             * - Het bovenstaande proces blijft gebeuren tot de gebruiker 8 ingeeft op de vraag welke hobby deze uitoefent.
            */

            List<int> hobbies = new List<int>();
            string voornaam = ReadName("Voornaam: ");
            string familienaam = ReadName("Familienaam: ");
            int hobby = 0;

            hobby = ReadHobby(1, 8);

            while (hobby != 8)
            {
                hobbies.Add(hobby);
                hobby = ReadHobby(1, 8);
            }

            RecommendBooks(hobbies);
            Console.ReadLine();
        }

        /* Werk eerst volgende verplichte methodes uit:
         * 
         * string ReadName(string prompt)
         * Deze methode vraagt de gebruiker om een naam in te geven.
         * De parameter dient om een vraag mee te geven die getoond wordt aan de gebruiker.
         * Returnwaarde is ingegeven waarde.
         * Controleer dat de input geldig is.
        */
        private static string ReadName(string prompt)
        {
            do
            {
                prompt = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(prompt));

            return prompt;
        }

        /* int ReadHobby(int min, int max)
         * Deze methode vraagt de gebruiker om een geheel getal in te geven binnen de bepaalde grenzen.
         * Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald.
         * Returnwaarde is het ingegeven getal.
        */

        private static int ReadHobby(int min, int max)
        {
            string input;
            int getal;

            do
            {
                //Console.Write("Geef een getal (1 tot en met 8): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out getal) || getal < 1 || getal > 8);

            return getal;
        }

        /* void RecommendBooks(List<int> hobbies)
         * Deze methode raadt de tijdschriften aan op basis van de ingegeven hobbies (nummers).
         * Opmerking: je mag in deze methode enkel gebruik maken van een if.
         * Een if-else structuur of switch is niet toegestaan.
        */

        private static void RecommendBooks(List<int> hobbies)
        {

            if (hobbies.Count == 0)
            {
                Console.WriteLine("Wij raden niets aan.");
            }

            List<string> tijdschrift = new List<string>() { "Anna", "Knippie", "VtWonen", "Voetbal international", "Wandelen & fietsen", "Zoom NL", "Runners" };

            foreach (int keuze in hobbies)
            {
                string boek = tijdschrift[keuze -1];
                Console.WriteLine($"Wij raden \"{boek}\" aan.");
            }
        }
    }
}