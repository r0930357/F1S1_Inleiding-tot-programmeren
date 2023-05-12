using System;
using System.Transactions;

namespace Oefening_06_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lees namen en scores van studenten in.
             * Wanneer een lege naam ingegeven wordt, zal er een overzicht afgeprint worden van alle studenten en hun scores gevolgd door een gemiddelde van de klas.
             * Wanneer er geen namen ingegeven wordt, zal de tekst 'Geen aanwezigen' getoond worden.
             * Zorg voor gegevensvalidatie wanneer er een score wordt ingegeven: dit moet een numerieke waarde zijn.
             */

            int score, totaal = 0, gemiddelde = 0, aantalStudent = 0;
            string invoer, student, overzicht = string.Empty;

            //PR1: Kritieke waarde
            //Console.Write("Studentnaam: ");
            student = Console.ReadLine();

            if (student == "")
            {
                Console.WriteLine("Geen aanwezigen");
            }
            else
            {
                //PR2: Controle
                while (student != "")
                {
                    //PR3: Operaties uitvoeren
                    do
                    {
                        //Console.Write("Geef de score in: ");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out score));

                    totaal += score;
                    overzicht += student + ($" ({score})" + "\n");

                    aantalStudent++;

                    //PR4: lezen volgende kritieke waarde
                    //Console.Write("Studentnaam: ");
                    student = Console.ReadLine();
                }

                gemiddelde = totaal / aantalStudent;

                Console.WriteLine($"{overzicht}Gemiddelde: {gemiddelde}");
            }

            Console.ReadLine();
        }
    }
}
