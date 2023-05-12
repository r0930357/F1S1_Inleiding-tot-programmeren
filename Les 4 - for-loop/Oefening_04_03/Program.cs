using System;
using System.CodeDom.Compiler;

namespace Oefening_04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double getal, kwadraat;

            //inlezen
            getal = double.Parse(Console.ReadLine());    

            //bewerking
            for (double i = getal; i >= 1; i--)
            {
                kwadraat = Math.Pow(getal, 2);
                Console.WriteLine(kwadraat);
                getal--;
            }

            //weergave
            Console.ReadLine();
        }
    }
}