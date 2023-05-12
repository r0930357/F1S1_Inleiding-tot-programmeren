using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Oefening_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze oefening is een uitbreiding op '04 - Supportersjaal' van '04 for loop':
             *   Lees 2 symbolen in.
             *   Na het inlezen van deze symbolen vraag je een lengte en een breedte.
             *   Hierna drukt het programma een sjaal af met de ingevoerde waarden.
             * We kunnen nu voor geen, één of meerdere ploegen de supporterssjaal samenstellen en tonen.
             * De ploegnaam moet minstens uit 5 karakters bestaan. De lengte van de sjaal is minstens 4.
             * De breedte van de sjaal moet minstens de helft zijn van de lengte.
             * Wanneer de gebruiker vijf asteriksen ingeeft als ploegnaam, stopt het programma.
             */

            //Declaratie van de Variabelen
            string symbool1, symbool2, sjaalsymbool1, sjaalsymbool2, ploegnaam = string.Empty, sjaal = "", invoer, titel = "Supportersjaal";
            int lengte, breedte;

            //PR1: lees de kritieke waarde:
            //De ploegnaam inlezen, deze moet minstens uit 5 karakters bestaan
            do
            {
                //Console.Write("Geef de ploegnaam in: ");
                ploegnaam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length < 5);

            //PR: controleer de kritieke waarde
            //Als de ploegnaam niet gelijk is aan "*****"
            while (ploegnaam != "*****")
            {
                //De titel en de ploegnaam afdrukken in de console
                Console.WriteLine($"{titel} {ploegnaam}");
                //* onder de titel en de ploegnaam afdrukken in de console
                Console.WriteLine(new String('*', titel.Length + ploegnaam.Length + 1));

                //Het eerste symbool ingeven welk slechts uit 1 karakter mag bestaan
                do
                {
                    Console.Write("Geef het eerste symbool in: ");
                    symbool1 = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(symbool1) || symbool1.Length != 1);

                //Het tweede symbool ingevenwelk slechts uit 1 karakter mag bestaan en niet hetzelfde mag zijn als het eerste symbool
                do
                {
                    Console.Write("Geef het tweede symbool in: ");
                    symbool2 = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(symbool2) || symbool2.Length != 1 && symbool2 == symbool1);
                
                //De lengte van de sjaal ingeven welke minstens uit 4 karakters moet bestaan
                do
                {
                    Console.Write("Geef de lengte: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out lengte) || lengte < 4);

                //De breedte van de sjaal ingeven welke minstels de helft van de lengte moet zijn
                do
                {
                    Console.Write("Geef de breedte in: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out breedte) || breedte < lengte / 2);

                //een lokale string waarin de 
                sjaalsymbool1 = new string(Convert.ToChar(symbool1), breedte);
                sjaalsymbool2 = new string(Convert.ToChar(symbool2), breedte);

                for (int i = 1; i <= lengte; i++)
                {
                    if (i % 2 != 0)
                    {
                        sjaal += sjaalsymbool1;
                        sjaal += Environment.NewLine;
                    }
                    else
                    {
                        sjaal += sjaalsymbool2;
                        sjaal += Environment.NewLine;
                    }
                }

                Console.Write(sjaal);
                sjaal = "";

                do
                {
                    //Console.Write("Geef nog een ploegnaam in?: ");
                    ploegnaam = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(ploegnaam) || ploegnaam.Length < 5);
            }

            Console.ReadLine();
        }
    }
}
