using System;

namespace Oefening_01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie

            double massa, lengte, polsomtrek;

            //inlezen
            lengte = double.Parse(Console.ReadLine());
            polsomtrek = double.Parse(Console.ReadLine());

            //berekening
            /*
            M = (L + 4 * P - 100) / 2
            */
            massa = (lengte + 4 * polsomtrek - 100) / 2;

            //weergave
            Console.WriteLine();
            Console.WriteLine($"Ideaal gewicht: {massa} kilo");
        }
    }
}
