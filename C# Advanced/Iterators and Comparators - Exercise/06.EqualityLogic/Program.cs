using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    public class Startup
    {
        static void Main(string[] args)
        {
            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            int nLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person
                {
                    Name = name,
                    Age = age,
                };

                hashSet.Add(person);
                sortedSet.Add(person);

            }
            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
