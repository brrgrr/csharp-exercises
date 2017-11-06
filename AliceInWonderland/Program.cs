using System;

namespace AliceInWonderland
{
    class Program
    {
        // Strings: The first sentence of Alice's Adventures in Wonderland is below. Store this sentence in a string, and then prompt the user for a string to search for within this string. Print whether or not the search term was found. See if you can make the search case-insensitive, so that searching for "alice" prints true.
        // Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'

        static void Main(string[] args)
        {
            string aaiw = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine();
            Console.WriteLine(aaiw);
            Console.WriteLine();
            Console.WriteLine("Input search string:");
            string input = Console.ReadLine();
            Console.WriteLine(IsFound(aaiw, input));
            Console.ReadLine();


        }

        private static bool IsFound(string blob, string sub)
        {
            if (sub != "")
            {
                return blob.IndexOf(sub) >= 0;

            }
            else { return false; }
        }
    }
}
