using System;

namespace Oefening_04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie

            int getal, eersteGetal, tweedeGetal;

            getal = int.Parse(Console.ReadLine());

            eersteGetal = getal;
            tweedeGetal = getal + 1;

            Console.WriteLine(eersteGetal);
            Console.WriteLine(tweedeGetal);

            for (int i = getal; i < 9; i++)
            {
                getal = eersteGetal + tweedeGetal;
                Console.WriteLine(getal);
                eersteGetal = tweedeGetal;
                tweedeGetal = getal;
            }
            Console.ReadLine();
        }
    }
}
