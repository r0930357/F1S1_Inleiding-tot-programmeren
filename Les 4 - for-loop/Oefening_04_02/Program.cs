using System;

namespace Oefening_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie
            int geluksgetal;
            string naam, resultaat;

            //inlezen
            naam = Console.ReadLine();
            geluksgetal = int.Parse(Console.ReadLine());
            
            resultaat = $"{geluksgetal} ";
            // vb: resultaat = "4 "

            //bewerking
            for (int i = 1; i <= geluksgetal; i++)
            {
                resultaat += $"{naam} ";
                //vb: resultaat += "Joren " -> de naam "Joren " wordt toegevoegd aan "4 "
            }

            //Iteratie 1: 4 Joren 
            //Iteratie 2: 4 Joren Joren 
            //Iteratie 3: 4 Joren Joren Joren 
            //Iteratie 4: 4 Joren Joren Joren Joren 

            //weergave
            Console.WriteLine(resultaat);
            Console.ReadLine();
        }
    }
}
