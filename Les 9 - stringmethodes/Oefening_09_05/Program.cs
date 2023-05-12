using System;

namespace Oefening_09_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Een gebruiker voert een woord in.
             * Jij drukt een lijn af met sterretjes onder dat woord.
             * Je hoeft geen lussen te gebruiken.
             * Hint: new String(char c, int count) - char staat tussen single quotes!
            */

            string woord = Console.ReadLine();
            Console.WriteLine(new string('*', woord.Length));
            Console.ReadLine();
        }
    }
}
