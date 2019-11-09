using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du i förnamn?: ");
            string firstName = Console.ReadLine();
            Console.Write("Vad heter du i efternamn?: ");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;

            Console.Write("Hur gammal är du?: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            DateTime birthday = DateTime.Parse("1986/04/17");
            DateTime now = DateTime.Now;
            TimeSpan days = now.Subtract(birthday);
            Console.WriteLine("Du har levt " + Math.Round(days.TotalDays, 0) + " dagar!");
        }
    }
}
