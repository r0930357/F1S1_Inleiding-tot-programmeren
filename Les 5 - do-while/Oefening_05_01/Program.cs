using System;

namespace Oefening_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lees 2 getallen in.
             * Bereken het verschil tussen deze twee getallen, maar trek telkens het kleinste getal van het grootste af.
             * Wanneer een foute waarde ingevoerd wordt, zal er naar een nieuwe waarde gevraagd worden.
            */
            
            int getal1, getal2, uitkomst;
            string invoer;

            do
            {
                //Console.Write("Geef het eerste getal in: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal1));

            do
            {
                //Console.Write("Geef het tweede getal in: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal2));

            if (getal1 > getal2)
            {
                uitkomst = getal1 - getal2;
                Console.WriteLine($"{getal1} - {getal2} = {uitkomst}");
            }
            else
            {
                uitkomst = getal2 - getal1;
                Console.WriteLine($"{getal2} - {getal1} = {uitkomst}");
            }

            Console.ReadLine();
        }
    }
}
