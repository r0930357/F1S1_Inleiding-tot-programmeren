using System;
using System.Collections.Generic;
using System.Linq;


namespace Oefening07_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string word, kortsteWoord = "", langsteWoord = "";
            int som; //lengteKortsteWoord = 999, lengteLangsteWoord = 0;


            word = Console.ReadLine();

            while (word != "")
            {
                words.Add(word);
                word = Console.ReadLine();
            }

            /*for (int i = 0; i < words.Count; i++)
            {
                if (lengteKortsteWoord < words[i].Length)
                {
                    kortsteWoord = words[i];
                }

                if (lengteLangsteWoord > words[i].Length)
                {
                    langsteWoord = words[i];
                }
            }
            foreach (string woord in words)
            {
                if (lengteKortsteWoord < woord.Length)
                {
                    kortsteWoord = woord;
                    lengteKortsteWoord = woord.Length;
                }

                if (lengteLangsteWoord > woord.Length)
                {
                    langsteWoord = woord;
                    lengteLangsteWoord = woord.Length;
                }
            }*/

            int minLength = words.Min(y => y.Length);
            kortsteWoord = words.FirstOrDefault(x => x.Length == minLength);
            int maxLength = words.Max(y => y.Length);
            langsteWoord = words.FirstOrDefault(x => x.Length == maxLength);


            som = words.IndexOf(kortsteWoord) + words.IndexOf(langsteWoord);

            Console.WriteLine($"Het langste woord is {langsteWoord}");
            Console.WriteLine($"Het kortste woord is {kortsteWoord}");
            Console.WriteLine($"De som van de posities is {som}");

            Console.ReadLine();
        }
    }
}