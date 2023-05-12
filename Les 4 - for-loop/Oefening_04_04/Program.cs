using System;

namespace Oefening_04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lees 2 symbolen in.
             * Na het inlezen van deze symbolen vraag je een lengte en een breedte.
             * Hierna drukt het programma een sjaal af met de ingevoerde waarden.
             * Bekijk de voorbeelden aandachtig.
             */
            
            //declaratie
            int lengte, breedte;
            string symbool1, symbool2, sjaalsymbool1 = "", sjaalsymbool2 = "";

            //inlezen
            symbool1 = Console.ReadLine();
            symbool2 = Console.ReadLine();
            lengte = int.Parse(Console.ReadLine());
            breedte = int.Parse(Console.ReadLine());

            for(int i = 1; i <= breedte; i++)
            {
                sjaalsymbool1 += symbool1;
                sjaalsymbool2 += symbool2;
            }
            for(int i = 1; i <= lengte; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(sjaalsymbool1);
                }
                else
                {
                    Console.WriteLine(sjaalsymbool2);
                }
            }
        Console.ReadLine();
        }
    }
}
