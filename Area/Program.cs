using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
                        
            Console.WriteLine("Enter a radius:");
            string input = Console.ReadLine();
            float radius = float.Parse(input);
            var area = pi * radius * radius;
            Console.WriteLine(string.Format("The area of a circle with radius {0} is: {1}",radius, area));
            Console.ReadLine();
        }
    }
}
