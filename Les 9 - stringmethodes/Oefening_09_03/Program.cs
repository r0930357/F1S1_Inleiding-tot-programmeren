using System;

namespace Oefening_09_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Een gebruiker voert een woord in.
             * Jij kijkt na of het woord een palindroom is.
             * 
             * Wikipedia: “Een palindroom, keerwoord of spiegelwoord is een woord waarin de letters symmetrisch gerangschikt zijn, zodanig dat het woord van achter naar voren gelezen hetzelfde is als van voor naar achter.”
             * Voorbeelden zijn lepel, levensnevel, madam, meetsysteem, nepparterretrappen, parterreserretrap, reinier, rookseinklotetolknieskoor, stormrots.
            */

            string woord = GeefWoord();
            ConroleerPalindroom(woord);

        }

        private static string GeefWoord()
        {
            string woord;

            do
            {
                woord = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(woord));

            return woord;
        }

        private static void ConroleerPalindroom(string woord)
        {
            string controleWoord = "", antwoord;
            

            string eersteDeelWoord = woord.Substring(0, (woord.Length - 1) / 2);
            string tweedeDeelWoord = woord.Substring((woord.Length + 1) / 2, (woord.Length - 1) / 2);

            for (int i = tweedeDeelWoord.Length - 1; i >= 0; i--)
            {
                controleWoord += tweedeDeelWoord[i];
            }

            if (controleWoord.Equals(eersteDeelWoord))
            {
                antwoord = "een";
            }
            else
            {
                antwoord = "geen";
            }

            Console.WriteLine($"{woord} is {antwoord} palindroom");
            Console.ReadLine();
        }
    }
}
