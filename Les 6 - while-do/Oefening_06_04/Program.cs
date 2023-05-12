using System;
using System.Security.Cryptography.X509Certificates;

namespace Oefening_06_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Vraag de gebruiker om een tafel in te geven.
             * Hij kan dit blijven doen tot het getal 0 wordt ingegeven.
             * Op de input van de gebruiker wordt gegevenscontrole toegepast. Dit moet een numerieke waarde zijn.
             * Indien de gebruiker meteen 0 ingeeft, stopt de applicatie en is er dus ook geen output.
             * Indien de gebruiker enkele getallen ingeeft, tonen we van elk ingegeven getal de tafel van 10.
             */

            int getal, product;
            string invoer;

            do
            {
                do
                {
                    //Console.Write("Geef een tafel in: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out getal));
                
                if (getal == 0)
                {
                    Console.WriteLine("");
                }
                
                else
                {
                    for (int i = 1; i < 11; i++)
                    {
                        product = getal * i;
                        Console.WriteLine($"{i} x {getal} = {product}");
                    }
                }
                
                Console.WriteLine();
            } while (getal != 0);

            Console.ReadLine();
        }
    }
}
