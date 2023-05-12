using System;

namespace Oefening_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int x, y;

            //inlezen
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            //bewerking & resultaat weergeven
            if (x >= 0 && y > 0)
            {
                Console.WriteLine("Punt ligt in het eerste kwadrant.");
            }
            else if (x < 0 && y >= 0)
                {
                    Console.WriteLine("Punt ligt in het tweede kwadrant.");
                }
            else if (x < 0 && y <= 0)
                {
                    Console.WriteLine("Punt ligt in het derde kwadrant.");
                }
            else if (x >= 0 && y < 0)
            {
                Console.WriteLine("Punt ligt in het vierde kwadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Punt ligt in de oorsprong.");
            }
            Console.ReadLine();
        }
    }
}
