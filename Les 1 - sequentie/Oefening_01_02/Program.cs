using System;

namespace Oefening_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            decimal prijs, btw, inclbtw;

            //inlezen
            prijs = decimal.Parse(Console.ReadLine());
            btw = decimal.Parse(Console.ReadLine());

            //bewerking
            inclbtw = ((btw / 100) + 1) * prijs;

            //weergave
            Console.WriteLine("Prijs inclusief BTW: " + String.Format("{0:0.00}", inclbtw));
        }
    }
}
