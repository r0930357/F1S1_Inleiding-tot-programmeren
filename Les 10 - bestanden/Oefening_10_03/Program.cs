using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Oefening_10_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lees 2 getallen in.
             * Het eerste getal is de keuze uit een menu.
             * Deze keuze kan enkel 1, 2 of 3 zijn.
             * Het tweede getal wordt gebruikt om het bijhorende studentenbestand in te lezen.
             * Elk studentenbestand bevat alle scores van de studenten.
             * Indien je het getal 1 kiest, lees je bestand studenten-1.txt in.
             * Afhankelijk van de menukeuze en de betandskeuze, zorg je nu voor de juiste output.
            */

            int keuze = LeesGetalMenu();
            switch (keuze)
            {
                case 1: GeefGemiddelde(LeesPunten(LeesBestandsnaam())); break;
                case 2: GeefMax(LeesPunten(LeesBestandsnaam())); break;
                case 3: GeefMin(LeesPunten(LeesBestandsnaam())); break;
            }
            EindeProgramma();
        }
        private static void EindeProgramma()
        {
            Console.WriteLine("\nDruk ENTER om af te sluiten!");
        }
        private static int LeesGetalMenu()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een getal (1-3): ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || number < 1 || number > 3);
            return number;
        }
        private static string LeesBestandsnaam()
        {
            string input;
            int number;
            do
            {
                Console.Write("Geef een studentenbestand: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number));
            return $"studenten-{number}.txt";
        }
        private static List<int> LeesPunten(string bestandsnaam)
        {
            bool stop = false;
            List<int> punten = new List<int>();
            while (!stop)
            {
                if (File.Exists(bestandsnaam))
                {
                    using (StreamReader streamReader = new StreamReader(bestandsnaam))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            string record = streamReader.ReadLine();
                            punten.Add(int.Parse(record));
                        }
                    }
                    stop = true;
                }

                else
                {
                    bestandsnaam = LeesBestandsnaam();
                    stop = false;
                }
            }

            return punten;
        }
        private static void GeefGemiddelde(List<int> punten)
        {
            double som = 0;
            foreach (var item in punten)
            {
                som += item;
            }
            Console.WriteLine($"Het gemiddelde is {som / punten.Count}");
        }
        private static void GeefMax(List<int> punten)
        {
            double max = int.MinValue;
            foreach (var item in punten)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            Console.WriteLine($"De hoogste score is {max}");
        }
        private static void GeefMin(List<int> punten)
        {
            double min = int.MaxValue;
            foreach (var item in punten)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            Console.WriteLine($"De laagste score is {min}");
        }
    }
}