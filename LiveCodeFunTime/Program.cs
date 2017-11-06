using System;

namespace LiveCodeFunTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new double();
            result = 1;
            Console.WriteLine("Press any key...");
            var key = Console.ReadKey();
            Console.WriteLine(key);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
