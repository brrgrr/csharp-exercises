using System;
using System.Collections.Generic;
using System.Text;

namespace class2review
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>()
            {"I", "am", "in", "a", "list!"};

            for (var i = 0; i < list1.Count; i++)
            {
                //   Console.Write(list1[i] + " ");
            }
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("StringBuilder: ");
            foreach (var item in list1)
            {
                stringBuilder.Append(item + " ");
            }
            Console.WriteLine(stringBuilder);


            string[] list2 = stringBuilder.ToString().Split();
            for (var i = 0; i < list2.Length; i++)
            {
                Console.WriteLine(list2[i]);
            }

            if (list1.Contains("loop") == false)
            {
                list1.Add("loop");
            }


            Dictionary<string, string> definitions = new Dictionary<string, string>();
            definitions.Add("C#", "Our group is now using C# in our projects. We can now get things done in half the time.");
            foreach (var keyVal in definitions)
            {
                Console.WriteLine(keyVal.Key + ": " + keyVal.Value);
            }
            if (definitions.ContainsKey("obstreperous") == false)
            {
                Console.WriteLine("I’m going to fail my SAT");
            }
            Dictionary<int, string> identification = new Dictionary<int, string>
            {
                { 1, "Bob"},
                { 2, "Ted"}
            };
            foreach (var keyVal in identification)
            {
                Console.WriteLine(keyVal.Key + ": " + keyVal.Value);
            }


            Dictionary<string, Dictionary<string, string>> translations = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> scarf = new Dictionary<string, string>
            {
                { "French", "écharpe"},
                { "Spanish", "bufanda"}
            };
            translations.Add("scarf", scarf);
            Dictionary<string, string> hello = new Dictionary<string, string>
            {
                { "French", "bonjour"},
                { "Spanish", "hola"}
            };
            translations.Add("hello", hello);



            Console.ReadKey();

        }
    }
}
