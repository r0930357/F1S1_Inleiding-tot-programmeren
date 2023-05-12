using System;

namespace Oefening_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie

            int natoproep, internatoproep;
            double prijs;

            //inlezen
            natoproep = int.Parse(Console.ReadLine());
            internatoproep = int.Parse(Console.ReadLine());

            //berekening
            prijs = (23 + (natoproep * 0.12) + (internatoproep * 0.12)) * 1.21;

            //weergave
            Console.WriteLine("Totaal te betalen: " + String.Format("{0:0.00}", prijs) + " euro");
        }
    }
}
