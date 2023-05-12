using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Oefening_08_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze oefening is een uitbreiding op oefening 04.04
             * Lees 2 symbolen in. Het tweede symbool moet verschillend zijn van het eerste.
             * Na het inlezen van deze symbolen vraag je een lengte en een breedte.
             * Hierna drukt het programma een sjaal af met de ingevoerde waarden.
             * Bekijk de voorbeelden aandachtig.
             */

            // Inlezen van de symbolen
            string symbol1 = ReadSymbool(String.Empty);
            string symbol2 = ReadSymbool(symbol1);

            // Inlezen van de lengte en breedte
            int lengte = ReadNumber();
            int breedte = ReadNumber();

            // Sjaallijnen maken
            string line1 = MakeLine(symbol1, breedte);
            string line2 = MakeLine(symbol2, breedte);

            // Sjaal afdrukken
            Console.WriteLine(CreateScarf(line1, line2, lengte));

            // Scherm stilhouden
            Console.ReadLine();
        }

        /* Werk eerst volgende verplichte methodes uit:
        
        * int ReadNumber()
        * Deze methode vraagt de gebruiker om een geheel getal in te geven.
        * Indien de gebruiker een foutieve waarde (string, lege string, ..) ingeeft, wordt de vraag herhaald.
        * Returnwaarde is het ingegeven getal.
        */
        private static int ReadNumber()
        {
            int getal;
            string invoer;

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal));

            return getal;
        }

        /* string ReadSymbol(string compareSymbol)
        * Deze methode vraagt de gebruiker om een symbool in te geven.
        * Het symbool moet verschillend zijn van het symbool dat meegegeven wordt.
        * Een symbool bestaat uit 1 karakter.
        * Returnwaarde is het ingegeven symbool.
        */
        private static string ReadSymbool(string compareSymbol)
        {
            string symbool;

            do
            {
                symbool = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(symbool) || symbool.Length > 1 || symbool == compareSymbol);

            return symbool;
        }

        /* string MakeLine(string symbol, int length)
         * Deze methode maakt een lijn die bestaat uit x aantal keer het symbool, waarbij x de lengte is.
         * Returnwaarde is de gemaakte lijn.
        */
        private static string MakeLine(string symbol, int length)
        {
            string sjaalLijn = new string(Convert.ToChar(symbol), length);
            return sjaalLijn;
        }

        /* string CreateScarf(string line1, string line2, int length)
         * Deze methode maakt de volledige sjaal obv de gemaakte lijnen.
         * Returnwaarde is de volledige sjaal.
        */
        private static string CreateScarf(string line1, string line2, int lenght)
        {
            string sjaal = "";

            for (int i = 1; i <= lenght; i++)
            {
                if (i % 2 != 0)
                {
                    sjaal += "\n" + line1;
                }
                else
                {
                    sjaal += "\n" + line2;
                }
            }

            return sjaal;
        }
    }
}
