using System;

namespace Oefening_01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            string doosRood, doosBlauw, hulp;

            //inlezen
            doosRood = Console.ReadLine();
            doosBlauw = Console.ReadLine();

            //weergeven inlezen
            Console.WriteLine("Doos rood: " + doosRood);
            Console.WriteLine("Doos blauw: " + doosBlauw);

            //bewerking
            hulp = doosBlauw;
            doosBlauw = doosRood;
            doosRood = hulp;

            //weergeven
            Console.WriteLine("Doos rood na wissel: " + doosRood);
            Console.WriteLine("Doos blauw na wissel: " + doosBlauw);

        }
    }
}
