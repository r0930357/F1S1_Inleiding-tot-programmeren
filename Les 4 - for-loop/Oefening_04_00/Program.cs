using System;

namespace Oefeling_04_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int begin, einde, i;

            //inlezen
            begin = int.Parse(Console.ReadLine());

            //bewerking
            einde = begin + 11;
            for (i = begin + 1; i <= einde; i++)
            {
                //opdrachten
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
