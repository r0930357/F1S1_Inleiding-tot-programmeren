using System;
using System.Reflection.Emit;

namespace Oefening_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lees voor 3 pijlen de landingsplaats en geef vervolgens een totaal van de punten weer.
             * Ingevoerde waardes moeten gehele getallen zijn die groter zijn dan 0 en kleiner of gelijk aan 4.
             * Na een correcte invoer, word een nieuw scherm getoond.
             * - Buiten de roos: 0 punten (landingsplaats 1)
             * - Binnenste ring: 20 punten (landingsplaats 2)
             * - Buitenste ring: 50 punten (landingsplaats 3)
             * - In het hart: 100 punten (landingsplaats 4)
            */

            Console.Title = "Les 5 - Oefening 5";

            int resultaat = 0, plaats = 0;
            string invoer;

            for (int i = 1; i <= 3; i++)
            {
                do
                {
                    do
                    {
                        Console.Write($"Worp {i}: ");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out plaats));
                } while (!(plaats > 0 && plaats <= 4));
                
                switch (plaats)
                {
                    case 1:
                        plaats = 0;
                        break;
                    case 2:
                        plaats = 20;
                        break;
                    case 3:
                        plaats = 50;
                        break;
                    case 4:
                        plaats = 100;
                        break;
                    default:
                        plaats = 0;
                        break;
                }

                resultaat += plaats;
            }

            Console.WriteLine($"U hebt {resultaat} punten behaald");
            Console.ReadLine();

        }
    }
}
