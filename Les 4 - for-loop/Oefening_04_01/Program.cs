using System;
using System.Runtime.CompilerServices;

namespace Oefening_04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal,aantalGetallen = 10, som = 0;

            //bewerking
            for(int i = 1; i <= aantalGetallen; i++)
            {
                getal = int.Parse(Console.ReadLine());
                som += getal;
            }

            //weergave
            Console.WriteLine($"Som: {som}");
            Console.ReadLine();

        }
    }
}
