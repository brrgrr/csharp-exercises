using System;

namespace RectangleArea
{
    class Program
    {
        // Numeric types: Write a program to calculate the area of a rectangle and print the answer to the console. You should prompt the user for the dimensions. (What data types should the dimensions be?)

        static void Main(string[] args)
        {
            Console.WriteLine("Length?");
            float length = GetDim();

            Console.WriteLine("Width?");
            float width = GetDim();

            Console.WriteLine($"Area: {length * width}");
            Console.ReadLine();
        }

        private static float GetDim()
        {
            string input = Console.ReadLine();
            return float.Parse(input);
        }
    }
}
