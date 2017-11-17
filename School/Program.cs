using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Student
    {
        private string Name { get; set; }
        private int StudentId { get; set; }
        private int NumberOfCredits { get; set; }
        private double Gpa { get; set; }
    }
}
