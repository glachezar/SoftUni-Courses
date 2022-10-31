using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
		//The first should take no arguments and produce a person with the name "No name" and age = 1. 

		public Person()
		{
			this.Name = "No name";
			this.Age = 1;
		}

		//The second should accept only an integer number for the age and produce a person with the name "No name" and age equal to the passed parameter

        public Person(int age) : this()
        {
            this.Name = name;
            this.Age = age;
        }

        //The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age

        public Person(string name, int age) : this(age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}

        public override string ToString() => $"{this.Name} - {this.Age}";

    }
}
