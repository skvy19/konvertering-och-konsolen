using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange decimaltal: ");
            string input;
            input = Console.ReadLine();

            double number = double.Parse(input);
            number = Convert.ToInt32(number);

            Console.WriteLine(number);
        }
    }
}
