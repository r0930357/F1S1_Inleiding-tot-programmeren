using System;

namespace Oefening_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            double getal1, getal2, hulp, resultaat;

            //inlezen
            getal1 = double.Parse(Console.ReadLine());
            getal2 = double.Parse(Console.ReadLine());

            //bewerking
            if (getal1 < getal2)
            {
                resultaat = getal2 - getal1;
                hulp = getal1;
                getal1 = getal2;
                getal2 = hulp;
            }
            else
            {
                resultaat = getal1 - getal2;
            }

            //weergave
            Console.WriteLine(getal1 + " - " + getal2 + " = " + resultaat);
            Console.ReadLine();

        }
    }
}
