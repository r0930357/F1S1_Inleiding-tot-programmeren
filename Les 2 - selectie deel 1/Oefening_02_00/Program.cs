using System;

namespace Oefening_02_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            double getal;
            string resultaat;

            //inlezen
            getal = double.Parse(Console.ReadLine());

            //bewerking
            if (getal < 0)
            {
                resultaat = ("Negatief");
            }
            else
                resultaat = ("Positief");

            //weergave
            Console.WriteLine(resultaat);
            Console.ReadLine();


        }
    }
}
