using System;
using System.Collections.Generic;
using System.Globalization;

namespace Oefening_07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Schrijf een programma dat de gebruiker vraagt om cijfers in te geven.
             * Zolang de gebruiker geen leeg antwoord geeft, blijf je dit doen.
             * Deze cijfers steek je in een lijst. Print daarna het aantal positieve getallen en de som van alle negatieve getallen.
             * Belangrijk: 0 is in deze oefening niet negatief noch positief.
            */

            //Declaratie van de variabelen.
            List<int> nummers = new List<int>();
            int nummer, positieveNummers = 0, somNegatieveNummers = 0;
            string invoer = "";


            //Inlezen.
            //PR1: Kritieke waarde controleren.
            invoer = Console.ReadLine();

            //PR2: Kritieke waarde controleren.
            //Lijst met getallen opvullen.
            while (invoer != string.Empty)
            {
                //PR3: Bewerkingen uitveren
                //Invoer omztten naar datatype 'int' en in variable 'nummer' steken.
                nummer = int.Parse(invoer);

                //Inlezen getal toevoegen aan lijst.
                nummers.Add(nummer);

                //PR4: Krietieke waarde opnieuw inlezen.
                invoer = Console.ReadLine();
            }

            //Lussen over ijst met alle nummers. Foreach omdat positie niet nodig is.
            foreach (int num in nummers)
            {
                //Controleren of getal groter is dan 0. Zoja, positieveNummers verhogen met 1.
                if (num > 0)
                {
                    positieveNummers++;
                }
                //Indien getal kleiner is dan 0, de negatieve waarden optellen.
                else if (num < 0)
                {
                    somNegatieveNummers += num;
                }
                //Indien getal gelijk is aan 0, tekst weergeven.
                else
                {
                    Console.WriteLine($"0 is niet negatief, noch positief");
                }
            }

            Console.WriteLine($"Aantal positief: {positieveNummers}");
            Console.WriteLine($"Negatieve som: {somNegatieveNummers}");

            Console.ReadLine();
        }
    }
}
