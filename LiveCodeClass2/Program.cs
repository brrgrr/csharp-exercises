using System;
using System.Collections.Generic;

namespace LiveCodeClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Bob");
            names.Add("Susan");

            if (names.Contains("Bob"))
            {
                //do something
            }
            else if (names.Count > 5)
            {
                //do something else
            }
            else if (names.IndexOf("Bob") == 0)
            {
                //do something else
            }
            else
            {
                // finally more stuff
            }

            var students = new Dictionary<string, int>
            {
                { "Ernie", 99 },
                { "Ziki", 92}
            };
            foreach (var keyVal in students)
            {
                Console.WriteLine(keyVal.Key + " " + keyVal.Value);

            }

            foreach (var name in students.Keys)
            {
                Console.WriteLine(name);

            }
            Console.ReadKey();


        }
    }
}
