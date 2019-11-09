using System;

namespace Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Läser keyevent press och är inte case sensitive. Dock går inte att skriva varken 'nepp' eller 'jepp' 
            Console.WriteLine("*************** Lösning 1 *********************************");
            Console.WriteLine("Är det fint väder? (J/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.J) {
                Console.WriteLine("Gå på picknick!");
            } else if (Console.ReadKey(true).Key == ConsoleKey.N) {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            } else {
                Console.WriteLine("Jag förstår inte riktigt!");
            };

            // Inmatning är styrd av IF-sats med alla möjliga varianter av första tecken
            Console.WriteLine("*************** Lösning 2 *********************************");
            Console.WriteLine("Är det fint väder?");
            string input = Console.ReadLine();
            if (input == "j" || input == "J" || input.StartsWith("J") || input.StartsWith("j")) {
                Console.WriteLine("Gå på picknick!");
            } else if (input == "n" || input == "N" || input.StartsWith("N") || input.StartsWith("n")) {
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            } else {
                Console.WriteLine("Jag förstår inte riktigt!");
            };

            // Inmatning är konverterat till ett stort eller litet char 
            Console.WriteLine("*************** Lösning 3 *********************************");
            Console.WriteLine("Är det fint väder?");
            input = Console.ReadLine().ToUpper(); // eller toLower()
            if (input == "J" || input.StartsWith("J")) { // "J" ska ersättas med "j" om toLower() används
                Console.WriteLine("Gå på picknick!");
            } else if (input == "N" || input.StartsWith("N")) { // "N" ska ersättas med "n" om toLower() används
                Console.WriteLine("Du borde stanna hemma och läsa en bok om programmering!");
            } else {
                Console.WriteLine("Jag förstår inte riktigt!");
            };
            
        }
    }
}
