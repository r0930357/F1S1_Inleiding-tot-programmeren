using System;

namespace Oefening_04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int begingetal, eindgetal;
            string resultaat = "";

            begingetal = int.Parse(Console.ReadLine());
            eindgetal = int.Parse(Console.ReadLine());

            for (int i = begingetal; i >= eindgetal + 1; i--)
            {
            resultaat += i + " * ";
            }
            
            Console.WriteLine(resultaat + eindgetal);
            Console.ReadLine();
        }
    }
}
