using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                Students student = new Students(tokens[0], tokens[1], double.Parse(tokens[2]));
                students.Add(student);
            }

            List<Students> studentsOrderByGrade = students.OrderByDescending(g => g.Grade).ToList();
            foreach (Students student in studentsOrderByGrade)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

    }
}
