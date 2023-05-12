using System;

namespace Oefening_09_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Een gebruiker voert een woord in.
             * Jij vervangt alle O’s door X’n.
             * Doe dit met, maar ook zonder de functie Replace().
            */

            // Declareren en inlezen van de variabele
            string woord = Console.ReadLine();

            // Afdrukken van het resultaat
            Console.WriteLine($"Het nieuwe woord is {woord.Replace("o", "x")}");
        }
    }
}
