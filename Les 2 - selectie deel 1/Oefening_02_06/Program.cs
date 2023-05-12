using System;
using System.Runtime.CompilerServices;

namespace Oefening_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, getal3, resultaat;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());

            //berekening
            resultaat = (getal1 + getal2 + getal3) / 3;
                if (resultaat < 50)
            {
                Console.WriteLine(resultaat + ", niet geslaagd");
            }
            else
            {
                Console.WriteLine(resultaat + ", geslaagd");
            }
        Console.ReadLine();
        }
    }
}
