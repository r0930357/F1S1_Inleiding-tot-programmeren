using System;

namespace Oefening_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal;

            //inlezen
            getal = int.Parse(Console.ReadLine());

            //berekening

            if (getal % 11 == 0 && getal % 5 == 0)
            {
                Console.WriteLine("Deelbaar.");
            }
            else
            {
                Console.WriteLine("Niet deelbaar.");
            }

            //weergave
            Console.ReadLine();
        }
    }
}
