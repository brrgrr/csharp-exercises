using System;

namespace Array
{
    class Program
    {
        // Arrays: Create and initialize in a single line an array with the following values: 1, 1, 2, 3, 5, 8. Then loop through the array and print out each value.

        static void Main(string[] args)
        {
            int[] anArray = { 1, 1, 2, 3, 5, 8 };
            foreach (var i in anArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
