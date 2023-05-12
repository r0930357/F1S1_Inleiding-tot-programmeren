using System;

namespace Oefening_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int prijs, aantalArtikelen = 5, totaalPrijs = 0, aantalJarenLid, korting;

            for (int i = 1; i <= aantalArtikelen; i++)
            {
                do
                {
                    //Console.Write($"Geef de prijs voor artikel {i}: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out prijs));
                
                totaalPrijs += prijs;
            }
            
            do
            {
                //Console.Write("Hoeveel jaren ben je reeds lid?: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out aantalJarenLid) || aantalJarenLid <= 0 && aantalArtikelen >= 5);

            switch (aantalJarenLid)
            {
                case 1:
                    korting = 5;
                    break;
                case 2:
                    korting = 10;
                    break;
                case 3:
                    korting = 20;
                    break;
                case 4:
                    korting = 30;
                    break;
                case 5:
                    korting = 50;
                    break;
                default:
                    korting = 0;
                    break;
            }

            totaalPrijs -= korting;

            Console.WriteLine("Totaalprijs: " + totaalPrijs + " euro");
            Console.ReadLine();
        }
    }
}
