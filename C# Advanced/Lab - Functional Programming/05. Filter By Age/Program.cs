using System;
using System.Collections.Generic;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = ReadPeople();
            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);
        }

        private static Action<Person> CreatePrinter(object format)
        {
            throw new NotImplementedException();
        }

        private static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            throw new NotImplementedException();
        }

        private static Func<Person, bool> CreateFilter(object condition, object ageThreshold)
        {
            throw new NotImplementedException();
        }

        private static List<Person> ReadPeople()
        {
            throw new NotImplementedException();
        }
    }

    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}