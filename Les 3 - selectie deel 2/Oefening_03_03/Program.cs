using System;

namespace Oefening_03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaratie van de variabelen
            string lettercode;
            double getal1, getal2, getal3, uitkomst;

            //Variabelen inlezen
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = Convert.ToInt32(Console.ReadLine());
            getal3 = Convert.ToInt32(Console.ReadLine());
            lettercode = Console.ReadLine();

            //bewerking & weergave indien voorwaarde voldaan
            switch (lettercode.ToLower())
            {
                //Indien de lettercode = a -> getal1 + getal2 + getal3
                case "a":
                    uitkomst = getal1 + getal2 + getal3;
                    Console.WriteLine("Uitkomst: " + uitkomst);
                    break;
                //Indien de lettercode = b -> getal1 * getal3
                case "b":
                    uitkomst = getal1 * getal3;
                    Console.WriteLine("Uitkomst: " + uitkomst);
                    break;
                //Indien de lettercode =  -> getal1 + getal2 + getal3
                case "c":
                    uitkomst = getal3 - getal2;
                    Console.WriteLine("Uitkomst: " + uitkomst);
                    break;
                //Indien de lettercode = d -> als het getal goter is dan 0 -> vierkantswortel van getal 1
                case "d":
                    if (getal1 > 0)
                    {
                        uitkomst = Math.Sqrt(getal1);
                        Console.WriteLine("Uitkomst: " + uitkomst);
                    }
                    //Indien de lettercode = d -> als het getal niet goter is dan 0 -> "Foutieve invoer"
                    else
                    {
                        Console.WriteLine("Foutieve invoer.");
                    }
                    break;
                //Indien de lettercode niet a, b, c of d is -> grooteste getal van de 3 ingevoerde waarden
                default:
                    uitkomst = Math.Max(getal1, Math.Max(getal2, getal3));
                    Console.WriteLine("Uitkomst: " + uitkomst);
                    break;
            }

            //Scherm stilhouden
            Console.ReadLine();
        }
    }
}
