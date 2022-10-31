using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numberOfPeople; i++)
            {

                family.AddMember(Console.ReadLine().Split());
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }

    class Family
    {
        public void AddMember(string[] memberInfo)
        {
            Person newMember = new Person(memberInfo[0], int.Parse(memberInfo[1]));

            this.FamilyMembers.Add(newMember);
        }
        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(m => m.Age).First();
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
