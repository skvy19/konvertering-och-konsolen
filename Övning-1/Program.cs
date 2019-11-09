using System;

namespace Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange heltal: " );
            string input;
            input = Console.ReadLine();
            int num1 = int.Parse(input);

            Console.Write("Ange heltal: ");
            input = Console.ReadLine();
            int num2 = int.Parse(input);

            int sum = num1 + num2;

            Console.WriteLine("Sum: " + sum);
        }
    }
}
