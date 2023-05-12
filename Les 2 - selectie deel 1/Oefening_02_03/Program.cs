using System;

namespace Oefening_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            string voornaam, familienaam, leeftijdsGroep = "Volwassenen";
            int leeftijd;

            //inlezen
            voornaam = Console.ReadLine();
            familienaam = Console.ReadLine();

            leeftijd = int.Parse(Console.ReadLine());

            //bewerking
            if (leeftijd < 18)
            {
                leeftijdsGroep = "Jeugd";
            }

            //weergave
            Console.WriteLine(voornaam + " " + familienaam + ": " + leeftijdsGroep);
            Console.ReadLine();
        }
    }
}
