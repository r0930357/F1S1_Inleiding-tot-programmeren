using System;
using System.Collections.Generic;

namespace Oefening_08_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze oefening is een uitbreiding op oefening 04.05:
             * - Lees 2 getallen in.
             * - We veronderstellen dat het eerste getal groter is dan het tweede getal.
             * - Geef alle even getallen die tussen het grootste en het kleinste getal liggen.
            */

            // Declaratie van de variabelen -> 2 getallen inlezen
            int getal1 = ReadNumber();
            int getal2 = ReadNumber();

            // Alle getallen in een lijst zetten
            List<int> even = GetEvenNumberBetween(getal1, getal2);
            
            // Alle even getallen afdrukken
            PrintResult(even);
            
            // Scherm stilhouden
            Console.ReadLine();
        }

        /* Werk eerst volgende verplichte methodes uit:
         * 
         * int ReadNumber()
         * Deze methode vraagt de gebruiker om een geheel getal in te geven.
         * Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald.
         * Returnwaarde is het ingegeven getal.
        */
        private static int ReadNumber()
        {
            int nummer;
            string invoer;

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out nummer));
            
            return nummer;
        }

        /* bool IsEven(int number)
         * Deze methode controleert of het ingegeven getal even is.
         * Returnwaarde is true als dit het geval is.
        */
        private static bool IsEven(int number)
        {
            bool isEven;

            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
            return isEven;
        }

        /* List<int> GetEvenNumberBetween(int n1, int n2)
         * Deze methode bepaalt alle even getallen die tussen het eerste en end tweede getal liggen.
         * Returnwaarde is een lijst van al deze getallen.
        */
        private static List<int> GetEvenNumberBetween(int n1, int n2)
        {
            List<int> evenGetal = new List<int>();

            for (int i = n1; i >= n2; i--)
            {
                if (IsEven(i))
                {
                    evenGetal.Add(i);
                }
            }

            return evenGetal;
        }

        /* void PrintResult(List<int> numbers)
         * Deze methode toont het resultaat in het juiste formaat.
         * Bekijk de voorbeelden.
        */
        private static void PrintResult(List<int> numbers)
        {
            string uitvoer = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    uitvoer += numbers[i];
                }
                else
                {
                    uitvoer+= $"{numbers[i]} * ";
                }
            }

            Console.WriteLine(uitvoer);
        }
    }
}
