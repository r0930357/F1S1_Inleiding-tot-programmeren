using System;

namespace Oefening_02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int landingsplaats;

            //inlezen
            landingsplaats = int.Parse(Console.ReadLine());

            //Bewerking
            if (landingsplaats == 1)
            {
                Console.WriteLine("0 punten.");
            }
            else if (landingsplaats == 2)
            {
                Console.WriteLine("20 punten.");
            }
            else if (landingsplaats == 3)
            {
                Console.WriteLine("50 punten.");
            }
            else
            {
                Console.WriteLine("100 punten.");
            }


            //weergave
            Console.ReadLine();
        }
    }
}
