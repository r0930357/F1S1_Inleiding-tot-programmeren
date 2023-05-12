using System;
using System.Transactions;

namespace Oefening_08_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal, som = 0;
            //string invoer;

            //PR1
            getal = ReadNumber();

            //PR2
            while (!IsNegatief(getal))
            {
                
                //PR3
                som += getal;

                //PR4
                getal = ReadNumber();
            }

            Console.WriteLine($"Totaal: {som}");
            Console.ReadLine();
        }

        private static bool IsNegatief(int getal)
        {
            //bool isNegatief;

            if (getal <= 0)
            {
                return true;
                //isNegatief = true;
            }
            else
            {
                return false;
                //isNegatief = false;
            }
            //return isNegatief;
        }

        private static int ReadNumber()
        {
            string invoer;
            int getal;

            do
            {
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out getal));
            
            return getal;
        }
    }
}
