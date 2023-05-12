using System;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace Oefening_10_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Lees een bestandsnaam in.
             *  Indien het bestand bestaat lezen we deze uit.
             *  Hierbij word er in respectievelijke volgorde een bewerkingsteken, eerste getal en tweede getal opgegeven gescheiden door een puntkomma.
             *  Voorzie dat de gebruiker bij elk record de bewerking voorgeschoteld krijgt en dus een poging doet deze juist in te vullen.
             *  Bij het einde van het programma zal er een score op 10 geprint worden.
            */

            string bestandsnaam;
            bestandsnaam = Kiesbestand();
            LeesBestand(bestandsnaam);
            DrukOpEnter();
        }
        private static void LeesBestand(string bestandsnaam)
        {

            if (File.Exists(bestandsnaam))
            {

                int score = 0, opsomming = 0;

                using (StreamReader streamReader = new StreamReader(bestandsnaam))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();

                        //Bewerking
                        string[] data = record.Split(';');
                        string bewerking = data[0];
                        int getal1 = int.Parse(data[1]);
                        int getal2 = int.Parse(data[2]);

                        Console.Write($"Hoeveel is {getal1} {bewerking} {getal2}? ");

                        int resultaat = 0;
                        switch (bewerking)
                        {
                            case "+": resultaat = getal1 + getal2; break;
                            case "-": resultaat = getal1 - getal2; break;
                            case "*": resultaat = getal1* getal2; break;
                            case "/": resultaat = getal1 / getal2; break;
                        }

                        opsomming++;
                        if (Console.ReadLine() == resultaat.ToString())
                        {
                            score++;
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine($"Je scoorde {score} op {opsomming}");
            }
            else
            {
                Console.WriteLine($"{bestandsnaam} bestaat niet");
            }
        }

        private static string Kiesbestand()
        {
            string bestandsnaam;

            //Console.Write("Geef een bestandsnaam in: ");
            bestandsnaam = Console.ReadLine();

            return bestandsnaam;
        }

        private static void DrukOpEnter()
        {
            //Console.WriteLine("\nDruk op ENTER om af te sluiten...");
            Console.ReadLine();
        }
    }
}
