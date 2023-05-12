using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Oefening_10_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lees de naam van een bestand in.
             * Indien het bestand de namen van vrienden bevat, druk je deze namen af.
             * Indien er geen vrienden zijn druk je “Geen vrienden”.
             * Indien het bestand niet bestaat, toon je “xxx bestaat niet”.
            */

            // Declaratie van de variabelen
            // List<string> vrienden = new List<string>();
            string bestandsnaam;

            // Inlezen van de bestandsnaam
            bestandsnaam = Kiesbestand();
            
            // Methode 2)
            LeesBestand(bestandsnaam);

            // Operaties
            // Methode 1)
            // Operaties
            // if (vrienden.Count > 0)
            // {
            //     Console.WriteLine("Vrienden:");
            // }
            // else
            // {
            //     Console.WriteLine("Geen vrienden");
            // }

            // Methode 2)
            // if (string.IsNullOrWhiteSpace(resultaat))
            // {
            //     Console.WriteLine("Geen vrienden");
            // }
            // else
            // {
            //     Console.WriteLine("Vrienden");
            //     Console.WriteLine(resultaat);
            // }

            // Methode 3)
            // LeesBestand(bestandsnaam);

            // Resultaat
            // Methode 1)
            // foreach (string vriend in vrienden)
            // {
            //     Console.WriteLine(vriend);
            // }


            // Methode 2)
            // Resultaat
            // Console.WriteLine(resultaat);

            Console.ReadLine();

            /* Werk enkele verplichte methodes uit:
             * `string LeesBestand(string bestandsnaam)
            */

        }

        // Methode 1) private static List(string) LeesBestand(string bestandsnaam)
        // Methode 2) private static string LeesBestand(string bestandsnaam)
        // Methode 3)
        private static void LeesBestand(string bestandsnaam)
        {
            //List<string> vrienden = new List<string>();
            string vrienden = "";

            if (File.Exists(bestandsnaam))
            {
                using (StreamReader streamReader = new StreamReader(bestandsnaam))
                {
                    while(!streamReader.EndOfStream)
                    {
                        string record = streamReader.ReadLine();
                        
                        // Methode 2 + 3)
                        vrienden += record + Environment.NewLine;

                        // Methode 3)
                        Console.WriteLine(record);

                        // Methode 1)
                        // vrienden.Add(record);
                    }
                }

                // Methode 3
                if (string.IsNullOrWhiteSpace(vrienden))
                {
                    Console.WriteLine("Geen vrienden");
                    vrienden += "Geen vrienden";
                }
                else
                {
                    vrienden = vrienden.Insert(0, "Vrienden:");
                    vrienden = vrienden.Insert(9, Environment.NewLine);
                    // Methode 2)
                    // Console.WriteLine("Vrienden:");
                    // Console.WriteLine(vrienden);
                } 

            }
            else
            {
                Console.WriteLine($"{bestandsnaam} - Bestand bestaat niet!");
            }

            // Methode 1 + 2)
            //return vrienden;
        }

        private static string Kiesbestand()
        {
            string bestandsnaam;

            Console.Write("Geef een bestandsnaam in: ");
            bestandsnaam= Console.ReadLine();

            return bestandsnaam;
        }
    }
}
