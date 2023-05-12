using System;

namespace Oefening_01_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            double straal, omtrek;

            //inlezen
            straal = double.Parse(Console.ReadLine());

            //berekenen
            omtrek = (2 * straal) * 3.14;

            //weergave
            Console.WriteLine("Omtrek: " + Math.Round(omtrek, 2));

            Console.ReadLine();
        }
    }
}
