using System;

namespace MilesPerGallon
{
    class Program
    {
        // Numeric types: Write a program that asks a user for the number of miles they have driven and the amount of gas they've consumed (in gallons), and print their miles-per-gallon.

        static void Main(string[] args)
        {
            Console.WriteLine("Miles driven?");
            float miles = GetNum();

            Console.WriteLine("Gallons used?");
            float gallon = GetNum();

            Console.WriteLine($"MPG: {miles / gallon}");
            Console.ReadLine();
        }

        private static float GetNum()
        {
            string input = Console.ReadLine();
            return float.Parse(input);
        }
    }
}
