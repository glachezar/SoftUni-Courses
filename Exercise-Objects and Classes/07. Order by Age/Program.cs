using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Channels;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();

                if (tokens[0] == "End")
                {
                    break;
                }


                var person = new People(tokens[0], tokens[1], int.Parse(tokens[2]));
                people.Add(person);

            }
            people.OrderBy(person => person.Age).ToList().ForEach(person => Console.WriteLine(person));
        }
    }

    class People
    {
        public People(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }


}
