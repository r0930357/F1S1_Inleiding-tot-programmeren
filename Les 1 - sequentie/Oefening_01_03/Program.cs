using System;

namespace Oefening_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int volwassenen, kind;
            double prijs;

            //inlezen
            volwassenen = int.Parse(Console.ReadLine());
            kind = int.Parse(Console.ReadLine());

            //berekening
            prijs = (volwassenen * 10) + (kind * 7.5);

            //weergav
            Console.WriteLine("Totaal te betalen: " + string.Format("{0:0.00}", prijs) + " euro");
        }
    }
}
