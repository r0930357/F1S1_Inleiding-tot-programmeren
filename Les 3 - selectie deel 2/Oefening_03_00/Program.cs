using System;

namespace Oefening_03_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            string letter, uitvoer;

            //inlezen
            letter = Console.ReadLine();

            //bewerking
            switch (letter.ToLower())
            {
                case "a":
                case "e":
                case "o":
                case "i":
                case "u":
                    uitvoer = "Klinker.";
                    break;
                default:
                    uitvoer = "Medeklinker.";
                    break;
            }
            //weergave
            Console.WriteLine(uitvoer);
            Console.ReadLine();
        }
    }
}
