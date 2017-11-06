using System;

namespace HelloWorldName
{
    class Program
    {
        // Input/output: Modify your HelloWorld program to prompt the user for their name, and greet them by name.

        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.ReadLine();
        }
    }
}
