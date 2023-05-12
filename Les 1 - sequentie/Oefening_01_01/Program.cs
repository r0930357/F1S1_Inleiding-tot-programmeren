using System;

namespace Oefening_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, getal3, getal4, som, product;

            //inlezen
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            //bewerking
            som = getal1 + getal3;
            product = getal2 * getal4;

            //weergave
            Console.WriteLine("Optelling: " + som);
            Console.WriteLine("Vermenigvuldiging: " + product);
        }
    }
}
