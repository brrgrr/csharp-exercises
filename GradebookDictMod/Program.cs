using System;
using System.Collections.Generic;
using System.Linq;

namespace GradebookDictMod
{
    class Program
    {
        // Dictionaries: Make a program similar to GradebookDict, but which takes in students names and ID numbers (as integers) instead of names and grades. In this case, however, the keys should be integers (the IDs) and the values should be strings (the names). Modify the roster printing code accordingly.

        public static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("id: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's name
                    Console.WriteLine("name: ");
                    string newName = (Console.ReadLine());

                    students.Add(Int32.Parse(newStudent), newName);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }


            Console.ReadLine();
        }
    }
}
