using System;

namespace Oefening_04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, startGetal, eindGetal;
            string resultaat = "";

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());

            startGetal = getal2 % 2 == 0 ? getal2 : getal2 + 1;
            eindGetal = getal1 % 2 == 0 ? getal1 : getal1 - 1;

            //bewerking
            for(int i = eindGetal; i >= startGetal + 1; i -= 2)
            {
                resultaat += i + " * ";
            }
            Console.WriteLine(resultaat + startGetal);
            Console.ReadLine();
        }
    }
}
