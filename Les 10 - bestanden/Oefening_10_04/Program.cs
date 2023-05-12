using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Runtime.CompilerServices;

namespace Oefening_10_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Toon een lijst van alle 10 gedichten die de gebruiker kan kiezen alsook de optie 0 om te stoppen.
             * Laat de gebruiker herhaaldelijk kiezen welk gedicht deze wil bekijken.
             * Bij een keuze verschillend van 0, zal een gedicht getoond worden.
             * De opbouw van het gedicht kan je terugvinden in de bijhorende bestanden 'gedichten-n.txt' waarbij n de nummer van het gedicht is.
            */

            int bestandsnummer, nummer = 0;

            bestandsnummer = BestandsNummer(nummer);

            if (bestandsnummer == 0)
            {
                DrukOpEnter();
            }
            else
            {
                while (bestandsnummer != 0)
                {
                    string bestandsnaam = ($"gedicht-{bestandsnummer}.txt");
                    string naam = ($"Gedicht {bestandsnummer}");
                    Console.WriteLine(naam);
                    Console.WriteLine(new String('=', naam.Length));
                    LeesBestand(bestandsnaam);

                    bestandsnummer = BestandsNummer(nummer);
                    Console.Clear();
                }
            Console.ReadLine();
            }
        }

        private static int BestandsNummer(int nummer)
        {
            string invoer;
            
            do
            {
                //Console.Write("Kies een bestand: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out nummer) && nummer <= 0 || nummer > 11);

            return nummer;
        }

        private static void LeesBestand(string bestandsnaam)
        {

            if (File.Exists(bestandsnaam))
            {
                using (StreamReader streamReader = new StreamReader(bestandsnaam))

                    while (!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();
                        Console.WriteLine(record);
                    }
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} - Bestand bestaat niet!");
            }
        }
        private static void DrukOpEnter()
        {
            Console.WriteLine("Druk op enter om af te sluiten");
            Console.ReadLine();
        }
    }
}