using System;
using System.CodeDom.Compiler;

namespace Oefening_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int getal1, getal2, getal3, uitkomst;
            string lettercode, cijfercode, combinatie;

            //inlezen
            getal1 = Convert.ToInt32(Console.ReadLine());
            getal2 = Convert.ToInt32(Console.ReadLine());
            getal3 = Convert.ToInt32(Console.ReadLine());
            lettercode = Console.ReadLine();
            cijfercode = Console.ReadLine();

            //bewerking

            combinatie = lettercode + cijfercode;

            switch (combinatie)
            {
                case "A1":
                uitkomst = getal1 + getal2;
                    Console.WriteLine(getal1 + " + " + getal2 + " = " + uitkomst);
                    break;
                case "A2":
                    uitkomst = getal2 + getal3;
                    Console.WriteLine(getal2 + " + " + getal3 + " = " + uitkomst);
                    break;
                case "A3":
                    uitkomst = getal1 + getal3;
                    Console.WriteLine(getal1 + " + " + getal3 + " = " + uitkomst);
                    break;
                case "B1":
                    uitkomst = getal1 - getal2;
                    Console.WriteLine(getal1 + " - " + getal2 + " = " + uitkomst);
                    break;
                case "B2":
                    uitkomst = getal2 - getal3;
                    Console.WriteLine(getal2 + " - " + getal3 + " = " + uitkomst);
                    break;
                case "B3":
                    uitkomst = getal1 - getal3;
                    Console.WriteLine(getal1 + " - " + getal3 + " = " + uitkomst);
                    break;
                default:
                    Console.WriteLine("ongeldige combinatie");
                    break;
            }

            Console.ReadLine();
        }
    }
}
