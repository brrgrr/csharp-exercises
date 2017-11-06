using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    class Program
    {
        // Lists: Write a static method to find the sum of all the even numbers in a list. Within Main, create a list with at least 10 integers and call your method on the list.

        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> randInts = new List<int>();


            for (int ctr = 0; ctr <= 9; ctr++)
                randInts.Add(rand.Next(1, 11));

            Console.WriteLine(SumOfEvens(randInts));
            Console.ReadLine();
        }

        static int SumOfEvens(List<int> list)
        {
            return list.Where(i => i % 2 == 0).Sum();
        }
    }
}

