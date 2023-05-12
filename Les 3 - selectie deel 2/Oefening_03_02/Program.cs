using System;
using System.Diagnostics.Tracing;

namespace Oefening_03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int jaar;

            //inlezen
            jaar = int.Parse(Console.ReadLine());

            //bewerking & weergave indien voorwaarde voldaan
            if (jaar > 1582)
            {
                if (jaar % 4000 == 0 || jaar % 100 == 0)
                {
                    Console.WriteLine(jaar + " is geen schrikkeljaar");
                }
                    if (jaar % 400 == 0 || jaar % 4 == 0)
                    {
                        Console.WriteLine(jaar + " is een schrikkeljaar");
                    }
                else
                {
                     Console.WriteLine(jaar + " is geen schrikkeljaar");
                }
            }
            else if (jaar % 4 == 0)
            {
                Console.WriteLine(jaar + " is een schrikkeljaar");
            }

            Console.ReadLine();

        }
    }
}
