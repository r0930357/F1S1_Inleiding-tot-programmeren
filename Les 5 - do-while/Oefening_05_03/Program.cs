using System;
using System.Security.Cryptography.X509Certificates;

namespace Oefening_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Schrijf een applicatie die passagiers van een bus registreert.
            De bus heeft 8 zitplaatsen en 4 daarvan zijn aan het raam.
            Vanaf dat alle plaatsen bezet zijn of wanneer de raamplaatsen bezet zijn, stop je met passagiers toevoegen.
            Vraag aan elke passagier of ze aan het raam willen zitten of niet. Enkel 'Y' of 'N' wordt aanvaardt als een geldig antwoordt.
            Wanneer alle plaatsen bezet zijn OF wanneer alle raamplaatsen bezet zijn, stop je met passagiers toevoegen.
            Toon nu het totaal aantal passagiers en hoeveel daarvan aan het raam zitten.
            */

            int zitplaatsRaam = 0, zitplaats = 0, totaalAantalPassagiers;
            string invoer;

            do
            {
                //Console.Write("Wil u aan het raam zitten? (Y/N)?: ");
                invoer = Console.ReadLine();
                if (invoer == "Y")
                {
                    zitplaatsRaam++;
                    zitplaats++;
                }
                else if (invoer == "N")
                {
                    zitplaats++;
                }
            } while ((zitplaats <= 7) && zitplaatsRaam <= 3);

            totaalAantalPassagiers = (zitplaats - zitplaatsRaam) + zitplaatsRaam;

            Console.WriteLine("Er zijn {0} passagiers. {1} zitten er aan het raam.", totaalAantalPassagiers, zitplaatsRaam);
            Console.ReadLine();
        }
    }
}
