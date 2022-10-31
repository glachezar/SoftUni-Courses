using System;
using System.Linq;
using System.Xml.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Family members = new Family();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                members.AddMember(person);

            }

            Person[] filteredPeople = members.People
                .FindAll(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ToArray();

            foreach (Person person in filteredPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
