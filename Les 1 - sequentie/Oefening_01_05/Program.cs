using System;

namespace Oefening_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie

            double F, C;

            //inlezen
            C = double.Parse(Console.ReadLine());

            //berekeken
            F = C * 9 / 5 + 32;

            //weergave
            Console.WriteLine("Fahrenheit: " + string.Format("{0:0.00}", F));
        }
    }
}
