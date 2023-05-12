using System;

namespace Oefening_06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lees de naam van het evenement in. De naam mag niet leeg zijn.
             * Lees in of de gebruiker een naam wil toevoegen aan de namenlijst voor een evenement. Enkel ja of nee worden als correcte invoer aangenomen.
             * Wanneer de gebruiker ja invult, zal hij de mogelijkheid krijgen om een naam op te geven.
             * Vervolgens krijgt de gebruiker opnieuw de optie of deze een naam wenst toe te voegen aan de lijst.
             * Het bovenstaande proces blijft gebeuren tot de gebruiker nee antwoord op de vraag of deze een naam wil toevoegen.
             * Hierna wordt de volledige namenlijst getoond. Indien de gebruiker meteen nee invulde, zal er "Er zijn geen aanwezigen!" Verschijnen
            */

            //declaratie
            string evenement, persoon, overzicht = string.Empty, antwoord;

            //Inlezen
            //Evenement
            do
            {
                //Console.Write("Geef de naam van het evenement in: ");
                evenement = Console.ReadLine();
            } while (string.IsNullOrEmpty(evenement));

            //Persoon - PR1: Kritieke waarde
            do
            {
                //Console.Write("Persoon toevoegen? ");
                antwoord = Console.ReadLine().ToLower();
            } while (antwoord != "ja" && antwoord != "nee");

            //PR2: Controle
            while (antwoord == "ja")
            {
                //PR3: Operaties uitvoeren
                do
                {
                    //Console.Write("Naam van de persoon: ");
                    persoon = Console.ReadLine();
                } while (string.IsNullOrEmpty(persoon));

                overzicht += persoon + "\n";
                //overzicht = overzicht + persoon + "\n";

                //PR4: lezen volgende kritieke waarde
                do
                {
                    //Console.Write("Nog een persoon toevoegen? ");
                    antwoord = Console.ReadLine().ToLower();
                } while (antwoord != "ja" && antwoord != "nee");
            }

            //Resultaat afrukken
            if (overzicht == string.Empty)
            {
                Console.WriteLine($"Er zijn geen aanwezigen voor {evenement}!");
            }    
            else
            {
                Console.WriteLine($"Aanwezigen voor {evenement}: \n{overzicht}");
            }

            Console.ReadLine();
        }
    }
}