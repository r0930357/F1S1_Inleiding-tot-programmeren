using System;

namespace Oefening_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            string naam, voornaam, tijdschrift, cijfer;

            //inlezen
            voornaam = Console.ReadLine();
            naam = Console.ReadLine();
            cijfer = Console.ReadLine();
            tijdschrift = "";

            //bewerking
            switch (cijfer)
            {
                case "1":
                    tijdschrift = "\"Anna\"";
                     break;
                case "2":
                    tijdschrift = "\"Knippie\"";
                    break;
                case "3":
                    tijdschrift = "\"VtWonen\"";
                    break;
                case "4":
                    tijdschrift = "\"Voetbal international\"";
                    break;
                case "5":
                    tijdschrift = "\"Wandelen & Fietsen\"";
                    break;
                case "6":
                    tijdschrift = "\"Zoom NL\"";
                    break;
                case "7":
                    tijdschrift = "\"Runners\"";
                    break;
                default:
                    tijdschrift = "-";
                    break;
            }

            //resultaat
            Console.WriteLine(voornaam + " " + naam.ToUpper() + ", tijdschrift: " + tijdschrift);
            Console.ReadLine();
        }
    }
}
