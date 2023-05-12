using System;

namespace Oefening_01_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int lengte, breedte, omtrek, oppervlakte;

            //inlezen
            lengte = Convert.ToInt32(Console.ReadLine());
            breedte = int.Parse(Console.ReadLine());

            //berekening
            omtrek = (2 * lengte) + (2 * breedte);
            oppervlakte = lengte * breedte;

            //weergave
            Console.WriteLine("Omtrek: " + omtrek);
            Console.WriteLine("Oppervlakte: " + oppervlakte);
        }
    }
}
