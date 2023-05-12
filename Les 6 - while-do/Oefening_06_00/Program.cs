using System;
using System.Xml;

namespace Oefening_06_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal, som = 0;
            string invoer;

            do
            {
                //Console.Write("Geef een getal in:");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal));
            som += getal;

            while (getal == 0)
            {
                do
                {
                    //Console.Write("Geef een getal in:");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out getal) && getal > 0);
                som += getal;

            }

            Console.WriteLine($"Totaal: {som}");
            Console.ReadLine();
        }
    }
}
