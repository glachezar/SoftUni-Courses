using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split(" : ").ToArray();
                string courseName = tokens[0];
                string nameOfTheStudent = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(nameOfTheStudent);
                }
                else if(courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(nameOfTheStudent);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
