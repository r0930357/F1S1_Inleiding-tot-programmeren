using System;

namespace Oefening_06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lees de familie- en voornaam van de gebruiker in. Controleer dat de invoer ingevuld is.
             * Lees de hobby van de gebruiker in aan de hand van het bijhorende nummer.
             * Hierbij wordt een tijdschrift suggestie getoond. Gebruik hiervoor onderstaande tabel.
             * Vervolgens krijgt de gebruiker opnieuw de optie om een hobby in te geven.
             * Het bovenstaande proces blijft gebeuren tot de gebruiker 8 ingeeft op de vraag welke hobby deze uitoefent.
            */

            //declaratie
            string naam, voornaam, tijdschrift = string.Empty, invoer, suggestie = string.Empty;
            int keuze = 0;

            //inlezen naam en voornaam
            do
            {
                Console.Write("Geef voornaam in: ");
                voornaam = Console.ReadLine();
            } while (string.IsNullOrEmpty(voornaam));

            do
            {
                Console.Write("Geef naam in: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrEmpty(naam));

            //PR1: Kritieke waarde
            do
            {
                Console.Write("Keuze hobby: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) || keuze < 1 || keuze > 8);

            //Begincriteria
            if (keuze == 8)
            {
                Console.WriteLine("Wij raden niets aan.");
            }
            else
            {
                //PR2: controle
                while (keuze != 8)
                {
                    //PR3: Operaties uitvoeren
                    switch (keuze)
                    {
                        case 1:
                            tijdschrift += "Wij raden \"Anna\" aan.\n";
                            break;
                        case 2:
                            tijdschrift += "Wij raden \"Knippie\" aan.\n";
                            break;
                        case 3:
                            tijdschrift += "Wij raden \"VtWonen\" aan.\n";
                            break;
                        case 4:
                            tijdschrift += "Wij raden \"Voetbal international\" aan.\n";
                            break;
                        case 5:
                            tijdschrift += "Wij raden \"Wandelen & Fietsen\" aan.\n";
                            break;
                        case 6:
                            tijdschrift += "Wij raden \"Zoom NL\" aan.\n";
                            break;
                        case 7:
                            tijdschrift += "Wij raden \"Runners\" aan.\n";
                            break;
                        case 8:
                            tijdschrift += "";
                            break;
                        default:
                            tijdschrift += "";
                            break;
                    }

                    //PR4: volgende kritieke waarde
                    do
                    {
                        Console.Write("Keuze hobby: ");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out keuze) || keuze < 1 || keuze > 8);
                }
            }

            //resultaat weergeven
            Console.WriteLine(tijdschrift);
            Console.ReadLine();
        }
    }
}
