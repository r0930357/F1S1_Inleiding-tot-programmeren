using System;

namespace Oefening_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, uitkomst;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());

            //bewerking
            if (getal2 == 0)
            {
                Console.WriteLine(getal1 + " is niet deelbaar door 0.");
            }
            else
            {
                uitkomst = getal1 / getal2;
                Console.WriteLine(getal1 + " / " + getal2 + " = " + uitkomst);
            }

            //weergave
             Console.ReadLine();

        }
    }
}
