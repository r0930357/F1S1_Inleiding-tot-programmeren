using System;
using System.Net.Security;

namespace Oefening_08_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Deze oefening is een uitbreiding op oefening 03.01
             * Er moeten 3 gehele getallen ingelezen worden, één lettercode 'A' of 'B' en een cijfercode '1', '2' of '3'.
             * De combinatie van de lettercode en de cijfercode bepalen welke bewerking er moet uitgevoerd worden.
             * Bekijk onderstaande tabel aandachtig om de juiste bewerking te achterhalen.
            */

            int n1 = ReadNumber();
            int n2 = ReadNumber();
            int n3 = ReadNumber();
            string letterCode = ReadLetter();
            int cijferCode = ReadNumber();

            string operation;

            if (letterCode == "A")
            {
                operation = "+";

                if (cijferCode == 1)
                {
                    PrintResult(n1, n2, operation, Sum(n1, n2));
                }
                if (cijferCode == 2)
                {
                    PrintResult(n2, n3, operation, Sum(n2, n3));
                }
                if (cijferCode == 3)
                {
                    PrintResult(n1, n3, operation, Sum(n1, n3));
                }
            }
            if (letterCode == "B")
            {
                operation = "-";

                if (cijferCode == 1)
                {
                    PrintResult(n1, n2, operation, Subtract(n1, n2));
                }
                if (cijferCode == 2)
                {
                    PrintResult(n2, n3, operation, Subtract(n2, n3));
                }
                if (cijferCode == 3)
                {
                    PrintResult(n1, n3, operation, Subtract(n1, n3));
                }
            }

            Console.ReadLine();
        }

        /* int ReadNumber().
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

        /* string ReadLetter().
         * Deze methode vraagt de gebruiker om een letter in te lezen.
         * Deze vraag blijft herhalen tot de gebruiker "A" of "B" ingeeft.
         * Returnwaarde is dus "A" of "B".
        */
        private static string ReadLetter()
        {

            string letter;

            do
            {
                letter = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(letter) || (letter.ToUpper() != "A" && letter.ToUpper() != "B"));

            return letter;
        }

        /* int Sum(int x, int y).
         * Deze methode heeft als returnwaarde de som van beide parameters.
        */

        private static int Sum(int x, int y)
        {
            return x + y;
        }

        /*  Subtract(int x, int y).
         * Deze methode heeft als returnwaarde het verschil van beide parameters.
        */

        private static int Subtract(int x, int y)
        {
            return x - y;
        }

        /* void PrintResult(int n1, int n2, string operation, int result).
         * Deze methode zonder returnwaarde print het resultaat.
         * De parameter operation bevat het teken dat bij de uitgevoerde operatie hoort.
         * Bekijk de voorbeelden voor de correcte uitvoer.
        */

        private static void PrintResult(int n1, int n2, string operation, int result)
        {
            Console.WriteLine($"{n1} {operation} {n2} = {result}");
        }
    }
}
