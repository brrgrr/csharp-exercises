using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradebookSB
{
    class Program
    {
        // Strings: In one of the Gradebook programs (it doesn't matter which), modify the code that prints out the class roster near the end of the program to use the StringBuilder class.

        public static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("name: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    // Get the student's grade
                    Console.WriteLine("grade: ");
                    double newGrade = double.Parse(Console.ReadLine());

                    students.Add(newStudent, newGrade);
                }
            }
            while (newStudent != "");

            // Print class roster
            StringBuilder classRoster = new StringBuilder();
            classRoster.Append("\nClass roster:");
            foreach (KeyValuePair<string, double> student in students)
            {
                classRoster.Append("\n" + student.Key + " (" + student.Value + ")");
            }

            double sum = students.Values.Sum();
            double avg = sum / students.Count;
            classRoster.Append("\n\nAverage grade: " + avg);

            // Print class roster
            Console.WriteLine(classRoster);
            Console.ReadLine();
        }
    }
}
