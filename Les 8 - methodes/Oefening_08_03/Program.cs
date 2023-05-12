using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Oefening_08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze oefening is een uitbreiding op oefening 05.05:
             * - Lees voor 3 pijlen de landingsplaats en geef vervolgens een totaal van de punten weer.
             * - Ingevoerde waardes moeten gehele getallen zijn die groter zijn dan 0 en kleiner of gelijk aan 4.
             * - Na een correcte invoer, word een nieuw scherm getoond.
             *     - Buiten de roos: 0 punten (landingsplaats 1)
             *     - Binnenste ring: 20 punten (landingsplaats 2)
             *     - Buitenste ring: 50 punten (landingsplaats 3)
             *     - In het hart: 100 punten (landingsplaats 4)
            */

            // Declaratie van de variabelen
            List<int> punten = new List<int>();

            // Inlezen van het aantal worpen
            for (int i = 0; i < 3; i++)
            {
                
                //Bewerking -> positie van de landingsplaats (tussen 1 en 3)
                punten.Add(ReadNumber(1, 4));
            }

            // Weergave van de score
            ShowScore(CalculateScore(punten));

        }

        /*
        * Werk eerst volgende verplichte methodes uit:
        * 
        * int ReadNumber(int min, int max)
        * Deze methode vraagt de gebruiker om een geheel getal in te geven binnen de bepaalde grenzen.
        * Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald.
        * Returnwaarde is het ingegeven getal.
        */

        private static int ReadNumber(int min, int max)
        {
            string invoer;
            int getal;

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal) || getal < 1 || getal > 4);

            return getal;
        }

        /* int CalculateScore(List<int> throws)
         * Deze methode berekent de totaalscore op basis van de worpen die de gebruiker heeft gedaan.
         * Returnwaarde is de totaalscore.
        */
        private static int CalculateScore(List<int> throws)
        {
            int som = 0;
            foreach (int i in throws)
            {
                switch (i)
                {
                    case 1: som += 0;
                        break;
                    case 2: som += 20;
                        break;
                    case 3: som += 50;
                        break;
                    case 4: som += 100;
                        break;
                }
            }

            return som;
        }

        /* void ShowScore(int score)
         * Deze methode zonder returnwaarde print de score van de gebruiker.
         * Bekijk de voorbeelden voor de juiste tekst.
        */
        private static void ShowScore(int score)
        {
            Console.WriteLine($"U hebt {score} punten behaald!");
            Console.ReadLine();
        }
    }
}
