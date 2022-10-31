using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            int numberOfInputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputLines; i++)
            {
                string NameOfStudent = Console.ReadLine();
                double gradeOfStudent = double.Parse(Console.ReadLine());

                if (!studentGrades.ContainsKey(NameOfStudent))
                {
                    studentGrades.Add(NameOfStudent, new List<double>());
                    studentGrades[NameOfStudent].Add(gradeOfStudent);
                }
                else
                {
                    studentGrades[NameOfStudent].Add(gradeOfStudent);
                }
            }

            Dictionary<string, double> studentAverageGrade = new Dictionary<string, double>();
            foreach (var student in studentGrades)
            {
                studentAverageGrade.Add(student.Key, student.Value.Average());
            }

            foreach (var student in studentAverageGrade.Where(g => g.Value >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
